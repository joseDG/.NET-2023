using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Buscar
            //"Contains" , "StarsWith", "EndWith", "IndexOf", "LastindexOf"

            string parrafo = "-Siendo llegar tarde, Dorian Fui en busqueda de una pieza de boracda antigua en Wardour Street, y he tenido que regatear durante horas para seguir.En los dias que corren la gente sabe el precio de todo y el valor de nada.";

            Console.WriteLine("Extracto del retrato de Dorian Grey: \n\n{0}\n", parrafo);

            Console.WriteLine("\nIngrese el texto a buscar: ");
            string buscarTexto = Console.ReadLine();

            if (parrafo.EndsWith(buscarTexto))
            {
                Console.WriteLine("El texto ({0}) fue encontrado", buscarTexto);
            }
            else
            {
                Console.WriteLine("No se encontro el texto ({0}) en la cadena", buscarTexto);
            }

            string palabra = "pantalla";
            char caracterBuscado = 'a';
            int primerAparicion = palabra.LastIndexOf(caracterBuscado);

            Console.WriteLine("La primera aparicion del caracter ({0}) en la cadena ({1}) es en la posicion ({2})", caracterBuscado, palabra, primerAparicion);
        }
    }
}
