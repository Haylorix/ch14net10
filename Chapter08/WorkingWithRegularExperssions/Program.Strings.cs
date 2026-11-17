using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices; // To use [StringSyntax].

partial class Program
{
    [StringSyntax(StringSyntaxAttribute.Regex)]
    private const string DigitsOnlyText = @"^\d+$";
    [StringSyntax(StringSyntaxAttribute.Regex)]
    private const string CommaSeparatorText = "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)";
    [StringSyntax(StringSyntaxAttribute.DateTimeFormat)]
    private const string FullDateTime = "dddd, d M yyyy";
}