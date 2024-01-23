using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int i;
            int j;

            double[,] ventas2D = new double[4, 3]{ {100, 120, 205 },
                                                   { 115, 196, 300},
                                                   { 157, 172, 245},
                                                   { 130, 180, 281}};

            //mostrar el tamno de la primer diemnsion
            //Console.WriteLine(ventas2D.GetLength(1));

            for (i = 0; i < ventas2D.GetLength(0); i++)
            {
                Console.WriteLine("Elemento: {0}", i);
                for (j = 0; j < ventas2D.GetLength(1); j++)
                {
                    Console.WriteLine(ventas2D[i, j]);
                }
            }
        }
    }
}
