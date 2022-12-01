using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Day20_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // new Thread(() =>
            // {
            //     Thread.Sleep(2000);
            //     Console.WriteLine("Subprocess 1");
            // }).Start();
            //
            // new Thread(() =>
            // {
            //     Thread.Sleep(2000);
            //     Console.WriteLine("Subprocess 2");
            // }).Start();

            // var taskCompleted = new TaskCompletionSource<bool>();
            //
            // var hilo = new Thread(() =>
            // {
            //     Console.WriteLine($"Numero de subproceso: {Thread.CurrentThread.ManagedThreadId} ha iniciado");
            //     Thread.Sleep(5000);
            //     taskCompleted.TrySetResult(true);
            //     Console.WriteLine($"Numero de subproceso: {Thread.CurrentThread.ManagedThreadId} ha iniciado");
            // });
            // hilo.Start();
            // var prueba = taskCompleted.Task.Result;
            // Console.WriteLine("Tarea terminada: {0}", prueba);
            //
            // Console.ReadLine();
            
            Enumerable.Range(0,100).ToList().ForEach(e =>
            {
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Console.WriteLine($"Numero de subproceso: {Thread.CurrentThread.ManagedThreadId} ha iniciado");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Numero de subproceso: {Thread.CurrentThread.ManagedThreadId} ha terminado");
                });
                
                // no seria la mejor manera de hacerlo
                // new Thread(() =>
                // {
                //     Console.WriteLine($"Numero de subproceso: {Thread.CurrentThread.ManagedThreadId} ha iniciado");
                //     Thread.Sleep(1000);
                //     Console.WriteLine($"Numero de subproceso: {Thread.CurrentThread.ManagedThreadId} ha terminado");
                // }).Start();
            });

            Console.ReadLine();
        }
    }
}