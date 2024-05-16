using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenteciaifElseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool areYouHungry = true;
            bool youHaveMoney = false;

            if(areYouHungry && youHaveMoney)
            {
                Console.WriteLine("Come");
            }
            else
            {
                Console.WriteLine("No comes");
            }
        }

        static bool IsOpenRestauran(string name, int hour = 0)
        {
            if(name == "Lonches pepe" && hour > 8  && hour < 23){
                return true;
            }
            else if(name == "Restarante 24 horas")
            {
                return true;
            }
        }
    }
}
