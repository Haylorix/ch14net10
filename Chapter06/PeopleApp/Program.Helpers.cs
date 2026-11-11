using System;
using System.Collections.Generic;
using System.Text;
using Packt.Shared;

partial class Program
{
    private static void OutputPeopleNames(IEnumerable<Person> people, string title)
    {
        WriteLine(title);

        foreach (Person p in people)
        {
            WriteLine("  {0}", p is null ? "<null> Person" : p.Name ?? "<null> Name");
            //if p is null, then output "<null> Person", else if p.Name is null, output "<null> Name", else output p.Name
        }
    }
}