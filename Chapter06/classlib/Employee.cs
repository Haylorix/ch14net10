using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared;

public class Employee : Person
{
    #region Properties
    public string? EmployeeCode { get; set; }
    public DateOnly HireDate { get; set; }
    #endregion

    #region Methods
    public new void WriteToConsole()
    {
        Console.WriteLine(format:"{0} was born on {1:dd/MM/yyyy} and hired on {2:dd/MM/yyyy}", arg0: Name, arg1: Born, arg2: HireDate);
    }

    public override string ToString()
    {
        return $"{Name}'s code is {EmployeeCode}";
    }
    #endregion
}

