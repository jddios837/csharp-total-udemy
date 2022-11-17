using System;
using Day10_New.Interfaces;

namespace Day10_New.Classes
{
    public class Enumerable : IEnumerable
    {
        public void SoyUnEnumerable()
        {
            Console.WriteLine("Clase Enumerable con interfaz IEnumerable");
        }
    }
}