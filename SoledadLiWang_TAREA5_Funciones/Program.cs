using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoledadLiWang_TAREA5_Funciones
{
    class Program
    {
        public static void Signo(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("-1");
            }
            else if (a == 0)
            {
                Console.WriteLine("0");
            } else if (a > 0)
            {
                Console.WriteLine("1");
            }
        }
        public static void Menor(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine(a + " es menor");

            }
            else
            {
                Console.WriteLine(b + " es menor");
            }
        }
        public static bool EsPrimo(int i)
        {
            if (i < 0)
            {
                Console.WriteLine("El valor debe ser positivo");
            }
            if (i <= 3)
            {
                return true;
            }
            else
            {
                for (int x = 2; x <= i - 1; x++)
                {
                    if (i % x == 0)
                        return false;
                }
                return true;
            }

        }
        public static void Calcula(int a, int b)
        {
            string operacion = Console.ReadLine();
            string eleccion = Convert.ToString(operacion);
            int resultado;

            switch (eleccion)
            {
                case "+":
                    Console.WriteLine("El resultado de la suma es:");
                    resultado = a + b;
                    Console.WriteLine("{0} + {1} = {2}", a, b, resultado);
                    break;

                case "-":
                    Console.WriteLine("El resultado de la resta es:");
                    resultado = a - b;
                    Console.WriteLine("{0} - {1} = {2}", a, b, resultado);
                    break;

                case "*":
                    Console.WriteLine("El resultado de la multiplicacion es:");
                    resultado = a * b;
                    Console.WriteLine("{0} * {1} = {2}", a, b, resultado);
                    break;

                case "/":
                    Console.WriteLine("El resultado de la division es:");
                    resultado = a / b;
                    Console.WriteLine("{0} / {1} = {2}", a, b, resultado);
                    break;
            }

        }
        public static void SumaCifras()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
        public static void ejercicio4()
        {
            Console.Clear();

            //dibujo de cada linea (bucle externo)
            for(int fila = 1; fila <=7; fila++)
            {
                //dibujo espacios en blanco (1er bucle interno)
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write(" ");
                //dibuja estrellas (2do bucle interno)
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.WriteLine("*");

                Console.WriteLine(" ");
            }
        }
        public static void Main()
        {
            //1
            Console.WriteLine("Ingrese un numero por favor:");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            Signo(x);
            //2
            Console.WriteLine("Ingrese dos numeros para ver cual es el menor");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Menor(a, b);
            //3
            Console.WriteLine("Ingrese un numero para ver si es primo o no");
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            EsPrimo(i);
            
            //5
            Console.WriteLine("Ingrese los numeros que quiere utilizar");
            int z, j;
            z = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la operacion que quiere realizar");
            Calcula(z, j);
            //6
            Console.WriteLine("Ingrese numero para sumar sus cifras");
            SumaCifras();

        }
    }
    


  
}

