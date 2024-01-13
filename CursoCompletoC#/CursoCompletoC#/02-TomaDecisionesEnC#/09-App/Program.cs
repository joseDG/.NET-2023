using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color;

            Console.WriteLine("Ingrese el color RGB para detener su codigo: ");
            color = Console.ReadLine();

            switch (color)
            {
                case "Red":
                case "RED":
                case "red":
                    Console.WriteLine("El codigo RGB para {0} es: 255, 0, 0", color);
                    break;
                case "Green":
                    Console.WriteLine("El codigo RGB para {0} es: 0, 255, 0", color);
                    break;
                case "Blue":
                    Console.WriteLine("El codigo RGB para {0} es: 0, 0, 255", color);
                    break;
                default:
                    Console.WriteLine("No se encontro el codigo RGB para el color {0}, intenta de nuevo", color);
                    break;
            }
        }
    }
}
