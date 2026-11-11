using System.Reflection;

namespace Vovabulary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            WriteLine($"Computer named {Env.MachineName} says \"No\"");

            WriteLine("Tempeture on {0:D} is {1}C.", DateTime.Today, 23.4);

            System.Data.DataSet ds = new();
            HttpClient client = new();

            Assembly? myApp = Assembly.GetEntryAssembly();

            if (myApp is null) 
            {
                return;
            }
            foreach (AssemblyName name in myApp.GetReferencedAssemblies()) 
            {
                Assembly a = Assembly.Load(name);

                int methodCount = 0;

                foreach (TypeInfo t in a.DefinedTypes) 
                {
                    methodCount += t.GetMethods().Length;
                }

                WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", arg0: a.DefinedTypes.Count(), arg1: methodCount, arg2: name.Name);
            }
        }
    }
}
