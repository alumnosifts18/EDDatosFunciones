using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace PRACTICA_CLASE4
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            /*
            float resultado;
            float numero = 0;
            resultado = Signo(numero);
            Console.WriteLine(resultado);
            Console.ReadKey();
            */


            //2

            /*
            int resultado2;
            int numero1 = 5;
            int numero2 = 8;
            resultado2 = Menor(numero1, numero2);
            Console.WriteLine(resultado2);
            Console.ReadKey();
            */


            //3

            /*
            bool resultado3;
            int numero1 = 24;
            resultado3 = EsPrimo(numero1);
            Console.WriteLine(resultado3);
            Console.ReadKey();
            */


            //4


            // Tarea 4: Analice el código ¿Qué hace este código? Realizar captura de pantalla del
            //código con su resultado y análisis del mismo.


            /*
             
                Console.Clear();

            //dibujo de cada linea (bucle externo)

            for (int fila =1; fila <=7; fila++)
            {
                //dibuja espacios en blanco (1er bucle interno)
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write(" "); //espai en blanc

                //dibuja estrellas (2do bucle interno)
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("*");

                Console.WriteLine(" ");
            }

            Console.ReadKey();  // Se ve un triangulo de 7 pisos de estrellitas

            */

            //5

            /*
            int numero1 = 100;
            int numero2 = 50;

            Calcula(numero1, numero2);
            Console.ReadKey();

            */


            //6

            int resultado = SumaCifras("136");
            Console.WriteLine(resultado);
            Console.ReadKey();



            //7
            /*
            int n;
            string x;

            Console.WriteLine("Ingrese un numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese una letra: ");
            x = Console.ReadLine();

            Triangulo(n,x);
            Console.ReadKey();
            */



        }
        // CLASE 12sept

        // Tarea 1: Crea una función llamada &quot;Signo&quot;, que reciba un número real, y devuelva un
        //número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.

        public static float Signo(float nreal)
        {
            if (nreal < 0)
            {
                return -1;
            }
            if (nreal > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //Tarea 2: Crea una función &quot;Menor&quot; que calcule el menor de dos números enteros que recibirá como parámetros.El resultado será otro número entero.

        public static int Menor(int n1, int n2)
        {

            if (n1 < n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        // Tarea 3: Crea una función &quot;EsPrimo&quot;, que reciba un número y devuelva el valor booleano &quot;true&quot; si es un número primo o &quot;false&quot; en caso contrario.
        static bool EsPrimo(int n)
        {

            if (n == 2)
            {
                return true;
            }
            if (n == 1)
            {
                return false;

            }
            else
            {

                int i;
                for (i = 2; i < n;) //si pongo 1++ me rita error

                    if (n % i == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

            }

            return false; //si no pongo este return, me devuelve un error de  qie no todas las rutas de acceso de código devuelven un valor


        }

        // Tarea 5: Crea una calculadora básica, llamada &quot;calcula&quot;, que deberá sumar, restar, multiplicar o dividir los dos números que se le indiquen como parámetros.Ejemplos de
        //su uso sería &quot; calcula 2 + 3&quot; o &quot;calcula 5 * 60&quot;. (Utilice Funciones). 

        //NO ENTIENDO LO QUE PIDE

        static void Calcula(int n1, int n2)

        {

            int suma = n1 + n2;
            int resta = n1 - n2;
            int multiplicacion = n1 * n2;
            int division = n1 / n2;

            Console.WriteLine("Calcula {0} + {1} = {2}", n1, n2, suma);
            Console.WriteLine("Calcula {0} - {1} = {2}", n1, n2, resta);
            Console.WriteLine("Calcula {0} * {1} = {2}", n1, n2, multiplicacion);
            Console.WriteLine("Calcula {0} / {1} = {2}", n1, n2, division);

        }

        //Tarea 6: Crea una función &quot;SumaCifras&quot; que reciba un numero cualquiera y que devuelva como resultado la suma de sus dígitos.Por ejemplo, si el número fuera 123 la suma sería 6.

        
        static int SumaCifras(string n)
        {
            int resultado =0;
            int numeros;
            foreach (char cifras in n)
            {
                //Console.WriteLine(cifras);
                numeros = (int)char.GetNumericValue(cifras); //lo saque de internet para convertir un char en un int
                //Console.WriteLine(numeros);
                resultado += numeros;
                //Console.WriteLine(resultado);
            }
            return resultado;
        }
        


        //Tarea 7 (Opcional): Crea una función &quot;Triángulo&quot; que reciba una letra y un número, y escriba un &quot;triángulo&quot; formado por esa letra, que tenga como anchura inicial la que se 
        // ha indicado.Por ejemplo, si la letra es* y la anchura es 4, debería escribir

        static void Triangulo (int n, string x)
        {


            for (int fila = n; fila >= 0; fila--)
            {
                //dibuja espacios en blanco (1er bucle interno)
                for (int espacios = n - fila; espacios > 0; espacios--)
                    Console.Write(" "); //espai en blanc

                //dibuja estrellas (2do bucle interno)
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write(x);

                Console.WriteLine(" ");
            }

            Console.ReadKey();  // Se ve un triangulo de 7 pisos de estrellitas




        }

    }
}
