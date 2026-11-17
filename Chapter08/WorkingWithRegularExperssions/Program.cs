using System.Text.RegularExpressions;   // To use Regex

Write("Enter your age: ");
string input = ReadLine()!;

//Regex ageChecker = new(DigitsOnlyText);
Regex ageChecker = DigitsOnly;

WriteLine(ageChecker.IsMatch(input) ? "Thank you!" : $"This is not a valid age: {input}");

// C# 1 to 10: Use escaped double-quote characters \"
// string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\";
// C# 11 or Later: Use """ to start and end a raw string Literal
string films = """
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";

WriteLine($"Films to split: {films}");

string[] filmsDump = films.Split(',');
WriteLine("Splitting with string.Split method: ");

foreach (string film in filmsDump) 
{
    WriteLine($" {film}");
}
//Regex csv = new(CommaSeparatorText);
Regex csv = CommaSeparator;
MatchCollection filmsSmart = csv.Matches(films);
WriteLine("Splitting with regular expression:");
foreach (Match film in filmsSmart)
{
    WriteLine($" {film.Groups[2].Value}");
}