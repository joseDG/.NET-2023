using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Animal
    {
        public abstract void HacerSonido();

        public void Dormir()
        {
            Console.WriteLine("El animal esta durmiendo.");
        }
    }
}
