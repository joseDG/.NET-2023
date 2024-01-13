using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            byte edad;

            Console.WriteLine("¿Que edad tienes?: ");
            edad = Convert.ToByte(Console.ReadLine());


            if(edad >= 18)
            {
                Console.WriteLine("Eres mayor de Edad");
            }
            else
            {
                Console.WriteLine("Eres menor de Edad");
            }
        }
    }
}
