using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se necesita un programa que realice las 4 operaciones basicas: suma, resta, multiplicacion, division, a partir de dos numeros, la opreacion deseada sera elegida por el usuario

            double numero1, numero2, resultado;
            string nombreOperacion;

            Console.WriteLine("Ingrese el nombre de la operacion");
            nombreOperacion = Console.ReadLine();

            Console.WriteLine("Ingrese el primer numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());


            if (nombreOperacion == "suma")
            {
                resultado = numero1 + numero2;
                Console.WriteLine("El resultado de la suma: {0}", resultado);
            }
            if(nombreOperacion == "resta")
            {
                resultado = numero1 - numero2;
                Console.WriteLine("El resultado de la resta: {0}", resultado);
            }
            if(nombreOperacion == "multi")
            {
                resultado = numero1 * numero2;
                Console.WriteLine("El resultado de la multiplicacion: {0}", resultado);
            }if(nombreOperacion == "division")
            {
                resultado = numero1 / numero2;
                Console.WriteLine("El resultado de la division: {0}", resultado);
            }
        }
    }
}
