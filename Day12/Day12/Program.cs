using System;

namespace Day12
{
    enum Dia
    {
        Lu,
        Ma,
        Mi,
        Ju,
        Vi,
        Sa,
        Do
    };

    enum Option
    {
        One = 1,
        Two = 2
    }
    
    class Program
    {
        struct Juego
        {
            public string nombre;
            public string desarrollador;

            public void Mostrar()
            {
                Console.WriteLine("El nombre del juego es {0}", nombre);
                Console.WriteLine("El desarrollador es {0}", desarrollador);
            }

            public Juego(string nombre, string desarrollador)
            {
                this.nombre = nombre;
                this.desarrollador = desarrollador;
            }
        }
        
        static void Main(string[] args)
        {
            Dia viernes = Dia.Vi;
            Dia domingo = Dia.Do;
            Dia a = Dia.Vi;

            Console.WriteLine(viernes == a);
            Console.WriteLine(Dia.Lu);
            Console.WriteLine((int)Dia.Lu);
            
            Juego juego1;
            
            

            juego1.nombre = "CasaZombie";
            juego1.desarrollador = "Nintendo";
            
            juego1.Mostrar();
        }
    }
}