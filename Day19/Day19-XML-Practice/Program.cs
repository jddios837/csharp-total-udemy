// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

string texto = System.IO.File.ReadAllText("./catalog.xml");
// Console.WriteLine(texto);
XDocument catalogDog = new XDocument();
catalogDog = XDocument.Parse(texto);

var list = from e in catalogDog.Descendants("PLANT")
        select new
        {
            Name = e.Element("COMMON").Value,
            Price = e.Element("PRICE").Value
        };

foreach (var e in list)
{
    Console.WriteLine("Lectura XML Nombre {0} y Precio {1}", e.Name, e.Price);
}

//--------------------- More Practice
// reading a XML file and after get only elements where price is 
// bigger than 5 
string textMenu = System.IO.File.ReadAllText("./menu.xml");
XDocument docMenuXml = new XDocument();
docMenuXml = XDocument.Parse(textMenu);

var listMenu = from e in docMenuXml.Descendants("food")
    select new
        {
            Name = e.Element("name").Value,
            Price = float.Parse(e.Element("price").Value.Substring(1), CultureInfo.InvariantCulture)
        };
listMenu = listMenu.Where(e => e.Price > 5);

foreach (var e in listMenu)
{
    Console.WriteLine("XML Menu Plato {0} precio {1}", e.Name, e.Price);
} 