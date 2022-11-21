using System;
using Day13_lambda_expressions;

namespace Day13_Events_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var archivo = new Archivo() { Titulo = "Archivo 1" };
            var asistenteDescarga = new AsistenteDescarga(); // emisor
            var servicioDesempacar = new ServicioDesempacar(); // receptor
            var servicioNotificacion = new ServicioNotificacion(); // receptor

            asistenteDescarga.ArchivoDescargado += servicioDesempacar.EnArchivoDescagardo;
            asistenteDescarga.ArchivoDescargado += servicioNotificacion.EnArchivoDescagardo;
            asistenteDescarga.Descargado(archivo);
        }
    }
}