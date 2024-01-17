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
            //variable local a main
            byte numAr;
            string nombre;
            int numero;

            //asignamos un valor
            numAr = 10;

            //mostrar su valor en la consola
            Console.WriteLine(numAr);

            //Invocamos al metodo y mandamos al argumento
            Prueba(out nombre, out numero); //ref numAr

            //Despues de que el metodo cambio el calor, volvemos a mostrar al arguemtno
            //.Console.WriteLine(numAr);
            Console.WriteLine(nombre);
            Console.WriteLine(numero);
        }

        static void Prueba(out string nombre, out int numero) //ref byte numPa
        {
            //modificamos el valor del parametro
            //numPa = 20;
            nombre = "Hola a todoos";
            numero = 7;
        }
    }
}
