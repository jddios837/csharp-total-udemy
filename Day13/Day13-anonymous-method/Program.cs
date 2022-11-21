using System;

namespace Day13_anonymous_method
{
    class Program
    {
        public delegate string ObtenerDelegateText(string texto);
        
        static void Main(string[] args)
        {
            ObtenerDelegateText miDelegado = delegate(string texto)
            {
                return "Hola " + texto;
            };

            Console.WriteLine(miDelegado("Juan"));
            Mostrar(miDelegado);
        }

        static void Mostrar(ObtenerDelegateText myDelegate)
        {
            Console.WriteLine(myDelegate("Mundo"));
        }
    }
}