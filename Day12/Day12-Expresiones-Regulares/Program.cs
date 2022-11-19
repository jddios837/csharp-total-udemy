using System;
using System.Text.RegularExpressions;

namespace Day12_Expresiones_Regulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresion = @"(\w+)@(\w+)(\.\w+)";
            Regex regex = new Regex(expresion);

            string textoToTest = "jddios837@gmail.com leny@hotmail.com";

            MatchCollection aciertos = regex.Matches(textoToTest);

            Console.WriteLine("En la cadena \"{0}\" se encontraron un total de {1} aciertos", textoToTest,aciertos.Count);
            foreach (Match match in aciertos)
            {
                GroupCollection grupo = match.Groups;
                Console.WriteLine(grupo[0].Value, grupo[0].Index);
            }
        }
    }
}