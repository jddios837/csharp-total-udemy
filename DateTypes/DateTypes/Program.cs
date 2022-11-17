using System;

namespace DateTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 34;
            int num2 = 5;
            int sum = num1 + num2;
            int num3, num4, num5;

            double d1 = 3.2;
            double d2 = 1.337;
            double sumd = d1 + d2;

            float f1 = 3.3f;
            
            Console.WriteLine($"When you add {num1} and {num2} the result is {sum}");
            Console.Read();
        }
    }
}