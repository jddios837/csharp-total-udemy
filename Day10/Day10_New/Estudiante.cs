using System;
using Day10_New.Interfaces;

namespace Day10_New
{
    public class Estudiante : IEnumerable
    {
        public void SoyUnEnumerable()
        {
            Console.WriteLine("Soy un objecto con interfaz IEnumerable");
        }
        
        
    }
}