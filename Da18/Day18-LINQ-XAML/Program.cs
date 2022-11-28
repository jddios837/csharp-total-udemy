using System;
using System.Linq;
using System.Xml.Linq;

namespace Day18_LINQ_XAML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string xmlData = @"<users>
                    <user name='John Doe' age='42' />
                    <user name='Jane' age='39' />
                    <user name='Tito' age='58' />
                    <user name='Pedro' age='35' />
                    <user name='Juan' age='40' />
                </users>";

            XDocument userXdoc = new XDocument();
            userXdoc = XDocument.Parse(xmlData);

            var estudiantes = from e in userXdoc.Descendants("user")
                    select new
                    {
                        Nombre = e.Attribute("name").Value,
                        Test = e.Element("name").Value,
                        Edad = e.Attribute("age").Value
                    };

            foreach (var e in estudiantes)
            {
                Console.WriteLine("Estudiante {0} tiene una edad de {1} - {2}", e.Nombre, e.Edad, e.Test);
            }
            
            var estudiantesOrderedByAge = userXdoc
                .Descendants("user")
                .OrderBy(e => e.Attribute("age").Value)
                .Select(e => new {
                    Nombre = e.Attribute("name").Value,
                    Edad = e.Attribute("age").Value});
           
            foreach (var e in estudiantesOrderedByAge)
            {
                Console.WriteLine("Order By Age.. Estudiante {0} tiene una edad de {1}", e.Nombre, e.Edad);
            }
        }
        }
}