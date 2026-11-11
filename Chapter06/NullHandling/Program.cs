using Packt.Shared;


int thisCannotBeNull = 4;
//thisCannotBeNull = null; => compile-time error
WriteLine($"thisCannotBeNull: {thisCannotBeNull}");

int? thisCouldBeNull = null; // nullable int
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 7;
WriteLine($"thisCouldBeNull: {thisCouldBeNull}");
WriteLine(thisCouldBeNull.GetValueOrDefault());

Nullable<int> thisCouldAlsoBeNull = null; // nullable int
WriteLine(thisCouldAlsoBeNull);
WriteLine(thisCouldAlsoBeNull.GetValueOrDefault());

thisCouldAlsoBeNull = 7;
WriteLine($"thisCouldAlsoBeNull: {thisCouldAlsoBeNull}");
WriteLine(thisCouldAlsoBeNull.GetValueOrDefault());

Address address = new(city: "London") 
{
    Building = null,
    Street = null!,
    Region = null!
};

WriteLine(address.Building?.Length); // throws NullReferenceException)
//WriteLine(address.Street.Length); // throws NullReferenceException)
if(address.Street is not null)
{
    WriteLine(address.Street.Length);
}
else
{
    WriteLine("Street is null");
}