using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //concatenar cadenas
            string texto1 = "Hola";
            string texto2 = "a";
            string texto3 = "todos";

            string texto4 = "Hola a todos";

            string texto5 = "Hola" + "a" + "todos";

            string textoLibro = "-!Ah esta es una de las ideas de harry, no esta senor ?"
                + "Simepre oigo las ideas de harri de loabis de us amifos. es asi como"
                + "la adoro, pero me da miedo.";

            Console.WriteLine(textoLibro);

            textoLibro += "Me pongo demasiaso romantico. Sencilalmente, venero a lso pianistas donde algunas de las ocasiones de mdice, harry";

            Console.WriteLine(textoLibro);

            int num1 = 10;
            Console.WriteLine("\nEl valor de numero 1 es: {0}", num1);
            Console.WriteLine("\nEl valor de numero 1 es: "+ num1);
        }
    }
}
