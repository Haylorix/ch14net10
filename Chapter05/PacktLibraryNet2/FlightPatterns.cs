using System;
using System.Collections.Generic;
using System.Text;

namespace  Packt.Shared;
    
public class Passenger
{
     public string? Name { get; set; }
}

public class BusinessClassPassenger : Passenger
{
     public override string ToString()
    {
        return $"Business Class: {Name}";
    }
}

public class FirstClassPassenger : Passenger
{
    public int AirMiles { get; set; }
    public override string ToString()
    {
        return $"First Class with {AirMiles:N0} air miles: {Name}";
    }
}

public class CouchClassPassenger : Passenger
{
    public double CarryOnKG { get; set; }
    public override string ToString()
    {
        return $"Coach Class with {CarryOnKG:N2} KG carry on: {Name}";
    }
}





