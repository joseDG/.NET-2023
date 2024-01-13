using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operador Or

            //variables
            float calPrepa, calExam;

            Console.Write("¿Con qué promedio concluiste tus estudios de preparatoria?: ");
            calPrepa = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingresa la califiación que obtuviste en tu examen de ingreso: ");
            calExam = Convert.ToSingle(Console.ReadLine());

            // Condición
            if ((calPrepa >= 9) || (calExam >= 9.5))
            {
                Console.WriteLine("¡Felicidades, tienes la beca!");
            }
            else
            {
                Console.WriteLine("Lo siento, no eres acredor a una beca");
            }
        }
    }
}
