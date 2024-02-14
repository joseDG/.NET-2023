using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Comparacion de cadenas
            //La comparacion se hace para
            //-Ordenarlas
            //-Igualda
            //===========================
            //DOS OPERACIONES BASICAS
            //-Ordinales
            //-Culturales

            //consister en 
            //comparar el valor binario entrea cada char

            //============================
            //toma en cuenta
            //Mayusculas y minisculas
            //orden de las cadenas
            //formato

            //ordenar cadenas
            //Organizar un conjunto de cadenas basandose en:
            //-peso
            //-fonetica
            //-represetnaicon visual
            //=====================================================


            //Comparacion Ordinal
            //Equals
            // == !=

            Console.WriteLine("Ingrese tu correo: ");
            string correo = Console.ReadLine();

            Console.WriteLine("Ingresa tu correo neuvamente: ");
            string correoConfirmar = Console.ReadLine();

            bool coincidenciaCorreo = Equals(correo, correoConfirmar);

            if (correo == correoConfirmar)
            {
                Console.WriteLine("Registrado con exito");
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
