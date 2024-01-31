using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_App.services
{
    //Clase estática para manejar los libros, no es necesario instanciarla, accedemos a los métodos de manera directa
    public static class BookService
    {
        private static List<Book> books = new List<Book>();
    }
}
