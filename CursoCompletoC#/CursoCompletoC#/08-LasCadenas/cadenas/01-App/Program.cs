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
            //instanciando a String por medio del alias "string"
            string cadena1 = "";
            string cadena2 = " ";
            string cadena3 = "Hola Mundo";

            char[] caracteres = { 'H', 'o', 'l', 'a' };
            //creando una isntancia de String
            String cadenaCaracteres = new string(caracteres);

            //Imprimiendo la isntancia
            Console.WriteLine(cadenaCaracteres);
        }
    }
}
