using BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SqlServerConnectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                BeerDB beerDB = new BeerDB(@"Josh\SQLEXPRESS", "CsharpDB", "sistemas", "admin");
                bool again = true;
                int op = 0;

                //creacion del menu
                do
                {
                    ShowMenu();
                    Console.WriteLine("Elige una opcion: ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Show(beerDB);
                            break;
                        case 2:
                            Add(beerDB);
                            break;
                        case 3:
                            Edit(beerDB);
                            break;
                        case 5:
                            again = false;
                            break;
                    }
                } while (again);
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine("No pudimos conectarnos");
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("\n------------Menu-------------");
            Console.WriteLine("1.- Mostrar");
            Console.WriteLine("2.- Agregar");
            Console.WriteLine("3.- Editar");
            Console.WriteLine("4.- Eliminar");
            Console.WriteLine("5.- Salir");
        }

        public static void Show(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Cerveza de la base de datos");
            List<Beer> beers = beerDB.GetAll(); 

            foreach(var beer in beers)
            {
                Console.WriteLine($"Id: {beer.Id} Nombre: {beer.Name}");
            }
        }

        public static void Add(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Agregar nueva cerveza");
            Console.WriteLine("Escriba el nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de la marca:");
            int brandId = int.Parse(Console.ReadLine());
            Beer beer = new Beer(name, brandId);
            beerDB.Add(beer);
        }

        public static void Edit(BeerDB beerDB)
        {
            Console.Clear();
            Show(beerDB);
            Console.WriteLine("Editar Cerveza");
            Console.WriteLine("Escribe el id de tu cerveza a editar: ");
            int id = int.Parse(Console.ReadLine());

            Beer beer = beerDB.Get(id);
            if (beer != null)
            {
                Console.WriteLine("Escribe el nombre: ");
                string name = Console.ReadLine();
                Console.WriteLine("Escribe el id de la marca:");
                int brandId = int.Parse(Console.ReadLine());

                beer.Name = name;
                beer.BrandId = brandId;
                beerDB.Edit(beer);
            }
            else
            {
                Console.WriteLine("La cerveza no existe");
            }
        }
        public static void Delete(BeerDB beerDB)
        {
            Console.Clear();
            Show(beerDB);
            Console.WriteLine("Eliminar Cerveza");
            Console.WriteLine("Escribe el id de tu cerveza a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            Beer beer = beerDB.Get(id);
            if (beer != null)
            {
                beerDB.Delete(id);
            }
            else
            {
                Console.WriteLine("La cerveza no existe");
            }
        }
    }
}
