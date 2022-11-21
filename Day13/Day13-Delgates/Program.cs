using System;

namespace Day13_Delgates
{
    class Program
    {
        public delegate double HacerCalculo(double x, double y);

        public static double Suma(double a, double b)
        {
            Console.WriteLine("a+b es: {0}", (a+b));
            return a + b;
        }
        
        public static double Division(double a, double b)
        {
            Console.WriteLine("a/b es: {0}", (a/b));
            return a / b;
        }

        public static double Resta(double a, double b)
        {
            Console.WriteLine("a-b es: {0}", (a-b));
            return a - b;
        }
        
        static void Main(string[] args)
        {
            HacerCalculo miSuma = Suma;
            //miSuma(5.3, 3.3);

            HacerCalculo miDivision = Division;
            //miDivision(5.0, 5.0);

            HacerCalculo calculoMultiple = miSuma + miDivision;
            calculoMultiple += Resta;
            calculoMultiple(3.2, 3.2);
        }
    }
}