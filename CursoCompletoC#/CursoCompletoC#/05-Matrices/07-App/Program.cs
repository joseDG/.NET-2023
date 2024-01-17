using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int i; //variables de control de ciclo exterior
            int j; //variable control de ciclo interior

            //tipo[,] nombre = new tipo [filas, columnas]
            double[,] ventas = new double[4, 3] { { 100, 120, 205},
                                                  { 115, 196, 300},
                                                  { 157, 172, 245 },
                                                  { 130, 180, 281} };
            for(i=0; i<4; i++)
            {
                Console.WriteLine("Filas {0}", i);
                for(j = 0; j < 3; j++)
                {
                    Console.WriteLine(ventas[i, j]);
                }
            }

            
        }
    }
}

////declaraciones e instancia de matriz de 3 dimenciones
//int[,,] matriz3D = new int[2, 2, 3] {{{ 1,2,3},{ 4, 5, 6 }},
//                                                {{ 7,8,8},{ 10,11,12}}};