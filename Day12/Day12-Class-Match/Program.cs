using System;

namespace Day12_Class_Match
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Redondedo hacia arriba {0}", Math.Ceiling(15.3));
            Console.WriteLine("Redondedo hacia abajo {0}", Math.Round(15.3));

            // Random dado = new Random();
            // int numCara;
            //
            // for (int i = 0; i < 10; i++)
            // {
            //     numCara = dado.Next(7);
            //     Console.WriteLine("El dado saco {0}", numCara);
            // }

            Console.WriteLine("Haz una pregunta!");
            string question = Console.ReadLine();
            Console.WriteLine("La respuesta a tu pregunta: {0}", question);
            Console.WriteLine("es....");
            Random answer = new Random();
            int numRespuesta;
            numRespuesta = answer.Next();
            switch (numRespuesta)
            {
                case 1:
                    Console.WriteLine("Si");
                    break;
                case 2:
                    Console.WriteLine("No");
                    break;
                case 3:
                    Console.WriteLine("Quizas");
                    break;
            }

        }
    }
}