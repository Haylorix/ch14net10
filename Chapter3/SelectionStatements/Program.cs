using System.ComponentModel.DataAnnotations;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "ninja";

            if(password.Length < 8)
            {
                WriteLine("your password is to short. Use at least 8 chars.");
            }
            else 
            {
            WriteLine("your password is strong.                                                                                                                      ");
            }

            object o =  3;
            int j = 4;

            if (o is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply!");
            }
            WriteLine();

            var animals = new Animal?[] 
            {
                new Cat{Name = "Karen", Born = new(year: 2022, month: 8,day: 23), Legs = 4, IsDomestic = true},
                null,
                new Cat{Name = "Mufasa", Born = new(year: 1994, month: 6, day: 12)},
                new Spider{Name = "Sid Vicious", Born = DateTime.Today, IsVenomous = true},
                new Spider{Name = "Captain Furry", Born = DateTime.Today}
            };
            foreach (Animal? animal in animals)
            {
                string message;

                switch (animal)
                {
                    case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
                        message = $"The cat named  {fourLeggedCat.Name} has four Legs.";
                        break;
                    case Cat wildCat when wildCat.IsDomestic == false:
                        message = $"The non-domistic cat is named {wildCat.Name}";
                        break;
                    case Cat cat:
                        message = $"The cat is named {cat.Name}";
                        break;
                    case Spider spider when spider.IsVenomous == true:
                        message = $"The {spider.Name} spider is venomous. Run!";
                        break;
                    case null:
                        message = "the animal is null.";
                        break;
                    default:
                        message = $"{animal.Name} is a {animal.GetType().Name}.";
                        break;

                }
                WriteLine(message);
                message = animal switch
                {
                    Cat fourLeggedCat when fourLeggedCat.Legs == 4
                        => $"The cat named {fourLeggedCat.Name} has four legs.",
                    Cat wildCat when wildCat.IsDomestic == false
                        => $"The non-domestiv cat is named {wildCat.Name}",
                    Cat cat
                        => $"The cat is named {cat.Name}",
                    Spider spider when spider.IsVenomous == true
                        => $"The {spider.Name} spider is venomous, RUN!",
                    null
                        => $"The animal is null",
                    _
                        => $"{animal.Name} is a {animal.GetType().Name}."
                };
                WriteLine(message + "    OOO");
            }
        }
    }
}
