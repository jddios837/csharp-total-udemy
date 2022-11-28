using System;
using System.Collections.Generic;
using System.Linq;

namespace Da18_Console_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Impares(numeros);
        }

        static void Impares(int[] numeros)
        {
            Console.WriteLine("Cantidad de Numeros impares: ");
            // IEnumerable es la interfaz con metodos basicos para tratar Arrays
            IEnumerable<int> numImpares = from numero in numeros where numero % 2 != 0 select numero;

            Console.WriteLine(numImpares.Count());

            Console.WriteLine("Los numeros impares son: ");

            foreach (var i in numImpares)
            {
                Console.WriteLine(i);                    
            }
        }
    }
}