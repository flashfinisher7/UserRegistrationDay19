﻿using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\t User Registration Problem");
            Registratoion user = new Registratoion();
            Console.Write("Enter your First name:");
            string firstName = Console.ReadLine();
            user.Check(firstName);
            Console.Write("Enter your Last name:");
            string lastName = Console.ReadLine();
            user.Check(lastName);
            Console.Write("Enter your Email:");
            string email = Console.ReadLine();
            user.CheckMail(email);

        }
    }
}
