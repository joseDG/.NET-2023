using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace _10_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instruciones anidadas
            //varibales
            int i;
            int j;
            int resultado;

            for(i=1; i <=10; i++)
            {
                Console.WriteLine("Tabla de multiplicar del {0}", i);

                for(j=1; j <=10; j++)
                {
                    resultado = i * j;
                    Console.WriteLine("{0} * {1} = {2}", i, j, resultado);
                }

            }

            Console.ReadKey();
        }
    }
}
