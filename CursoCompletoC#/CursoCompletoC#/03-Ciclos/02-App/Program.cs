using System;
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
            //Varibale
            int i;
            int contador = 0;

            for(i=0; i <= 20; i+= 2)
            {
                contador += 1;
                Console.WriteLine("{0}, vuelta del ciclo numero {1}", i, contador);
            }
            Console.WriteLine("El numero de vueltas que dio el ciclo fue: {0}", contador);
        }
    }
}
