using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionay, se compone de un par clave- valor o key-value pair
            Dictionary<string, int> empleados = new Dictionary<string, int>();

            //anadiendo key-value pairs a la coleccion
            empleados.Add("Hugo", 36);
            empleados.Add("Erica", 20);

            foreach(KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine("Key = {0}, Value = {1}", elemento.Key, elemento.Value);
            }

            //coleccion[key] = value;
            empleados["Miguel"] = 45;

            //Despues de agrear un elemento con Item[]
            Console.WriteLine("\nDespues de agregar un elemento con Item[]\n");

            foreach (KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine("Key = {0}, Value = {1}", elemento.Key, elemento.Value);
            }

            //Comprobando que Item[] reemplaza la "key"
            Console.WriteLine("\nComprobando que Item[] reemplaza la (key)\n");

            empleados["Hugo"] = 19;

            foreach (KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine("Key = {0}, Value = {1}", elemento.Key, elemento.Value);
            }

            //usando el "get" de la prioridad Item[]
            Console.WriteLine("\nLa edad de Erica es: {0}\n", empleados["Erika"]);

            Console.WriteLine("\nDespues de remover un elemento\n");
            empleados.Remove("Erica");

            foreach (KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine("Key = {0}, Value = {1}", elemento.Key, elemento.Value);
            }

            Console.WriteLine();

            if (empleados.ContainsKey("Erica"))
            {
                Console.WriteLine("La key se encietra en la coleccion");
            }
            else
            {
                Console.WriteLine("La key no se encuentra en la coleccion");
            }

        }
    }
}
