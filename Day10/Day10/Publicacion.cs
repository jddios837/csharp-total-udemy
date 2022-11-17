using System;

namespace Day10
{
    public class Publicacion
    {
        private static int publicacionPreID;
        private static int publicacionPosID;
        
        //Properties
        protected int IDPre { get; set; }
        protected int IDPos { get; set; }
        protected string Titulo { get; set; }
        protected string Autor { get; set; }
        protected bool EsPublico { get; set; }

        public Publicacion()
        {
            IDPre = CrearIDPre();
            IDPos = CrearIDPos();
            Titulo = "Mi primera publicacion";
            Autor = "Juan";
        }

        public Publicacion(string titulo, bool esPublico, string autor)
        {
            this.IDPre = CrearIDPre();
            this.IDPos = CrearIDPos();

            this.Titulo = titulo;
            this.EsPublico = esPublico;
            this.Autor = autor;
        }
        
        internal int CrearIDPre()
        {
            // retorna el valor publicacionPreID luego del incremento
            return ++publicacionPreID;
        }
        
        protected int CrearIDPos()
        {
            // retorna el valor publicacionPreID antes del incremento
            return publicacionPosID++;
        }

        public void Editar(string titulo, bool esPublico)
        {
            this.Titulo = titulo;
            this.EsPublico = esPublico;
        }

        public override string ToString()
        {
            return String.Format("Pre Value {0} and Pos Value {1}", this.IDPre, this.IDPos);
        }
    }
}