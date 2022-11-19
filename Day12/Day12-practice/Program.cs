using System;
using Day12_practice.Model;

namespace Day12_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Women person1 = new Women("Leny", 35, Colors.Blue, Gender.Female);
            person1.AddItemOnBag("Labial");
            person1.AddItemOnBag("Reloj");
            person1.AddItemOnBag("Gomas");
            Console.WriteLine(person1.ToString());
            Console.WriteLine("Lo que llevo en mi cartera es:");
            Console.WriteLine(person1.ShowItemsOnBag());
            Console.WriteLine("A#o en que naci {0}", person1.BoarnYear());
        }
    }
}