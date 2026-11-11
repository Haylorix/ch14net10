namespace Excercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Byte number1;
            Byte number2;
            Write("Enter a number between 0 and 255: ");
            try
            {
                number1 = Byte.Parse(ReadLine()!);
                Write("Enter another number between 0 and 255: ");
                number2 = Byte.Parse(ReadLine()!);
                Byte number3 =  (Byte)(number1 / number2);
                Write($"{number1} divide by {number2} is {number3}");

            }
            catch (Exception ex) 
            {
                WriteLine($"{ex.GetType().ToString()} says: {ex.Message}");
                Start();
            }
        }
        static void Start() 
        {
            Write("owww");
        }
    }
}
