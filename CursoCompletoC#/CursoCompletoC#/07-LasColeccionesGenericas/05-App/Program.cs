using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables necesarias
            string elem;
            int opcion;
            int i;

            //Instancia de List
            List<string> Personas = new List<string>();

            //agregamos objetos en la list
            Personas.Add("Hugo");
            Personas.Add("Miguel");
            Personas.Add("Diana");
            Personas.Add("Erick");


            Console.WriteLine("Con For");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine(Personas[i]);
            }

            Console.WriteLine("Con ForEach");
            //isntruccion foreach para recorre una coleccion
            foreach (string persona in Personas)
            {
                Console.WriteLine(persona);
            }

            //insertamos los elementos
            Personas.Insert(2, "Elena");

            //recorrer la lista actualizada
            Console.WriteLine("Lista actualizada");
            foreach (string persona in Personas)
            {
                Console.WriteLine(persona);
            }

            //quitando elemento de la lista
            Personas.RemoveAt(2);

            //recorrer la lista actualizada
            Console.WriteLine("Lista actualizada");
            foreach (string persona in Personas)
            {
                Console.WriteLine(persona);
            }

            Console.WriteLine("\nIngrese el elemento a buscar en la List: ");
            elem = Console.ReadLine();

            //bsucar el elemento en la List
            Console.WriteLine("El elemento se encuentra en el indice: {0}", Personas.IndexOf(elem));

        }
    }
}
