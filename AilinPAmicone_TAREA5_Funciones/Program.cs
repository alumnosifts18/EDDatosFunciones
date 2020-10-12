using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AilinPAmicone_TAREA5_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // EX. 1 - Crea una función llamada Signo, que reciba un número real, y devuelva 
            // un número entero con el valor: 
            // -1 si el número es negativo, 1 si es positivo o 0 si es cero.

            float Signo(float num)
            {
                if (num < 0)
                {
                    return -1;
                }
                else if (num > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            float resultado = Signo(3.45f);
            Console.WriteLine(resultado);
            Console.ReadKey();

            // EX. 2 - Crea una función "Menor" que calcule el menor de dos números enteros que 
            // recibirá como parámetros.
            // El resultado será otro número entero.

            int Menor(int num1, int num2)
            {
                if (num1 < num2)
                {
                    return num1;
                }
                else
                {
                    return num2;
                }

            }

            int prueba = Menor(2, 3);
            Console.WriteLine(prueba);
            Console.ReadKey();

            // EX. 3 - Crea una función "EsPrimo", que reciba un número y devuelva el valor 
            // booleano "true" si es un número primo o "false" en caso contrario.
            bool EsPrimo(int num)
            {
                for (int divisor = 2; divisor < num; divisor += 1)
                {
                    if (num % divisor == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            Console.WriteLine(EsPrimo(61));
            Console.ReadLine();

            // EX. 4 - Analice el código ¿Qué hace este código? Realizar captura de pantalla del 
            // código con su resultado y análisis del mismo.
            Console.Clear();
            for (int fila = 1; fila <= 7; fila++)
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write(" ");
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("*");
                Console.WriteLine(" ");
            }
            Console.ReadKey();
            // EX. 5 - Crea una calculadora básica, llamada "calcula", que deberá sumar, restar, 
            // multiplicar o dividir los dos números que se le indiquen como parámetros. 
            // Ejemplos de su uso sería "calcula 2 + 3" o "calcula 5 * 60". (Utilice Funciones)
            int Calcula(int a, int b, int c)
            {
                if (c == 1)
                {
                    return a + b;
                }
                else if (c == 2)
                {
                    return a - b;
                }
                else if (c == 3)
                {
                    return a * b;
                }
                else if (c == 4)
                {
                    return a / b;
                }
                else
                    return 0;
            }
            int total = Calcula(3, 2, 3);
            Console.WriteLine(total);
            Console.ReadKey();
            // EX. 6 - Crea una función "SumaCifras" que reciba un numero cualquiera y que 
            // devuelva como resultado la suma de sus dígitos. 
            // Por ejemplo, si el número fuera 123 la suma sería 6.
            int SumaCifras(int numero)
            {
                int Cifras = (int)Math.Floor(Math.Log10(numero) + 1);
                int suma = 0;
                for (int count = 0; count <= Cifras; count++)
                {
                    suma += (numero % 10);
                    numero /= 10;
                }
                return suma;
            }
            Console.WriteLine(SumaCifras(222));
            Console.ReadKey();

            // EX. 7 - Crea una función "Triángulo" que reciba una letra y un número, y escriba 
            // un "triángulo" formado por esa letra, que tenga como anchura inicial la que se ha 
            // indicado.

            void Triangulo(string letra, int num)
            {
                for (int i = num; i >= 0; i--)
                {
                    for (int e = 0; e < i; e++)
                    {
                        if (e == i - 1)
                        {
                            Console.WriteLine(letra);
                        }
                        else
                        {
                            Console.Write(letra);
                        }
                    }
                }
            }
            Triangulo("T", 6);
            Console.ReadKey();
        }
    }
}
