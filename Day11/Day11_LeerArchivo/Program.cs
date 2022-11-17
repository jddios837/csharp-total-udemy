using System;
using System.IO;
using System.Threading.Channels;

namespace Day11_LeerArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metodo 1 de ESCRITURA de TEXTO
            string[] lineas = { "Primero 250", "Segundo 242" };
            File.WriteAllLines(@"./Puntajes.txt", lineas);

            // METODO 2 de ESCRITURA de TEXTO
            /*Console.WriteLine("Ingrese el nombre del archivo");
            string nombreArchivo = Console.ReadLine();
            Console.WriteLine("Ingrese el contenido del libro");
            string contenido = Console.ReadLine();
            
            File.WriteAllText(@"./" + nombreArchivo + ".txt", contenido);
            */
            
            // METODO 3
            // using (StreamWriter archivo = new StreamWriter(@"./testusing1.txt"))
            // {
            //     foreach (var l in lineas)
            //     {
            //         if (l.Contains("4"))
            //         {
            //             archivo.WriteLine(l);
            //         }
            //     }
            // }
            
            // METODO 4 agregar linea al final
            using (StreamWriter archivo = new StreamWriter(@"./testusing1.txt", true))
            {
                archivo.WriteLine("Nueva Linea");
            }

            // // Leer todo el texto del archivo
            // string texto = System.IO.File.ReadAllText(@"./LeerArchivo.txt");
            // Console.WriteLine("El archivo contiene el siguiente texto: {0}", texto);
            //
            // // Leer cada linea
            // string[] texto1 = System.IO.File.ReadAllLines(@"./LeerArchivo.txt");
            // foreach (var line in texto1)
            // {
            //     Console.WriteLine("\t" + line);
            // }
        }
    }
}