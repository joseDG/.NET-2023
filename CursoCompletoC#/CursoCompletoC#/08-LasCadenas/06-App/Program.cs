using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra1 = "Hola";
            string palabra2 = palabra1;

            //IMprimimos el valor de ambas referencias
            Console.WriteLine("Referncia 1: " + palabra1);
            Console.WriteLine("Referncia 2: " + palabra2);

            palabra1 += "a todos";

            Console.WriteLine("\nDespues de la concatenacion\n");
            Console.WriteLine("Referencia 2: "  + palabra2);
        }
    }
}
