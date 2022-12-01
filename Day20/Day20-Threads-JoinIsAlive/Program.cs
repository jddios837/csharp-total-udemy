using System;
using System.Threading;

namespace Day20_Threads_JoinIsAlive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main ha comenzado");
            Thread hilo1 = new Thread(FuncionThread1);
            Thread hilo2 = new Thread(FuncionThread2);
            hilo1.Start();
            hilo2.Start();

            if (hilo1.Join(1000))
            {
                Console.WriteLine("FuncionThread1 terminada");
            }
            else
            {
                Console.WriteLine("FuncionThread1 no termino en 1 segundo");
            }

            for (int i = 0; i < 10; i++)
            {
                if (hilo1.IsAlive)
                {
                    Console.WriteLine("FuncionThread1 sigue haciendo cosas");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("FuncionThread1 termino con lo suyo");
                    Thread.Sleep(1000);
                }
            }
            
            hilo2.Join();
            Console.WriteLine("FuncionThread2 esta listo");
            
            Console.WriteLine("Main ha finalizado");
        }

        public static void FuncionThread1()
        {
            Console.WriteLine("Inició FuncionThread1");
            Thread.Sleep(3000);
            Console.WriteLine("FuncionTheread1 regresa al main");
        }

        public static void FuncionThread2()
        {
            Console.WriteLine("Inicio FuncionThread2");
        }
    }
}