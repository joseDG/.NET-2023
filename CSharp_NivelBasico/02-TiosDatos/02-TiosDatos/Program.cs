using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TiosDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            int edad;
            string nombre = "Jose";
            edad = 34;
            double sueldo = 1025.36;
            bool casado = false;

            //con el signo + es para concatenar
            Console.WriteLine("Mi nombre es: " + nombre);
            Console.WriteLine("Mi edad es: " + edad);
            Console.WriteLine("Mi sueldo es de: " + sueldo);
            Console.WriteLine("Estas casado?: " + casado);
            Console.ReadKey();
        }
    }
}
