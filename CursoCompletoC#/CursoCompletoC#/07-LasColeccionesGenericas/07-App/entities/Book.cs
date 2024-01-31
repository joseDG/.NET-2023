using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_App.entities
{
    public class Book
    {
        //propiedades base de un libro
        public int Id { get; set; }
        public  string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
        public string Category { get; set; }
    }
}
