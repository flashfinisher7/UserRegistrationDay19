using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\t User Registration Problem");
            Registration user = new Registration();
            Console.Write("Enter your first name : ");
            string firstName = Console.ReadLine();
            user.Check(firstName);
        }
    }
}
