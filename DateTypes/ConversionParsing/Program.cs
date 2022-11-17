using System;

namespace ConversionParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string miString = "15";
            string miStringDos = "10";

            int num1 = Int32.Parse(miString);
            int num2 = Int32.Parse(miStringDos);
            Console.WriteLine(num1 + num2);

            Console.Read();
        }
    }
}