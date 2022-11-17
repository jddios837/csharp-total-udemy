using System;
using System.Collections.Generic;

namespace Day11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaro una list usando la clase base pero sus elementos
            // seran de tipo subclase
            var autos = new List<Auto>()
            {
                new Audi("A4", "azul", 200),
                new BMW("M3", "rojo", 250)
            };

            foreach (var auto in autos)
            {
                auto.Reparar();
            }
            
            // Aunque sean objetos de la clase Auto al crearlos
            // se hizo en base de la Subclases pero el metodo MostrarDetalles
            // usara el metodo de la clase Base
            Auto auto1 = new BMW("Z3", "negro", 200);
            Auto auto2 = new Audi("A3", "verde", 100);
            auto1.MostrarDetalles();
            auto2.MostrarDetalles();

            // Aca usamos new para que en BMW clase el metodo MostrarDetalles
            // use el que se declaro en ella
            BMW bmwM5 = new BMW("M5", "blanco", 330);
            bmwM5.MostrarDetalles();
            bmwM5.SetearAutoInfo(1, "Jose Perez");
            bmwM5.LeerAutoInfo();

            // Casting de una subclase a una clase base
            Auto autoB = (Auto)bmwM5;
            autoB.MostrarDetalles();

            M3 miM3 = new M3("M3Super Turbo", "rojo", 260);
            miM3.Reparar();
        }
    }
}