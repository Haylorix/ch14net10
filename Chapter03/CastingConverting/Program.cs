using System.Buffers.Text;
using System.Net.Http.Headers;
using System.Xml;
using static System.Convert;
using System.Globalization;
namespace CastingConverting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a;
            WriteLine($"a is {a}, b is {b}");

            double c = 9.8;
            int d = (int)c;
            WriteLine($"c is {c}, d is {d}");

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e}, f is {f}");
            e = 5_000_000_000;
            f = (int)e;
            WriteLine($"e is {e:N0}, f is {f:N0}");

            WriteLine("{0,12} {1,34}", "Decimal", "Binary");
            WriteLine("{0,12} {0,34:B32}", int.MaxValue);
            for (int i = 8; i >= -8; i--)
            {
                WriteLine("{0,12} {0,34:B32}", i);            
            }
            WriteLine("{0,12} {0,34:B32}", int.MinValue);

            long r = 0b_10100010101000110010011101010100101010;
            int s = (int)r;
            WriteLine($"{r, 38:B32} = {r}");
            WriteLine($"{s, 38:B32} = {s}");

            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g},  h is {h}");

            double[,] doubles = 
                {
                {9.49, 9.5, 9.51 },
                {10.49, 10.5, 10.51 },
                {11.49, 11.5, 11.51 },
                {12.49, 12.5, 12.51 },
                {-12.49, -12.5, -12.51 },
                {-11.49, -11.5, -11.51 },
                {-10.49, -10.5, -10.51 },
                {-9.49, -9.5, -9.51 }
                };
            WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    Write($"| {doubles[i,j], 6} | {ToInt32(doubles[i,j]), 7} ");
                }
                WriteLine("|");
            }
            WriteLine();

            foreach (double n in doubles)
            {
                WriteLine(format: "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}", arg0: n, arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero));
            }

            int number = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new();
            WriteLine(me.ToString());

            WriteLine("\n");
            byte[] binaryObject = new byte[128];
            Random.Shared.NextBytes(binaryObject);
            WriteLine("Binary object as bytes: ");
            for (int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X2} ");
            }
            WriteLine();
            string encoded = Base64Url.EncodeToString(binaryObject);
            WriteLine($"Binary Object as Base64: {encoded}\n\n");

            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            int frieds = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 June 1980");
            WriteLine($"I have {frieds} friends to invite to my oarty.");
            WriteLine($"My birthday is {birthday}.");
            WriteLine($"My birthday is {birthday:D}.");
        }
    }
}
