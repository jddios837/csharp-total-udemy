using System;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Publicacion post1 = new Publicacion("Titulo 1", true, "Jose");

            Console.WriteLine(post1.ToString());

            PublicacionImagen img1 = new PublicacionImagen("Mira mi nuevo carrito", "Jose", "https://img.png", true);

            Console.WriteLine(img1.ToString());

            PublicacionVideo vide1 = new PublicacionVideo("Video 1", "Jose", "https://xxxx", true, 10);
            vide1.Play();
            Console.ReadKey();
            vide1.Stop();

            Console.Read();
        }
    }
}