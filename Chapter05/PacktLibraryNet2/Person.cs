using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Packt.Shared;

public class Person : Object
{
    #region Field: Date or state for Person
    public string? Name;
    public DateTimeOffset Born;

    public double Age => DateTime.Today.Year - Born.Year;

    public WondersOfTheAncientWorld FavorateAncientWonder;

    public WondersOfTheAncientWorld BucketList;

    public List<Person> Children = new();

    public Person this[int index] 
    {
        get
        {
            return Children[index];
        }
        set
        {
            Children[index] = value;
        }
    }
    public Person this[string name]
    {
        get
        {
            return Children.Find(p => p.Name == name);
        }
    }

    #endregion

    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        z = 99;
        //x++; gives error
        w++;
        y++;
        z++;

        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z} ");
    }

    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }
    
    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }
    public void Deconstruct(out string? name, out DateTimeOffset dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = Born;
        fav = FavorateAncientWonder;
    }
}
