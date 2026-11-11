
using System.Xml;

ConfigureConsole(culture: "fr-FR");
decimal taxPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"You must pay {taxPay:C} in tax.");


Write("Enter a number: ");
int number = int.Parse(ReadLine()!);
try
{
    WriteLine($"{number}! = {factorial(number)}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType().ToString()} says: {ex.Message}");
}