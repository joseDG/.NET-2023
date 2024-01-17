using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int opcion;
            decimal r; //alamcena el valor devuelto de restar()
            decimal num1Ar, num2Ar; //argumetnos para enviar una copia del valor

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                //Pedimos una opcion
                Console.WriteLine("Escoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            //Hacer la opreacion segun la opcion escogida
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    r = Restar(); //asignamos a "r" el valor devuelto por return
                    //mostrrar el resultado de r
                    Console.WriteLine("El resultado de la resta es: {0}", r);
                    break;
                case 3:
                    //pedidos el valor de ambos numeros
                    num1Ar = IngresarNumero("Ingrese el primer numero: ");
                    num2Ar = IngresarNumero("Ingrese el segundo numero: ");

                    //invocamos al metodo
                    Multiplicar(num1Ar, num2Ar);
                    break;
                case 4:
                    //pedidos el valor de ambos numeros
                    num1Ar = IngresarNumero("Ingrese el primer numero: ");
                    num2Ar = IngresarNumero("Ingrese el segundo numero: ");

                    r = Dividir(num1Ar, num2Ar);

                    //mostrar el resultado, con la informacion que contiene 
                    Console.WriteLine("El resultado de la division es: {0}", r);
                    break;
            }
        }

        //[modificador][tipo][identificador][parametro]
        static void Suma()
        {
            //varibales
            decimal num1, num2, resultado;

            //pedidos el valor de ambos numeros
            Console.WriteLine("Ingrese el primer numero:");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //operacion
            resultado = num1 + num2;

            //Mostrar el resultado
            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);


        }

        //[modificador][tio][identificador][parametro]
        static decimal Restar()
        {
            //varibales
            decimal num1, num2, resultado;

            //pedidos el valor de ambos numeros
            Console.WriteLine("Ingrese el primer numero:");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //operacion
            resultado = num1 - num2;

            //devolvemos un tipo al autor de llamado
            return resultado;

        }

        static void Multiplicar(decimal num1Pa, decimal num2Pa)
        {
            //variables
            decimal resultado;

            //multiplicacion con los valores que mandaron los argumentos
            resultado = num1Pa * num2Pa;

            //Mostrar el resultado
            Console.WriteLine("{0} * {1} = {2}", num1Pa, num2Pa, resultado);
        }

        //[modificador][tipo][identificador][parametro]
        static decimal Dividir(decimal num1Pa, decimal num2Pa)
        {
            //varibale
            decimal resultado;

            if(num2Pa != 0)
            {
                //Division con los valores que mandaron los arguemtnos
                resultado = num1Pa / num2Pa;
            }
            else
            {
                Console.WriteLine("No es posible dividir entre cero");
                resultado = 0;
            }

            return resultado;
        }

        //[modificador] [tipo] [identificador] [parametros]
        static decimal IngresarNumero(string peticion)
        {
            //variable local del metodo
            decimal numero;

            //pedimos el valor segun corresponda
            Console.WriteLine(peticion);

            //convertimos y asignamos
            numero = Convert.ToDecimal(Console.ReadLine());

            //devolvaemos el valor de tipo decimal
            return numero;
        }
    }
}
