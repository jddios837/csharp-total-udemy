using System;

namespace Day13_lambda_expressions
{
    public class ServicioDesempacar
    {
        public void EnArchivoDescagardo(object obj, ArchivoEventArgs args)
        {
            Console.WriteLine("Desempacar: El archivo " + args.Archivo.Titulo + " fue desempacado");
        }
    }
}