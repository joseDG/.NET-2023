using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string Builder

            //string numeros = "";

            //for (int i = 1; i <= 100; i++)
            //{
            //    numeros += i + ",";
            //}
            //Console.WriteLine(numeros);

            //se utiliza para operacio de bsuquedas mas grandes
            //se realiza numero fijo de oepracion de contatenacion
            StringBuilder numeros = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                numeros.Append(i);
                numeros.Append(", ");
            }

            string cadenaNuemros = numeros.ToString();
            Console.WriteLine(cadenaNuemros);


        }
    }
}
