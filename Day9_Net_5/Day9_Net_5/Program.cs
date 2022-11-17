using System;
using System.Linq;
using System.Collections.Generic;

namespace Day9_Net_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ToCamelCase("the-stealth-warrior"));
            Console.WriteLine(ToCamelCase("The_Stealth_Warrior"));
            Console.WriteLine(ToCamelCase("_Text____hola____mundo_"));
        }

        static public string ToCamelCase(string str)
        {
            if (str.Length == 0) return "";

            var list = str
                .Replace("-", " ")
                .Replace("_", " ")
                .Trim()
                .Split(" ")
                .Where(e => e != "")
                .Select((s, i) =>
                {
                    string newString = "";
                    if (i == 0 && Char.IsLower(s.First()))
                    {
                        newString += (s.First() + s.Substring(1));
                    }
                    else
                    {
                        newString += (Char.ToUpper(s.First()) + s.Substring(1));
                    }

                    return newString;
                })
                .ToArray();

            return String.Join("", list);
        }
        
        // OTHER OPTIONS
        // using System;
        // using System.Text.RegularExpressions;
        //
        // public class Kata
        // {
        //     public static string ToCamelCase(string str)
        //     {
        //         return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
        //     }
        // }
        
        
        // using System;
        // using System.Linq;
        //
        // public class Kata
        // {
        //     public static string ToCamelCase(string str)
        //     {
        //         return string.Concat(str.Split('-','_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));
        //     }
        // }

    }
}