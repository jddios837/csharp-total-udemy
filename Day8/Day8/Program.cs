using System;
using System.Collections.Generic;
using System.Linq;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[][] persons = new string[][]
            {
                new string[] { "Nina", "Pedro", "Pablo"},
                new string[] { "Manuela", "Rodolfo"},
                new string[] { "tatiana", "yari", "andrea", "Junior"}
            };
            
            persons.Append(new string[] {"jose"});

            int[] numbers = new int[] {};

            numbers.Append(2);

            foreach (int i in numbers)
            {
                Console.WriteLine("{0}", i);
            }

            // List<int> lista = new List<int>();
            // lista.Add(2);

            // for (int i = 0; i < persons.Length; i++)
            // {
            //     for (int j = 0; j < persons[i].Length; j++)
            //     {
            //         Console.WriteLine("Hola {0}, te presento a:", persons[i][j]);
            //         foreach (string s in persons[i + 1])
            //         {
            //             Console.Write(s + ", ");
            //         }
            //
            //         Console.WriteLine("");
            //     }
            // }
        }
    }
}