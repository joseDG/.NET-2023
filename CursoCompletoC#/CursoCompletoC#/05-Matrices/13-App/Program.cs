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
            int[] matriz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //invocamos el metodo
            ImprimirMatriz(matriz);

            //Matriz multi
            double[,] matriz2D ={ {1,2 },
                                  {3, 4}};

            //inovcamos al metodo
            ImprimirMatrizMulti(matriz2D);
        }

        //metodos que imprima lso valores de la matriz
        static void ImprimirMatriz(int[] matrizPa)
        {
            int i;
            for(i=0; i < matrizPa.Length; i++){
                Console.WriteLine(matrizPa[i]);
            }
        }

        //metodo que imprime los valores de la matriz mult
        static void ImprimirMatrizMulti(double[, ] matriz2DPa)
        {
            int i,j;
            for (i = 0; i < matriz2DPa.GetLength(0); i++)
            {
                Console.WriteLine("Fila {0}", i);
                for(j= 0; j < matriz2DPa.GetLength(1); j++)
                {
                    Console.WriteLine(matriz2DPa[i, j]);
                }
            }
        }
    }
}
