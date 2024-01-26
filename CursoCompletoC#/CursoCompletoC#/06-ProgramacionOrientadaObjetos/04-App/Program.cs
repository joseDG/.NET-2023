using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _04_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando ala clase ramdom
            Random random = new Random();
            Console.WriteLine(random.Next(20, 35));
        }
    }
}
