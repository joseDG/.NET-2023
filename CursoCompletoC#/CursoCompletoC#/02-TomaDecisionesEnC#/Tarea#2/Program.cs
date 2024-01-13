using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.

            int numero;

            Console.WriteLine("Ingresa un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("{0} es par", numero);
            }
            else
            {
                Console.WriteLine("{0} es impar", numero);
            }
        }
    }
}
