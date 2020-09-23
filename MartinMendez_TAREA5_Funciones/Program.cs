using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaMartinMendez
{
    class Program
    {
        //Tarea 1: Crea una función llamada "Signo", que reciba un número real, 
        //y devuelva un número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.

        public static int Signo(float n)
        {
            if (n > 0)
                return 1;
            else
                if (n < 0)
                return -1;
            else
                return 0;
        }

        //Tarea 2: Crea una función “Menor” que calcule el menor de dos números enteros que
        //recibirá como parámetros.El resultado será otro número entero.

        public static int Menor(int n1, int n2)
        {
            if (n1 > n2)
                return n2;
            else
                if (n1 < n2)
                return n1;
            else
                return 0;
        }

        //Tarea 3: Crea una función “EsPrimo”, que reciba un número y devuelva el valor
        //booleano “true” si es un número primo o “false” en caso contrario.

        public static bool EsPrimo(int n)
        {
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)

                    return false;
            }
            return true;
        }


        //Tarea 5: Crea una calculadora básica, llamada “calcula”, que deberá sumar, restar,
        //multiplicar o dividir los dos números que se le indiquen como parámetros. Ejemplos de
        //su uso sería “calcula 2 + 3” o “calcula 5 * 60”. (Utilice Funciones)



        public static void calcula(int numero1, int numero2, string operador)
        {
            switch (operador)
            {
                case "+":
                    Console.WriteLine(numero1 + numero2);
                    break;
                case "-":
                    Console.WriteLine(numero1 - numero2);
                    break;
                case "*":
                    Console.WriteLine(numero1 * numero2);
                    break;
                case "%":
                    Console.WriteLine(numero1 / numero2);
                    break;
            }
        }

        //Tarea 6: Crea una función “SumaCifras” que reciba un numero cualquiera y que
        //devuelva como resultado la suma de sus dígitos.Por ejemplo, si el número fuera 123 la
        //suma sería 6.

        public static int SumarCifras(string numero)
        {
            int suma = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                int cifra = Convert.ToInt32(numero.Substring(i, 1));
                suma += cifra;
            }


            return suma;

        }

        //Tarea 7 (Opcional): Crea una función "Triángulo" que reciba una letra y un número, y escriba un "triángulo" formado por esa letra, que tenga como anchura inicial la que se ha indicado.Por ejemplo, si la letra es* y la anchura es 4, debería escribir 
        //**** 
        //*** 
        //** 
        //*

        public static void Triangulo(int numero, string letra)
        {
            while (numero > 0)
            {
                for (int i = 1; i <= numero; i++)
                {
                    Console.Write(letra);
                }
                Console.WriteLine();
                numero--;
            }

        }
    static void Main(string[] args)
        {
            int suma_total = SumarCifras("248");
            Console.WriteLine(suma_total);
            Console.ReadLine();
        }
    }
}
