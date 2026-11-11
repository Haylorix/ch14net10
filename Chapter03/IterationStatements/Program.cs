using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace IterationStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            /*
            string? actualPassword = "Haylorix";
            string? password;
            do
            {
                Write("Enter your password: ");
                password = ReadLine();
            }
            while (password != actualPassword);
            */


        }
    }
}
