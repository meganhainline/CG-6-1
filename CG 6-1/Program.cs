using System;
using System.Text;

namespace CG_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();

            StringBuilder myString = new StringBuilder(firstName + " " + lastName);
            Console.WriteLine(myString);
            Console.ReadLine();


        }
    }
}
