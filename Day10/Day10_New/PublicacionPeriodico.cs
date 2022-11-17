using Day10;

namespace Day10_New
{
    public class PublicacionPeriodico : Publicacion
    {
        private static int Id;
        
        public PublicacionPeriodico()
        {
            this.IDPre = CrearIDPos();
        }
    }
}