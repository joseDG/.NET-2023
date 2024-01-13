using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento de un centro comercial con base en el tiempo que ha permanecido ahí, los primeros 60 minutos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00

            float minutos;

            Console.WriteLine("Ingrese el tiempo que estuviste en el estacionamiento");
            minutos = float.Parse(Console.ReadLine());

            if(minutos >= 0 && minutos <= 60)
            {
                Console.WriteLine("Pagar $5 por favor");
            }
            else
            {
                if(minutos > 60 && minutos <= 120)
                {
                    Console.WriteLine("Paga $15.00 por favor");
                }
                else
                {
                    if(minutos > 120)
                    {
                        Console.WriteLine("Paga $15 por favor");
                    }
                }
            }


        }
    }
}
