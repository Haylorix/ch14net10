using Packt.Shared;
using Dumpify;

Person harry = new() 
{
    Name = "Harry",
    Born = new(year : 2001, month : 3, day : 25, hour : 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};

harry.WriteToConsole();

Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };

lamech.Marry(adah);
//Person.Marry(lamech, zillah);
if(lamech + zillah)
{
    WriteLine($"{lamech.Name} and {zillah.Name} successfully got married.");
}

lamech.OutputSpouses();
adah.OutputSpouses();
zillah.OutputSpouses();

Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.Born}.");

Person baby2 = Person.Procreate(lamech, zillah);
baby2.Name = "Tubalcain";

Person baby3 = lamech * adah;
baby3.Name = "Jubal";
Person baby4 = lamech * zillah;
baby4.Name = "Naamh";

adah.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();

for (int i = 0; i < lamech.Children.Count; i++)
{
    WriteLine($"{lamech.Name}'s child #{i + 1} is named \"{lamech.Children[i].Name}\"");
}

lamech.Dump();

System.Collections.Hashtable lookupObject = new();

lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Bete");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 1;
WriteLine($"Key {key} has value: {lookupObject[key]}");
WriteLine($"Key {harry} has value: {lookupObject[harry]}");


Dictionary<int, string> lookupIntString = new();

lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Bete");
lookupIntString.Add(key: 3, value: "Gamma");
//lookupIntString.Add(key: harry, value: "Delta");

key = 3;
WriteLine($"\n\nKey {key} has value: {lookupIntString[key]}\n\n");


harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout_2;

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

WriteLine("\n\n");

Person?[] people =
    {
    null,
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = null },
    new() { Name = "Richard" }
    };

OutputPeopleNames(people, "Initial list of people:");

//Array.Sort(people); 
Array.Sort(people, new PersonComparer());

OutputPeopleNames(people, "After sorting using Person's IComparable implementation:");

DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(1, 2);
DisplacementVector dv3 = dv1 + dv2;

WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

DisplacementVector dv4 = new();
WriteLine($"({dv4.X}, {dv4.Y})");


DisplacementVector dv5 = new(3, 5);
WriteLine($"dv1.Equals(dv5): {dv1.Equals(dv5)})");
WriteLine($"dv1 == dv5: {dv1 == dv5})");

RecordDisplacementVector rdv1 = new(3, 5);
RecordDisplacementVector rdv2 = new(1, 2);
RecordDisplacementVector rdv3 = rdv1 + rdv2;

WriteLine($"({rdv1.X}, {rdv1.Y}) + ({rdv2.X}, {rdv2.Y}) = ({rdv3.X}, {rdv3.Y})");


RecordDisplacementVector rdv4 = new();
WriteLine($"({rdv4.X}, {rdv4.Y})");

RecordDisplacementVector rdv5 = new(3, 5);
WriteLine($"rdv1.Equals(rdv5): {rdv1.Equals(rdv5)})");
WriteLine($"rdv1 == rdv5: {rdv1 == rdv5})\n\n");


Employee john = new()
{
    Name = "John Jones",
    Born = new(year: 1990, month: 7, day: 28, hour: 0, minute: 0, second: 0, TimeSpan.Zero)
};
john.WriteToConsole();

john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 11, day: 23);
WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy} and has employee code {john.EmployeeCode}.");
john.WriteToConsole();

WriteLine(john.ToString());

Employee aliceInEmployee = new()
{
    Name = "Alice Smith",
    EmployeeCode = "AA123"
};

Person aliceInPerson = aliceInEmployee;
aliceInPerson.WriteToConsole();
aliceInEmployee.WriteToConsole();
WriteLine(aliceInEmployee.ToString());
WriteLine(aliceInPerson.ToString());


C1 c1 = new() { Name = "Bob" };
c1.Name = "Bill";

C2 c2 = new(Name: "Bob");
//c2.Name = "Bill"; // CS8852: Init-only property.

S1 s1 = new() { Name = "Bob" };
s1.Name = "Bill";

S2 s2 = new(Name: "Bob");
s2.Name = "Bill";

S3 s3 = new(Name: "Bob");
//s3.Name = "Bill"; // CS8852: Init-only property.

if (aliceInPerson is Employee explicitAlice) 
{
    WriteLine($"{aliceInPerson.Name} is an Employee\n\n");
}

Employee? aliceAsEmployee = aliceInPerson as Employee;
if (aliceAsEmployee is not null)
{
    WriteLine($"{nameof(aliceAsEmployee)} as an Employee\n\n");
}

try
{
    john.TimeTravel(when: new(1999, 12, 31));
    john.TimeTravel(when: new(1950, 12, 25));
}
catch(PersonException ex)
{
    WriteLine(ex.Message);
}

string email1 = "pamela@test.com";
string email2 = "ian&test.com";

WriteLine($"Is {email1} a valid email? {StringExtensions.IsValidEmail(email1)}");
WriteLine($"Is {email2} a valid email? {StringExtensions.IsValidEmail(email2)}");
WriteLine($"Is {email1} a valid email? {email1.IsValidEmail()}");
WriteLine($"Is {email2} a valid email? {email2.IsValidEmail()}");