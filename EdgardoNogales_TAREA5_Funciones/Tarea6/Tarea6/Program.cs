using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    class Program
    {
        /*Crea una función "SumaCifras" que reciba un numero cualquiera y que devuelva como resultado
         la suma de sus dígitos. Por ejemplo, si el número fuera 123 la suma sería 6.*/

        public static int SumaCifras(string number)
        {
            int suma = 0;
            char[] arrayNumeros = number.ToCharArray();

            foreach(char numero in arrayNumeros)
            {
                suma += int.Parse(numero.ToString());
            }
            return suma;
        }
        static void Main(string[] args) { 
     
             int resultado;
             string numero;

            Console.Write("Ingresar numero para sumar sus digitos: ");
            numero = Console.ReadLine();

            resultado = SumaCifras(numero);
            Console.WriteLine("El resultado de la suma de los digitos es : " + resultado);

            Console.ReadKey();
        }
    }
}
