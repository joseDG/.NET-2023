using System;


namespace _51_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();
            av1.mostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura provincial de madris", "sancion velocidad $3200", "02-05-2019");
            Console.WriteLine(av2.getFecha());
            av2.mostrarAviso();
        }
    }
}
