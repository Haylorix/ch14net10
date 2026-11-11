using System.Globalization;

namespace Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;

            Console.WriteLine(format: "{0} apples cost {1:C}", arg0: numberOfApples, arg1: pricePerApple * numberOfApples);

            string formatted = string.Format
                (
                    format: "{0} apples cost {1:C}",
                    arg0: numberOfApples,
                    arg1: pricePerApple * numberOfApples
                );

            Console.WriteLine("{0} {1} lived in {2}", arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");
            //Console.WriteLine("{0} [1} lived in {2} and worked in {3} team at {4}.", arg0: "Roger", arg1: "Cevung", arg2: "Stockholm", arg3: "Education", arg4: "Optimizely");

        }
    }
}
