﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se necesita un programa que realice las 4 operaciones básicas: suma, resta, multiplicación y división, a partir de dos números, la operación deseada será elegida por el usuario.

            // Variables
            decimal num1, num2, resultado = 0.0M;
            byte opcion;

            // Mostramos el menú
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            // Pedimos al usuario que escoja una opción
            Console.Write("Escoge una opción: ");
            opcion = Convert.ToByte(Console.ReadLine());

            // Pedimos el primer número
            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            // Pedimos el segundo número
            Console.Write("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No es posible dividir entre cero");
                    }
                    break;
                default:
                    Console.WriteLine("Ingresa una opción valida");
                    break;
            }

            // Mostramos el resultado
            Console.WriteLine("El resultado es: {0}", resultado);

        }
    }
}
