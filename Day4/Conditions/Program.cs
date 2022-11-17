using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            int num;
            Console.WriteLine("Ingrese una temperatura");
            value = Console.ReadLine();

            if (!int.TryParse(value, out num))
            {
                Console.WriteLine("Esa no es una temperatura valida");
            }
            else
            {
                Validation(num);
            }

            Console.ReadLine();
        }

        public static void Validation(int val)
        {
            string text;
            text = val <= 15 ? "Hace mucho frio" :
                (val >= 16 && val <= 28) ? "Hace un clima agradable" : "Hace mucho calor";
            Console.WriteLine(text);
        }
    }
}