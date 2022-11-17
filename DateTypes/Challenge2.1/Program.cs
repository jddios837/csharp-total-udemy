using System;

namespace Challenge2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your first name and press enter");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Write your second name and press enter");
            string secondName = Console.ReadLine();

            string completeName = $"{firstName} {secondName}";
            Console.WriteLine(completeName);
        }
    }
}