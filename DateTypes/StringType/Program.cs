using System;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Juan";
            string mensaje = $"Hola {name} ¿Como estas?";

            Console.WriteLine(mensaje.ToUpper());
            Console.Read();
        }
    }
}