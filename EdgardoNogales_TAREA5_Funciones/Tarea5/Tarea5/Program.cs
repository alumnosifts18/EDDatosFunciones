using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarea5
{
    class Program
    {
        /*Crea una calculadora básica, llamada "calcula", que deberá sumar, restar, 
             * multiplicar o dividir los dos números que se le indiquen como parámetros. 
             * Ejemplos de su uso sería "calcula 2 + 3" o "calcula 5 * 60". (Utilice Funciones)*/
        
        //Creo funciones.
        public static int Sumar( int number_1, int number_2)
        {
            return number_1 + number_2;
        }

        public static int Restar( int number_1, int number_2)
        {
            return number_1 - number_2;
        }
        public static int Multiplicar (int number_1, int number_2)
        {
            return number_1 * number_2;
        }
        public static int Dividir(int number_1, int number_2)
        {
            return number_1 / number_2;
        }
        public static int Calcula(int number_1, int number_2, int value)
        {
            if (value == 1) return Sumar(number_1,number_2);
            if (value == 2) return Restar(number_1,number_2);
            if (value == 3) return Multiplicar(number_1,number_2);
            if (value == 4) return Dividir(number_1, number_2);
            else return 0;
        }
        static void Main(string[] args)
        {
            string answer;            
            int operacion, primer_valor, segundo_valor, calcular;
            Console.WriteLine("Ingresar alguno de estos valores para realizar una operación.");
            Console.Write(" Sumar (1), restar (2), multiplicar (3), dividir (4): ");
            operacion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresar primer valor: ");
            primer_valor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresar primer valor: ");
            segundo_valor = Convert.ToInt32(Console.ReadLine());

            calcular = Calcula(primer_valor,segundo_valor,operacion);
            Console.WriteLine("El resultado de la operación es " + calcular);
            Console.ReadKey();
        }
    }
}
