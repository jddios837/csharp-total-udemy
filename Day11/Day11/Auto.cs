using System;

namespace Day11
{
    public class Auto
    {
        public int HP { get; set; }
        public string Color { get; set; }
        
        // TIENE UNA RELACION A AUTO INFO
        protected AutoInfo autoInfo = new AutoInfo();

        public Auto() { }

        public Auto(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine("Detalles del Carro, HP: {0} y Color: {1}", HP, Color);
        }

        public virtual void Reparar()
        {
            Console.WriteLine("Auto Reparado");
        }

        public void SetearAutoInfo(int id, string propietario)
        {
            autoInfo.ID = id;
            autoInfo.Propietario = propietario;
        }
        
        public void LeerAutoInfo()
        {
            Console.WriteLine("Id: {0}, Propietario: {1}", autoInfo.ID, autoInfo.Propietario);
        }
    }
}