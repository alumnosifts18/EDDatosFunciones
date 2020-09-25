using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedericoOjeda_TAREA5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Tarea 1: Crea una función llamada "Signo", que reciba un número real, 
            y devuelva un número entero con el valor: 
            -1 si el número es negativo, 1 si es positivo o 0 si es cero.
            */

            /*
            int Signo(int param)
            {
                if (param < 0)
                {
                    return -1;
                }
                else
                    if (param == 0)
                {
                    return 0;
                }
                else
                    return 1;
            }
            int num, resultado;
            Console.WriteLine("Ingrese un número real:");
            num = Convert.ToInt32(Console.ReadLine());
            resultado = Signo(num);
            Console.WriteLine(resultado);
            Console.ReadKey();
            */

            /*
            Tarea 2: Crea una función "Menor" que calcule el menor de dos números enteros 
            que recibirá como parámetros. 
            El resultado será otro número entero.
            */

            /*
            int Menor(int param1, int param2)
            {
                if (param1 < param2)
                {
                    return 5;
                }
                else
                    return 8;

            }
            int num1, num2, resultado;
            Console.WriteLine("Ingrese un número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            num2 = Convert.ToInt32(Console.ReadLine());
            resultado = Menor(num1, num2);
            Console.WriteLine(resultado);
            Console.ReadKey();
            */

            /*
            Tarea 3: Crea una función "EsPrimo", que reciba un número y 
            devuelva el valor booleano "true" si es un número primo o 
            "false" en caso contrario.
            */

            /*
            bool EsPrimo(int param)
            {
                if (param == 2 || param % 2 != 0 && param != 1)
                    return true;
                else
                    return false;
            }
            int num;
            Console.WriteLine("Ingrese un número");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EsPrimo(num));
            Console.ReadKey();
            */

            /*
            Tarea 4: Analice el código ¿Qué hace este código? 
            Realizar captura de pantalla del código con su resultado 
            y análisis del mismo.
            */

            /*
            for (int fila=1;fila<=7;fila++)
            {
                
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write("");//espai en blanc

                
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("*");

                Console.WriteLine("");
            }
            Console.ReadKey();
            */


            /*
            Tarea 5: Crea una calculadora básica, llamada "calcula", 
            que deberá sumar, restar, multiplicar o dividir los dos números que se le indiquen 
            como parámetros. Ejemplos de su uso sería "calcula 2 + 3" o "calcula 5 * 60". 
            (Utilice Funciones)
            */


            /*
            double num1, num2;
            string opcion, eleccion;


            double Sumar(double v1, double v2)
            {
                return v1 + v2;
            }
            double Restar(double v1, double v2)
            {
                return v1 - v2;
            }
            double Multiplicar(double v1, double v2)
            {
                return v1 * v2;
            }
            double Dividir(double v1, double v2)
            {
                return v1 / v2;
            }
            string calcula(string op)
            {
                if (op == "Suma")
                {
                    double os = Sumar(num1, num2);
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, os);


                }
                if (op == "Resta")
                {
                    double or = Restar(num1, num2);
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, or);


                }
                if (op == "Multiplicación")
                {
                    double om = Multiplicar(num1, num2);
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, om);


                }
                if (op == "División")
                {
                    double od = Dividir(num1, num2);
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, od);

                }
                return op;
            }
            Console.WriteLine("Ingrese la operación a realizar:");
            opcion = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese el primer valor:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor:");
            num2 = Convert.ToDouble(Console.ReadLine());
            eleccion = calcula(opcion);
            Console.ReadKey();
            */


            /*
            Tarea 6: Crea una función "SumaCifras",que reciba un numero cualquiera y que
            devuelva como resultado la suma de sus dígitos.Por ejemplo, si el número fuera 123 la
            suma sería 6.
            */
        }
    
    }
}
