using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir un numero al usuario y determinar si este es positivo o negativo

            //Variables
            double numero;

            //pedimos el numero para evaluar
            Console.WriteLine("Damel el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());

            //Usamos un condicional "if para saber si el numero es mayor que cero"
            if (numero > 0)
            {
                //Se ejecuta en caso de que la expresion se evalue como true
                Console.WriteLine("El numero es positivo");
            }

            if(numero < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
        }
    }
}
