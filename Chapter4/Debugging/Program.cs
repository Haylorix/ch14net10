using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 4.5;
            double b = 2.5;
            double answer = Add(a , b);

            WriteLine($"{a} + {b} = {answer}");
            
            WriteLine("Press Enter to end app.");
            ReadLine();
        }
        static double Add(double a , double b)
        {
            return a + b;
        }
    }
}
