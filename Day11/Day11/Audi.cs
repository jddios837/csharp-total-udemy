using System;

namespace Day11
{
    public class Audi : Auto
    {
        private string marca = "Audi";
        public string Modelo { get; set; }
        
        public Audi() {}

        public Audi(string modelo, string color, int hp) : base(hp, color)
        {
            this.Modelo = modelo;
        }
        
        public void MostrarDetalles()
        {
            Console.WriteLine("Marca: {0}, Modelo: {1}, HP: {2} y Color: {3}, ", marca, Modelo, HP, Color);
        }

        public override void Reparar()
        {
            Console.WriteLine("El Audi {0} esta Reparado", Modelo);
        }
    }
}