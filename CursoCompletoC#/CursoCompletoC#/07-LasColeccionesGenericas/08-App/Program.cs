using System;
using System.Collections.Concurrent;
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
            //Stack
            Stack<double> miPila = new Stack<double>();

            //Insertar objetos al principio del stack
            miPila.Push(5.9);
            miPila.Push(13.1);
            miPila.Push(8.7);
            miPila.Push(3.2);
            miPila.Push(10.5);

            int i = 0;

            //recorer la informcion del stack
            foreach (var elem in miPila)
            {
                Console.WriteLine("{0}. {1}", i++, elem);
            }
            //despues de instar un elemento
            Console.WriteLine("\n despues de insertar un elemento\n");
            miPila.Push(1.5);

            i = 0;
            foreach (var elem in miPila)
            {
                Console.WriteLine("{0}. {1}", i++, elem);
            }

            //despues de quitar un elemento
            Console.WriteLine("\n despues de insertar un elemento\n");
            var eliminado = miPila.Pop();
            i = 0;

            //mostrar la informacion del stack
            foreach(double elem in miPila)
            {
                Console.WriteLine("{0}. {1}", i++, elem);
            }

            Console.WriteLine("El elemetno ({0}) ha sido eliminado con exito", eliminado);

            //despues de usar Peek
            Console.WriteLine("\ndespues de usar peek\n");
            var primerObj = miPila.Peek();
            i = 0;

            foreach (double elem in miPila)
            {
                Console.WriteLine("{0}. {1}", i++, elem);
            }

            Console.WriteLine("El primer elemento del stack es: ({0})", primerObj);

            //saber si el stack contiene un elemento
            bool contiene;
            double buscarElem;

            Console.WriteLine("\nIngrese el elemento a buscar: ");
            buscarElem = Convert.ToDouble(Console.ReadLine());

            contiene = miPila.Contains(buscarElem);

            if (contiene)
            {
                Console.WriteLine("El objeto ({0}) se encuentra en el Stack", buscarElem);
            }
            else
            {
                Console.WriteLine("No se encontro el objeto ({0}) en el Stack", buscarElem);
            }

            Console.WriteLine("\n El stack tiene {0} elementos", miPila.Count);

            //borarndo el stack
            Console.WriteLine("\nDespues de borar el stack");
            miPila.Clear();

            Console.WriteLine("\n El stack tiene {0} elementos", miPila.Count);

            //Agregando objetos al Queue
            

            
        }
    }
}
