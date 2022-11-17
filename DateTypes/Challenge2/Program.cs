using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Write a text here and press Enter");
            text = Console.ReadLine();

            Console.WriteLine("Write the letter to find and press Enter");
            string letter = Console.ReadLine();

            Console.WriteLine($"The letter is in the index {text.IndexOf(letter[0])}");
        }
    }
}