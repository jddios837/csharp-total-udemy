using System;
using System.Threading.Channels;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de Valores");
            Console.WriteLine("Ingrese el valor 1");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor 2");
            int num2 = Int32.Parse(Console.ReadLine());;
            Console.WriteLine($"La suma de {num1} y {num2} es {Sum(num1,num2)}");
            //int suma = Sum(34, 22);
            //Console.WriteLine(suma);

            // SaludarAmigo("Manuel");
            // SaludarAmigo("Pedro");
            // Console.Read();
        }

        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        private static void SaludarAmigo(string name)
        {
            Console.WriteLine($"Hola {name} que tenga un buen dia!");
        }
    }

    sealed class Hola
    {
        public string saludo { get; set; }
    }
}