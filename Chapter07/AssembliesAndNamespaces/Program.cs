using System.Xml.Linq; // To use XDocument
using System; // To use String
using Packt.Shared;


XDocument doc = new();

string s1 = "Hello";
String s2 = "World";

WriteLine($"{s1} {s2}");

WriteLine($"Enviornment.Is64BitProcess = {Environment.Is64BitOperatingSystem}");
WriteLine($"int.MaxValue  = {int.MaxValue:N0}");
WriteLine($"nint.MaxValue = {nint.MaxValue:N0}");

Write("Enter a color value in Hex: ");
string? hex = ReadLine();
WriteLine("Is {0} a valid color value? {1}", arg0: hex, hex.IsValidHex());


Write("Enter a XML element: ");
string? xmlTag = ReadLine();
WriteLine("Is {0} a valid XML element? {1}", arg0: xmlTag, arg1: xmlTag.IsValidXmlTag());

Write("Enter a Password: ");
string? password = ReadLine();
WriteLine("Is {0} a valid password? {1}", arg0: password, arg1: password.IsValidPassword());