using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        /* Crea una función "Menor" que calcule el menor de dos números enteros que recibirá como parámetros. 
        El resultado será otro número entero.*/

        //Creo función menor. 
        public static int Menor(int first_number, int second_number)
        {
            return Math.Min( first_number, second_number);
        }
        static void Main(string[] args)
        {
            //Defino las variables que contendrán a los enteros y el resultado de la comparación.
            int result, number_1, number_2;
            //Ingreso los enteros.
            Console.WriteLine("Ingrese primer número entero: ");
            number_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese segundo número entero: ");
            number_2 = Convert.ToInt32(Console.ReadLine());

            //Llamo a la función y muestro el resultado.
            result = Menor(number_1, number_2);

            Console.WriteLine("El entero más chico es el " + result + ".");
            Console.ReadKey();

        }
    }
}
