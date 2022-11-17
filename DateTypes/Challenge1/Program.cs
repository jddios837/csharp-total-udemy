using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please write your name and press Enter");
            name = Console.ReadLine();
            
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.Substring(3));
            
            Console.Read();
        }
    }
}