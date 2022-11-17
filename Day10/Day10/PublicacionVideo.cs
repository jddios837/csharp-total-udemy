using System;
using System.Threading;

namespace Day10
{
    public class PublicacionVideo : Publicacion
    {
        protected string UrlVideo { get; set; }
        protected int Duracion { get; set; }

        private int duracionActual;
        private Timer reloj;
        private bool seReproduce = false;

        public PublicacionVideo()
        {
            
        }

        public PublicacionVideo(string titulo, string autor, string urlVideo, bool esPublico, int duracion)
        {
            this.IDPre = CrearIDPre();

            this.Titulo = titulo;
            this.Autor = autor;
            this.EsPublico = esPublico;
            this.Duracion = duracion;
            
            this.UrlVideo = urlVideo;
        }

        public void Play()
        {
            if (!seReproduce)
            {
                seReproduce = true;
                Console.WriteLine("Reproduciendo");
                reloj = new Timer(Reproduccion, null, 0, 1000);
            }
        }

        private void Reproduccion(object state)
        {
            if (duracionActual < Duracion)
            {
                duracionActual++;
                Console.WriteLine("Video en {0}s", duracionActual);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (seReproduce)
            {
                Console.WriteLine("Detenido en {0}s", duracionActual);
                seReproduce = false;
                duracionActual = 0;
                reloj.Dispose();
            }
        }
    }
}