using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parrafo = "¡Ah! esa es una de las idea de Harry, ¿no es asi, senor Gray?";

            string[] palabras = parrafo.Split(' ', ',');

            foreach(string elem in palabras)
            {
                Console.WriteLine("Palabra sustraida: |{0}|", elem);
            }
            Console.WriteLine(palabras[1]);
        }
    }
}
