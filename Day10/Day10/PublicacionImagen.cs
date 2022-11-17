using System;

namespace Day10
{
    public class PublicacionImagen : Publicacion
    {
        public string UrlImagen { get; set; }

        public PublicacionImagen()
        {
            
        }

        public PublicacionImagen(string titulo, string autor, string urlImagen, bool esPublico)
        {
            this.IDPre = CrearIDPre();

            this.Titulo = titulo;
            this.Autor = autor;
            this.EsPublico = esPublico;
            
            this.UrlImagen = urlImagen;
        }
        
        public override string ToString()
        {
            return String.Format("Pre Value {0} and Pos Value {1} Url {2}", this.IDPre, this.IDPos, this.UrlImagen);
        }
    }
}