using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bateria;

            Console.WriteLine("¿Hay bateria? (true/false): ");
            bateria = Convert.ToBoolean(Console.ReadLine());

            if(!(bateria == true))
            {
                Console.WriteLine("Conectra el celular");
            }
            else
            {
                Console.WriteLine("No es necesario conectar el celular");
            }
        }
    }
}
