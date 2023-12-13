using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = { "Victor", "Carlos", "Ana", "Luis", "Jorge" };
            
            for(int x=0; x<Nombres.Length; x++)
            {
                Console.WriteLine("Contenido del Vector Nombres en el indice" + x + "es:" + Nombres[x]);
            }

            Console.ReadKey();
        }
    }
}
