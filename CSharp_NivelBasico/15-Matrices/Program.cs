using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Persona = new string[3, 2];

            Persona[0, 0] = "VICTOR";
            Persona[0, 1] = "RAMOS";

            Persona[1, 0] = "CARLOS";
            Persona[1, 1] = "RAMIREZ";

            Persona[2, 0] = "ANA";
            Persona[2, 1] = "ARIAS";

            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine("Persona [" + a + "] = " + Persona[a, 0] + " " + Persona[a, 1]);
            }

            Console.ReadKey();
        }
    }
}
