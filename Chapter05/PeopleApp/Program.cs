using Packt.Shared;
using System.Globalization;
using Dumpify;
using PacktLibraryModern;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace PeopleApp
{

    internal partial class Program
    {
        static void Main(string[] args)
        {
            
            ConfigureConsole();
            Person bob = new Person();
            

            bob.Name = "Bob";
            bob.Born = new DateTimeOffset(year: 1965, month: 12, day: 22, hour: 16, minute: 28, second: 0, offset: TimeSpan.FromHours(-5));
            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.ColossusOfRhodes;
            bob.FavorateAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

            Person alfred = new Person();
            alfred.Name = "Alfred";
            bob.Children.Add(alfred);
            bob.Children.Add(new Person { Name = "Bella"});
            bob.Children.Add(new () {Name = "Zoe" });

            WriteLine(format: "{0} was born on {1:D}." , arg0: bob.Name, arg1: bob.Born);
            WriteLine($"{bob.Name}'s favorate wonder is {bob.FavorateAncientWonder}. its integer is {((int)bob.FavorateAncientWonder)}");
            WriteLine($"{bob.Name}'s BucketList is {bob.BucketList}. ");
            WriteLine($"{bob.Name} has {bob.Children.Count} children.");
            foreach (Person child in bob.Children)
            {
                WriteLine($">>   {child.Name}");
            }
            for (int i = 0; i < bob.Children.Count; i++)
            {
                WriteLine($">>   {bob.Children[i].Name}");
            }

            bob.Dump(label: "Default output");

            bob.Dump(label: "Include fields and non-public members", members: new MembersConfig {IncludeFields = true, IncludeNonPublicMembers = true });

            Book book = new() 
            { 
                Isbn = "978-1803237800",
                Title = "C# 14 and .NET 10 - Modern Cross-Platform Development Fundamentals"
            };

            WriteLine($"{book.Isbn}: {book.Title} written by {book.Author} has {book.PageCount:N0} pages.");

            int a = 10;
            int b = 20;
            int c = 30;
            int d = 40;
            WriteLine($"Before: a:{a} . b:{b} , c:{c} , d:{d}");
            bob.PassingParameters(a,b,ref c,out d);
            WriteLine($"After: a:{a} . b:{b} , c:{c} , d:{d}\n\n");

            int e = 50;
            int f = 60;
            int g = 70;
            WriteLine($"Before: e:{e} . f:{f} , g:{g} , h dosen't exsit yet!");
            bob.PassingParameters(e, f, ref g, out int h);
            WriteLine($"Before: e:{e} . f:{f} , g:{g} , h:{h}");

            (string, int) Fruit = bob.GetFruit();
            WriteLine($"{Fruit.Item1}, {Fruit.Item2} there are.\n\n");

            var (name1, dob1) = bob;
            var (name2, dob2, fav2) = bob;
            WriteLine($"Deconstructed person: {name1}, {dob1}");
            WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

            Person sam = new Person();
            sam.Name = "Sam";

            sam.Children.Add(new() { Name = "Charlie", Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero) });
            sam.Children.Add(new() { Name = "Ella", Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero) });

            WriteLine($"Sam's first child is {sam.Children[0].Name}");
            WriteLine($"Sam's second child is {sam.Children[1].Name}");

            WriteLine($"Sam's first child is {sam[0].Name}");
            WriteLine($"Sam's second child is {sam[1].Name}");

            WriteLine($"Sam's child named Ella is {sam["Ella"].Age}\n\n");

            Passenger[] passengers =
                {
                    new FirstClassPassenger {AirMiles = 1_419, Name = "Suman"},
                    new FirstClassPassenger {AirMiles = 16_562, Name = "Lucy"},
                    new BusinessClassPassenger {Name = "Janice"},
                    new CouchClassPassenger {CarryOnKG = 25.7, Name = "Dave"},
                    new CouchClassPassenger {CarryOnKG = 0, Name = "Amit"}
                };
            foreach (Passenger passenger in passengers)
            {
                decimal flightCost = passenger switch
                {
                    /* C# 8 syntax
                    FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
                    FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
                    FirstClassPassenger _                          => 2_000M,
                    */
                    // C# 9 Later syntax
                    FirstClassPassenger p => p.AirMiles switch
                    {
                        > 35_000 => 1_500M,
                        > 15_000 => 1_750M,
                        _ => 2_000M
                    },
                    BusinessClassPassenger _ => 1_000M,
                    CouchClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                    CouchClassPassenger _ => 650M,
                    _ => 800M
                };
                WriteLine($"Flight costs {flightCost:C} for {passenger}\n\n");

                ImmutablePerson jeff = new() {FirstName = "Jeff", LastName = "Winger" };
                //jeff.FirstName = "Geoff"; => it gives an error

                ImmutableVehicle car = new() 
                {
                    Brand = "Mazda MX-5 RF", 
                    Color = "Soul Red Crystal Metallic",
                    Wheels = 4
                };

                ImmutableVehicle repairedCar = car with { Color = "Polymetal Grey Metallic" };

                WriteLine($"Original car color was {car.Color}.");
                WriteLine($"New car color is {repairedCar.Color}.");
            }
        } 
    }
}
