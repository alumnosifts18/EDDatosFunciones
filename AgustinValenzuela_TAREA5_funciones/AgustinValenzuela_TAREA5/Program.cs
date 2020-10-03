using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgustinValenzuela_TAREA5
{
    class Program
    /*{

        /*
        Crea una función llamada "Signo", que reciba un número real, y devuelva un número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.*/

        /* public static int signo(float n)
     {
         if (n == 0)
         {
             return 0;
         }
         else
         {
             if (n > 0)
             {
                 return 1;
             }
             else
             {
                 return -1;
             }
         }
     }
         static void Main()
     {
         float numero;
         Console.WriteLine("Ingrese un número: ");
         numero = Convert.ToSingle(Console.ReadLine());
         Console.WriteLine(signo(numero));

     }*/



        /*Crea una función "Menor" que calcule el menor de dos números enteros que recibirá como parámetros. El resultado será otro número entero.*/

        /*public static void menor(int num1, int num2) 
        {
            if (num1 < num2)
            {
                Console.WriteLine(num1);
            }
            else {
                Console.WriteLine(num2);
            }

        Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int n1;
            int n2;
            Console.WriteLine("Ingrese un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            menor(n1, n2);
        }*/



       
        /*Crea una función "EsPrimo", que reciba un número y devuelva el valor booleano "true" si es un número primo o "false" en caso contrario.*/

        /*public static Boolean EsPrimo(int num1)
        {
            if (num1==2 || num1 %2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Ingrese un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EsPrimo(n1));
            Console.ReadLine();
        }*/
        

        /* Analice el código ¿Qué hace este código? Realizar captura de pantalla del código con su resultado y análisis del mismo.*/

        /*static void Main(string[] args)
        {
            Console.Clear();
            for (int fila = 1; fila <=7; fila++)                            //Fila: indica cada cuantos "*" hay algun espacio.
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--)     //Espacios: indica cuantos espacios y "*" se van a imprimir dentro de cada fila.
                {
                    Console.WriteLine(" ");
                    for (int conta = 1; conta < (2*fila); conta++)          //Conta: indica la cantidad de "*" que se imprimen cada vez que se termina el ciclo.
                    {
                        Console.WriteLine("*");
                    }
                    Console.WriteLine(" ");
                    Console.ReadLine();
                }
            }
        }*/


        /*Crea una calculadora básica, llamada "calcula", que deberá sumar, restar,
        multiplicar o dividir los dos números que se le indiquen como parámetros. Ejemplos de
        su uso sería "calcula 2 + 3" o "calcula 5 * 60". (Utilice Funciones)*/

        
        /*public static float Calcula(string signo, int num1, int num2)
        {
            float n;
            switch (signo)
            {
                case "+":
                    n = num1 + num2;
                    //Console.WriteLine(num1 + num2);
                    return n;
                case "-":
                    n = num1 - num2;
                    return n;
                case "/":
                    n = num1 / num2;
                    return n;
                case "*":
                    n = num1 * num2;
                    return n;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calcula("*", 8, 15));
            Console.ReadLine();
        }*/
        

        /*Crea una función "SumaCifras" que reciba un numero cualquiera y que
        devuelva como resultado la suma de sus dígitos. Por ejemplo, si el número fuera 123 la
        suma sería 6. */
       
        
        /*public static int SumaCifras(String n)
        {
            int num = Convert.ToInt32(n);
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumaCifras("875"));
            Console.ReadLine();
        }*/
        

        /*
        (Opcional): Crea una función "Triángulo" que reciba una letra y un número, y
        escriba un "triángulo" formado por esa letra, que tenga como anchura inicial la que se
        ha indicado. Por ejemplo, si la letra es * y la anchura es 4, debería escribir
        ****
        ***
        **
        *
        */

        
        /*public static void Triangulo(String letra, int numero)
        {
            for (int i = numero; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(letra);
                }
                Console.WriteLine();
                
            }
        }
        static void Main(string[] args)
        {
            Triangulo("a", 6);          
        }
        
    }
}*/






