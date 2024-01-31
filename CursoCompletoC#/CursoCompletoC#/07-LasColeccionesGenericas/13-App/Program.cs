using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que simule una app bancaria sencilla, y que nos permita tres cosas:

            Ingresar un gasto

            Mostrarnos todos los gastos que hemos hecho, empezando por el último

            Sumar todos los gastos hechos y mostrarnos el monto que debemos pagar(pago para no generar intereses)*/

            //variables
            int opcion;
            float gasto;

            //declarar el stack
            Stack<float> gastos = new Stack<float>();

            do
            {
                Console.Clear();

                Console.WriteLine("1. Agregar Gasto");
                Console.WriteLine("2. Mostrar gastos del mes");
                Console.WriteLine("3. Pago para no generar interes");

                //escoge una opcion
                Console.WriteLine("\nEscoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Monto: $");
                        gasto = Convert.ToInt32(Console.ReadLine());

                        gastos.Push(gasto);
                        break;

                    case 2:
                        Console.WriteLine("Gastos del mes: \n");

                        foreach(float elemento in gastos)
                        {
                            Console.WriteLine("{1}", elemento);
                        }

                        Console.WriteLine("\nPresiona cualuier teclado para continuar...");
                        Console.ReadKey();
                        break;

                    case 3:
                        float total = 0;
                        foreach(float elemento in gastos)
                        {
                            total += elemento;
                        }

                        Console.WriteLine("Pago para no genera intereses: ${0}", total);
                        Console.WriteLine("\nPresiona cualuier teclado para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion >= 1 && opcion <= 3);
        }
    }
}
