using System;

namespace ConsolePrj1
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("You are {0} {1}", name, surname);
            Console.WriteLine("It`s project ConsolPrj1");
            Console.ReadLine();
        }
    }
}
