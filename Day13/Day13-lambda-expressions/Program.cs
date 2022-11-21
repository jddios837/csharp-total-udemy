using System;
using System.Collections.Generic;

namespace Day13_lambda_expressions
{
    class Program
    {

        public delegate int Calculos(int i);

        public delegate bool Comparacion(int l, Numero n);
        
        static void Main(string[] args)
        {
            HacerAlgo();
        }

        public static void HacerAlgo()
        {
            // se a asignado un metodo a la variable mate
            Calculos mate = new Calculos(Cuadrado);
            Console.WriteLine(mate(8));

            List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            // uso una expresion lambda tal como se implementa en JS LOL
            //List<int> numerosPares = lista.FindAll(delegate(int i) { return (i % 2 == 0); });
            List<int> numerosPares = lista.FindAll(i => (i % 2 == 0));
            // foreach (var par in numerosPares)
            // {
            //     Console.WriteLine(par);
            // }
            numerosPares.ForEach(i => Console.WriteLine(i));

            List<int> numeroImpares = lista.FindAll(delegate(int i) { return (i % 2 == 1); });
            foreach (var impare in numeroImpares)
            {
                Console.WriteLine(impare);
            }

            // Hago uso de una expresion Lambda y creo una nueva funcion X^3
            mate = new Calculos(x => x * x * x);
            Console.WriteLine(mate(8));
            
            // Al delegado Comparacion estoy agregandole un metodo que es la expresion
            // lambda y que luego llamo a ese delegado
            Comparacion comp = (a, Numero) => a == Numero.n;
            Console.WriteLine(comp(5, new Numero { n = 5}));
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static int Cuadrado(int i)
        {
            return i * i;
        }

        public static int PorDiez(int i)
        {
            return i * 10;
        }
        
    }

    public class Numero
    {
        public int n { get; set; }
    }
}