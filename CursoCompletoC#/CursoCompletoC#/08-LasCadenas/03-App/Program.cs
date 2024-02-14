using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = { "Hola", "a", "todos" };

            string texto2 = string.Join("-", palabras);
            Console.WriteLine(texto2);

            string texto = string.Concat(palabras);
            Console.WriteLine(texto);

            string palabra1 = "Hola", palabra2 = "a", palabra = "todos";
            Console.WriteLine();
            //Console.WriteLine(string.Concat(palabra1, palabra2, palabra);
        }
    }
}
