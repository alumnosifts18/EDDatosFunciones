using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NakasoneFlorencia_Tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios Funciones");


            /* Crea una función llamada 'Signo', que reciba un número real, y devuelva un
    número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.*/
            /*
            int numero;
            int Signo(int num)
            {
                if (num < 0) 
                {
                    return -1;
                }else if(num > 0){
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine(Signo(numero));
            
            */


            /* Crea una función 'Menor' que calcule el menor de dos números enteros que
       recibirá como parámetros. El resultado será otro número entero.*/

            /*
            //defino variable para mostrar resultado
            int resultado;
            //defini funcion y pasamos los parametros
            int Menor(int param1, int param2)
            {
                if(param1 < param2)
                {
                    return param1;

                }
                else
                {
                    return param2;
                }
            }

            int nro1, nro2;
            Console.WriteLine("Ingrese los numeros");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());

            //guardamos lo que retorne en una variable
            resultado = Menor(nro1, nro2);

            //harcodeamos valores
            //resultado = Menor(10, 20);

            Console.WriteLine($"El menor de los dos numeros es {resultado}", resultado);
            */




            /* Crea una función "EsPrimo", que reciba un número y devuelva el valor
    booleano "true" si es un número primo "false" en caso contrario.*/


            /*
            int numero;

            bool EsPrimo(int numero)
            {
                for (int i = 2; i < numero; i++)
                {
                    if ((numero % i) == 0)
                    {
                        // No es primo
                        return false;
                    }
                }

                // Es primo
                return true;
            }
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine(EsPrimo(numero));
            */




            /* Analice el código ¿Qué hace este código? Realizar captura de pantalla del
       código con su resultado y análisis del mismo.*/

            /*
                Console.Clear();

            //dibujo de cada linea (bucle externo)
            //en el rango de 1 a 7, va a recorrer una linea
            for (int fila = 1; fila <= 7; fila++)
            {
                //dibuja espacios en blanco(1er bucle)
                //de 7 espacios, le resta el valor del nro de fila, mientras sea > 0, se decrementa en 1 el siguiente.
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write(" "); //espacio en blanco

                //dibuja estrellas (2do bucle interno)
                //con el contador iniciando en uno, mientras conta sea menor al doble del valor de la fila, incrementa en 1 el siguiente
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("*");

                Console.WriteLine(" ");//agrega espacio en blanco
            }

            */


            /* Crea una calculadora básica, llamada "calcula", que deberá sumar, restar,
    multiplicar o dividir los dos números que se le indiquen como parámetros. Ejemplos de
    su uso sería "calcula 2 + 3" o "calcula 5 * 60". (Utilice Funciones)*/

            /*

                //creamos una funcion para cada operacion y que nos retorne el resultado
                static int suma(int num1, int num2)
                {
                    int suma = num1 + num2;
                    return suma;
                }
                static int resta(int num1, int num2)
                {
                    int resta = num1 - num2;
                    return resta;
                }
                static int multiplicacion(int num1, int num2)
                {
                    int multiplicacion = num1 * num2;
                    return multiplicacion;
                }
                static int division(int num1, int num2)
                {
                    int division = num1 / num2;
                    return division;
                }

                //declaramos variables y le pedimos valores al usuario
                int num1, num2;
                Console.Write("Introduce el 1er número: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Introduce el 2do número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("\n" + "Seleccione una opción del 1 al 5: " + "\n");
                Console.Write("\n" + "1 - Suma" + "\n" + "2 - Resta" + "\n" + "3 - Multiplicación" + "\n" + "4 - División" + "\n" + "5 - Salir del Programa" + "\n");

                switch (Console.Read())

                {
                    case '1':
                        Console.Write("\n" + "Suma = " + suma(num1, num2));
                        break;

                    case '2':
                        Console.Write("\n" + "Resta = " + resta(num1, num2));
                        break;

                    case '3':
                        Console.Write("\n" + "Multiplicación = " + multiplicacion(num1, num2));
                        break;

                    case '4':
                        Console.Write("\n" + "División = " + division(num1, num2));
                        break;

                    case '5':
                        Console.Write("\n" + "Fin del programa");
                        break;
                }    

                */


            /*Crea una función "SumaCifras" que reciba un numero cualquiera y que
    devuelva como resultado la suma de sus dígitos.Por ejemplo, si el número fuera 123 la
    suma sería 6.*/

            
            int numero, resultado;

            int suma = 0;


            int sumarCifras()
            {
                while (numero > 0)
                {

                    suma += numero % 10;

                    numero = numero / 10;
                }

            return suma;
   
            }

            Console.WriteLine("Introduce un número para sumar sus dígitos: ");

            numero = int.Parse(Console.ReadLine());

            resultado = sumarCifras();

            Console.WriteLine("La suma es: " + resultado);
            



            /*(Opcional): Crea una función "Triángulo" que reciba una letra y un número, y
      escriba un "triángulo" formado por esa letra, que tenga como anchura inicial la que se
          ha indicado.Por ejemplo, si la letra es * y la anchura es 4, debería escribir
            ****
            ***
            **
            *
            */

            //Console.ReadLine();
        }
    }
}

