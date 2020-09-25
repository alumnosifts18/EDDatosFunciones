using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        /*
         Crea una función "EsPrimo", que reciba un número y devuelva el valor booleano
        "true" si es un número primo o "false" en caso contrario.*/
        public static bool EsPrimo(int number)
        {
            bool prime = true;
            //El 2 es el único primo par.
            if (number == 2) return true;
            else if (number == 0 || number == 1) return false;
            else
            {
                //Bucle para determinar si es primo.
                for (int i = 2; i < number && prime == true; i++)
                {
                    if (number % i == 0) prime = false;
                }
                return prime;
            }

        }
        static void Main(string[] args)

        {
            //Declaro variables para aplicar restricción y guardar el valor correcto.
            bool exit, result, prime_number ;
            int number_result;
            string number;

            do
            {
                Console.Write("Ingresar número: ");
                number = Console.ReadLine();
                //Verifico si es un número entero positivo.
                result = Regex.IsMatch(number, @"\D");
                if (result == true)
                {
                    Console.WriteLine("El número ingresado no es un entero positivo.");
                    Console.WriteLine("Escribir sin espacios");
                    exit = false;
                }
                else exit = true;
                
            } while (exit == false);
            number_result = Convert.ToInt32(number);
            //Llamo a la función y muestro el resultado.

            prime_number = EsPrimo(number_result);
            Console.WriteLine("El número ingresado es primo: " + prime_number);

            Console.ReadKey();
        }
    }
}