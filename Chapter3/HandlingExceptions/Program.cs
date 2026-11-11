namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing.");
            Write("What is your age: ");
            string? input = ReadLine();
            try
            {
                int age = int.Parse(input!);
                WriteLine($"Your are {age} years old.");
            }
            catch (OverflowException) 
            {
                WriteLine("The age is to big.");
            }
            catch(FormatException) 
            {
                WriteLine("The age you entered is not a valid number format.");
            }
            catch( Exception ex ) 
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After parsing");
            try
            {
                checked
                {
                    int x = int.MaxValue - 2;
                    WriteLine($"Initial value: {x}");
                    x++;
                    WriteLine($"After increament: {x}");
                    x++;
                    WriteLine($"After increament: {x}");
                    x++;
                    WriteLine($"After increament: {x}");
                }
            }
            catch(OverflowException) 
            {
                WriteLine("The code overflowed but I caught the exception.");
            }
            
        }
    }
}
