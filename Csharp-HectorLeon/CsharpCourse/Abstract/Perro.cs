using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Perro: Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: Gua gua");
        }
    }
}
