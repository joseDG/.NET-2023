﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //varibales
            double dividendo, divisor, resultado;

            //podimos el dividento
            Console.WriteLine("Dame el dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());

            //Pedimos divisor
            Console.WriteLine("Dame el divisor: ");
            divisor = Convert.ToDouble(Console.ReadLine());

            if(divisor != 0)
            {
                resultado = dividendo / divisor;
                Console.WriteLine("{0} / {1} = {2}", dividendo, divisor, resultado);
            }
        }
    }
}
