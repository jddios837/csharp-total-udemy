using System;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte varByte = 128;
            sbyte varSbyte = 5;
            int varInt = 344;
            uint varUInt = 332;
            short varShort = 31500;
            ushort varUShort = 53000;
            long varLong = 232435645653;
            ulong varULong = 2323212312321312312;
            float varFloat = 2323.222f;
            double varDouble = 2332.333;
            char varChar = 's';
            bool varBool = true;
            string text = "hola";
            decimal varDecimal = new decimal(23.33222);

            string number = "455";
            Console.WriteLine($"Number {number} plus 1 is {Int32.Parse(number) + 1}");
        }
    }
}