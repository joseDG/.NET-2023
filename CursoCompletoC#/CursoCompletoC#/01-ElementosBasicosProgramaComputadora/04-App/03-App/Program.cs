using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            double num2 = 4.5;
            double resultado;

            //Sumamos las dos variables
            resultado = num1 + num2;

            //Sumando una variable y un dato puesto explicitamente
            resultado = num1 + 22;
            Console.WriteLine(resultado);

            //Los strings
            string saludo = "Hola";
            string nombre = "Jose";

            //Suamdno dos cadenas almacenadas en variables (concatenar)
            Console.WriteLine(saludo + " " + nombre + "Como estas?");

            //Usando el operador Resta
            Console.WriteLine(50- 8 );

            //Usando el operador "multiplicacion"
            Console.WriteLine(2 * 2);

            //Division
            Console.WriteLine(5.9 % 3.1);
        }
    }
}
