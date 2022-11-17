using System;

namespace Day11
{
    public class BMW: Auto
    {
        private string marca = "BWM";
        public string Modelo { get; set; }
        
        public BMW() {}

        public BMW(string modelo, string color, int hp) : base(hp, color)
        {
            this.Modelo = modelo;
        }
        
        public new void MostrarDetalles()
        {
            Console.WriteLine("Marca: {0}, Modelo: {1}, HP: {2} y Color: {3}, ", marca, Modelo, HP, Color);
        }

        public override void Reparar()
        {
            Console.WriteLine("El BMW {0} esta Reparado", Modelo);
        }
    }
}