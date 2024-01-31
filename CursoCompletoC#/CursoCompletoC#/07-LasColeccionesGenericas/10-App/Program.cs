using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue
            Queue<char> miFila = new Queue<char>();

            //agreando objetos al Queue
            miFila.Enqueue('a');
            miFila.Enqueue('b');
            miFila.Enqueue('c');
            miFila.Enqueue('d');

            int i = 0;
            //Recorrido de la Queue
            foreach (char elem in miFila)
            {
                Console.WriteLine("{0}. {1}", i++, elem);
            }

            //agregando oro eleemtno
            Console.WriteLine("\n Despues de agrear a  (e)\n");
            miFila.Enqueue('e');

            i = 0;
            //Recorrido de la Queue
            foreach (char elem in miFila)
            {
                Console.WriteLine("{0}. {1}", i++, elem);
            }

            //despues de quitar u nelemento
            Console.WriteLine("\nDespues de quitar el elemento\n");
            var objElim = miFila.Dequeue();

            i = 0;
            //Recorrido de la Queue
            foreach (char elem in miFila)
            {
                Console.WriteLine("{0}. {1}", i++, elem);
            }
            Console.WriteLine("\n({0}) fue eliminado correctament", objElim);

        }
    }
}
