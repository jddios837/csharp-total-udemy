using System;
using System.Threading;

namespace Day13_lambda_expressions
{
    public class ArchivoEventArgs : EventArgs
    {
        public Archivo Archivo { get; set; }
    }

    public class AsistenteDescarga
    {
        // Paso 1
        // Crear delegado
        //public delegate void GestorEventArchivoDescargado(object fuente, EventArgs args);
        
        // Paso 2
        // Crear el evento basado en el delegado
        //public GestorEventArchivoDescargado ArchivoDescargado;
        // C# tiene un EventHandler
        public event EventHandler<ArchivoEventArgs> ArchivoDescargado; 

        // Paso 3
        // Iniciar el evento
        //protected virtual void EnArchivoDescargado(object archivo)
        protected virtual void EnArchivoDescargado(Archivo archivo)
        {
            if (ArchivoDescargado != null)
            {
                //ArchivoDescargado(this, EventArgs.Empty);
                ArchivoDescargado(this, new ArchivoEventArgs() { Archivo = archivo});
            }
        }

        public void Descargado(Archivo archivo)
        {
            Console.WriteLine("Descargando archivo... ");
            Thread.Sleep(3000);
            
            // Paso 3.1
            EnArchivoDescargado(archivo);
        }
    }
}