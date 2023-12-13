using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EstructurasSelectivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Dia;

            Console.Write("Ingrese el día en número: ");
            Dia = int.Parse(Console.ReadLine());

            switch (Dia)
            {
                case 1:
                    Console.WriteLine("ES LUNES");
                    break;
                case 2:
                    Console.WriteLine("ES MARTES");
                    break;
                case 3:
                    Console.WriteLine("ES MIÉRCOLES");
                    break;
                case 4:
                    Console.WriteLine("ES JUEVES");
                    break;
                case 5:
                    Console.WriteLine("ES VIERNES");
                    break;
                case 6:
                    Console.WriteLine("ES SÁBADO");
                    break;
                case 7:
                    Console.WriteLine("ES DOMINGO");
                    break;

                default:
                    Console.WriteLine("EL NRO DE DÍA INGRESADO NO ES VÁLIDO");
                    break;
            }
            Console.ReadKey();

        }
    }
}
