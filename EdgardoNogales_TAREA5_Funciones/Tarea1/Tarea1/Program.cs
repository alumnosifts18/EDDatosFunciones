using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        /*Crea una función llamada "Signo", que reciba un número real, y devuelva 
        un número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.*/

        public static int Signo (string number)
        {
            bool result = Regex.IsMatch(number, "^-");

            if (result == true) return -1;
            else return 1;
        }
        static void Main(string[] args)
        {
            string real_number;
            int real_result;
            //Ingreso número real.
            Console.Write("Ingrese número real: ");
            real_number = Console.ReadLine();

            //Llamamos al método Signo.
            real_result = Signo(real_number);

            Console.WriteLine(real_result);
            Console.ReadKey();
            
        }
    }
}
