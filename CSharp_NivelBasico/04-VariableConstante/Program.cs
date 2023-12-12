using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_VariableConstante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int Edad;
            const double Sueldo = 2500;

            nombre = "jose";
            Edad = 30;

            Console.WriteLine("Tu nombre es: " + nombre);
            Console.WriteLine("Tu edad es: " + Edad);
            Console.WriteLine("Tu Sueldo: " + Sueldo);
            Console.ReadKey();
        }
    }
}
