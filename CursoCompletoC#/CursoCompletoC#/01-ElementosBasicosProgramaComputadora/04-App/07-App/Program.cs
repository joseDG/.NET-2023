using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _07_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int num1 = 5, num2, resultado;

            //Preguntando al usuario el numero
            Console.WriteLine("Dame un numero para sumarlo: ");
            //Se asigna ala variable de tipo string "entrada"
            entrada = Console.ReadLine();

            //Convertimos la cade a tipo int
            num2 = Convert.ToInt32(entrada);
            resultado = num1 + num2;

            //Mostramos el resutlado
            Console.WriteLine("El resultado de la suma es: {0}", resultado);

            //convertimos en una linea
            num1 = Int32.Parse(Console.ReadLine());
            int Suma = num1 + 5;
            Console.WriteLine("el resutlado de la suma {0}", resultado);
        }
    }
}
