using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _12_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Agregar la opción (5. Actualizar contacto) al ejercicio con "Dictionary" de la agenda telefónica haciendo uso de la propiedad "Item[ ]".

            //variables necesarias
            int opcion;
            string nombre;
            long numero;

            //Instanciamos a ala coleccion
            Dictionary<string, long> contactos = new Dictionary<string, long>();

            do
            {
                Console.Clear();

                //Menu
                Console.WriteLine("1. Agregar Contacto");
                Console.WriteLine("2. Buscar Contacto");
                Console.WriteLine("3. Eliminar Contacto");
                Console.WriteLine("4. Mostrar Contactos");

                Console.WriteLine("\nEscoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Nombre: ");
                        nombre = Console.ReadLine();

                        Console.Write("Número: ");
                        numero = Convert.ToInt64(Console.ReadLine());

                        contactos.Add(nombre, numero);
                        Console.WriteLine("\n({0}) se ha agregado con exito", nombre);

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Write("Buscar contacto por nombre: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine("\n¡Contacto encontrado!");

                            Console.WriteLine("{0}: {1}", nombre, contactos[nombre]);

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        Console.Write("Contacto a eliminar: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            contactos.Remove(nombre);

                            Console.WriteLine("\n({0}) ha sido eliminado con exito", nombre);

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        Console.WriteLine("Contactos en tu agenda: \n");

                        foreach (KeyValuePair<string, long> elemento in contactos)
                        {
                            Console.WriteLine("{0}: {1}", elemento.Key, elemento.Value);
                        }

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        break;
                }

            } while (opcion >= 1 && opcion <= 4);
        }
    }
}
