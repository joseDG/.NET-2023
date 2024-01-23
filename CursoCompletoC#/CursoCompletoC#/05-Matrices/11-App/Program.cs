using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;

            //tipo [][] nombre = new tipo [fila][];
            double[][] ventas = new double[4][]
            {
                new double[] { 155, 100, 170 },
                new double[] { 205, 120 },
                new double[] {115, 190, 104, 130 },
                new double[] {163, 218, 125 }
            };

            for(i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine("Elemento: {0}", i);
                for(j=0; j < ventas[i].Length; j++)
                {
                    Console.WriteLine(ventas[i][j]);
                }
            }

        }
    }
}
