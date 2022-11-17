using System;

namespace ConsoleWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();
            Console.Write("Hello World!");
            Console.Write("Juan!");
            Console.Beep();
            
            Console.WriteLine("Nueva lines");
            //int r = Console.Read();
            string o = Console.ReadLine();
            Console.WriteLine($"Values readed: {o}");
            Console.Read();
        }
    }
}