using System;
using Day10_New.Interfaces;

namespace Day10_New.Classes
{
    public class Collection : ICollection
    {
        public void SoyUnEnumerable()
        {
            Console.WriteLine("Metodo: SoyUnEnumerable - Soy una clase Collection con una interfaz ICollection");
        }

        public void SoyUnaCollecion()
        {
            Console.WriteLine("Metodo: SoyUnaCollecion - Soy una clase Collection con una interzaz ICollection");
        }
    }
}