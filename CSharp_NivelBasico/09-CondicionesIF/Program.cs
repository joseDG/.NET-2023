using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_CondicionesIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            double Sueldo;

            Console.WriteLine("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu Sueldo: ");
            Sueldo = double.Parse(Console.ReadLine());

            if (Sueldo <= 1024)
            {
                Console.WriteLine(Nombre + " El sueldo que tu tienes es el minimo vital en Peru");
            }
            else
            {
                Console.WriteLine(Nombre + "El sueldo que tu tienes es superior al minimo vital ");
            }

            Console.ReadKey();
        }
    }
}
