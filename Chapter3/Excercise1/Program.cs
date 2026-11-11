namespace Excercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if ( i % 3 == 0)
                {
                    Write("Fizz ,");
                }
                else if (i % 5 == 0)
                {
                    Write("Buzz ,");
                }
                else
                {
                    Write($"{i} ,");
                }
            }
        }
    }
}
