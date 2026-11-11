using static System.Console;
using System.Globalization;

partial class Program
{
    static decimal CalculateTax(decimal amount, string twoLetterRegionCode) 
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M,
            "DK" or "NO" => 0.25M,
            "GB" or "FR" => 0.5M,
            "HU" => 0.27M,
            "OR" or "AK" or "MT" => 0.0M,
            "ND" or "WI" or "ME" or "VA" => 0.05M,
            "CA" => 0.0825M,
            _ => 0.06M
        };
        return rate * amount;
    }
    static void ConfigureConsole(string culture = "en-US", bool useComputerCulture = false)
    {
        OutputEncoding = System.Text.Encoding.UTF8;
        if (!useComputerCulture) 
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture.DisplayName}");
    }

    /// <summary>
    /// Pass a 32-bit unasined integer and it will be converted into its ordinal equavalent.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    static int factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(message: $"The fuctorial function is defined for non-negative numbers only. Input: {number}", paramName: nameof(number));
        }
        else if (number == 1 | number == 0)
        {
            return 1;
        }
        else 
        {
            checked 
            {
                return number * factorial(number - 1);
            }
            
        }
    }
}
