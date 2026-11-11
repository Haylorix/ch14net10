namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exploring unary operators


            int a = 3;
            int b = a++;
            WriteLine($"a is {a}, b is {b}");

            int c = 3;
            int d = ++c;
            WriteLine($"c is {c}, d is {d}");

            int e = 16;
            int f = 5;
            WriteLine($"e is {e}, and f is {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");

            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g / f = {g / f}");

            bool p = true;
            bool q = false;
            WriteLine($"AND  | p     | q ");
            WriteLine($"p    | {p & p,-5} | {p & q,-5}");
            WriteLine($"q    | {q & p,-5} | {q & q,-5}\n");
            WriteLine($"Or   | p     | q ");
            WriteLine($"p    | {p | p,-5} | {p | q,-5}");
            WriteLine($"q    | {q | p,-5} | {q | q,-5}\n");
            WriteLine($"XOR  | p     | q ");
            WriteLine($"p    | {p ^ p,-5} | {p ^ q,-5}");
            WriteLine($"q    | {q ^ p,-5} | {q ^ q,-5}\n");

            WriteLine($"p & DoStuff() = {p & DoStuff()}");
            WriteLine($"q & DoStuff() = {q & DoStuff()}\n");
            WriteLine($"p && DoStuff() = {p && DoStuff()}");
            WriteLine($"q && DoStuff() = {q && DoStuff()}\n");

            int x = 10;
            int y = 6;
            WriteLine($"Expression | Decimal |   Binary");
            WriteLine($"-------------------------------");
            WriteLine($"x          | {x,7} | {x:B8}");
            WriteLine($"y          | {y,7} | {y:B8}");
            WriteLine($"x & y      | {x & y,7} | {x & y:B8}");
            WriteLine($"x | y      | {x | y,7} | {x | y:B8}");
            WriteLine($"x ^ y      | {x ^ y,7} | {x ^ y:B8}");
            WriteLine($"x << 3     | {x << 3,7} | {x << 3:B8}");
            WriteLine($"x * 8      | {x * 8,7} | {x * 8:B8}");
            WriteLine($"y >> 1     | {y >> 1,7} | {x >> 1:B8}");

            #endregion
        }
        static bool DoStuff() 
        {
            WriteLine("I am doing some stuff.");
            return true;
        }
    }
}
