using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_CasoPractico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Fila;

            Console.Write("Ingresa la cantidad de persons a registrar: ");
            Fila = int.Parse(Console.ReadLine());

            string[,] Personas = new string[Fila, 2]; //Se crea la matriz

            //Se ingresará información de las personas a registrar
            for (int a = 0; a < Fila; a++)
            {
                Console.Write("ingresa su nombre #" + (a + 1) + " :");
                Personas[a, 0] = Console.ReadLine();
                Console.Write("Ingresa su edad:");
                Personas[a, 1] = Console.ReadLine();
                Console.WriteLine("");
            }

            //Listar toda la información ingresada a la matriz persona
            Console.WriteLine("");
            Console.WriteLine("NOMBRES     EDAD");
            for (int b = 0; b < Fila; b++)
            {
                Console.WriteLine(Personas[b, 0] + " - " + Personas[b, 1]);
            }

            Console.ReadKey();
        }
    }
}
