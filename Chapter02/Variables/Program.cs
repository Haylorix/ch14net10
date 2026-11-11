using System.Dynamic;
using System.Xml;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "Amir";
            Console.WriteLine($"{name} is {height} meters tall.");
            int lenght1 = ((string)name).Length;
            Console.WriteLine($"{name} has {lenght1} charecters.\n\n");

            string numberA = "6584";
            int a = int.Parse( numberA ) + 5465;
            Console.WriteLine($"{a}\n\n");

            dynamic something;

            something = new[] { 3, 5, 7 };

            //something = 12;

            //something = "Ahmed";

            Console.WriteLine($"the Length of {something.Length}");

            Console.WriteLine($"something is a {something.GetType()}\n\n");

            dynamic person = new ExpandoObject();

            person.FirstName = "John";
            person.LastName = "Doe";
            person.Age = 30;

            Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");
            var dictionary =(IDictionary<string, object>) person;
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} = {item.Value} , {item.GetType()}");
            }

            Console.WriteLine("\n\n");

            var population = 67_000_000;
            var weight = 1.88;
            var price = 4.99M;
            var fruit = "Apple";
            var letter = 'Z';
            var happy = true;

            var xml1 = new XmlDocument();
            XmlDocument xml2 = new XmlDocument();
            Console.WriteLine(xml1.GetType());

            var file1 = File.CreateText("something1");
            StreamWriter file2 = File.CreateText("something2");
            Console.WriteLine(xml2.GetType());
        }
    }
}
