using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.Sum(1,2));
            Console.WriteLine(math.Sum("1", "2"));
        }
    }

    class Math
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        //aqui se aplica la sobrecarga
        public int Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
    }
}
