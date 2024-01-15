using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            i = 10;

            Console.WriteLine("Valor incial del operando: {0}", i);

            //Incremento como prefijo e imprimimos
            Console.WriteLine("Valor con incremento incluido: {0}", i++);

            //Solo impresion
            Console.WriteLine(i);

            int f;

            f = 20;

            Console.WriteLine("Valor inicial del operando: {0}", f);
            //decremento como prefijo
            Console.WriteLine("valor con decremento : {0}", f--);

            //Solo impresion
            Console.WriteLine(f);
        }
    }
}
