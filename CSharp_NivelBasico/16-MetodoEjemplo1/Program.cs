using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_MetodoEjemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IngresoDatos();
            Console.ReadKey();
        }

        // Método ejemplo 1
        static void IngresoDatos()
        {
            string Nombre;
            Console.Write("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Tu nombre es: " + Nombre);
        }
    }
}
