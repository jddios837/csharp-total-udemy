using System;
using Day13_lambda_expressions;

namespace Day13_Events_Delegates
{
    public class ServicioNotificacion
    {
        public void EnArchivoDescagardo(object obj, ArchivoEventArgs args)
        {
            Console.WriteLine("Notificacion: El archivo " + args.Archivo.Titulo + " fue desempacado");
        }
    }
}