using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Analizar();

            Console.WriteLine(Signo(54645));
            Console.WriteLine(Signo(0));
            Console.WriteLine(Signo(-56747894));

            Console.WriteLine(Menor(32,54));

            Console.WriteLine(EsPrimo(7));

            Calcula("1+1");
            Calcula("132*51");
            Calcula("12/8");
            Calcula("45-3");

            Console.WriteLine(SumaCifras(1234));

            Triangulo('h',7);
        }

        //Tarea 1: Crea una función llamada "Signo", que reciba un número real, y devuelva un número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.

        public static int Signo(int numero)
        {
            Console.WriteLine("\n---Signo---\n");
            return MathF.Sign(numero);
        }

        //Tarea 2: Crea una función "Menor" que calcule el menor de dos números enteros que recibirá como parámetros. El resultado será otro número entero.

        public static int Menor(int num1,int num2)
        {
            Console.WriteLine("\n---Menor---\n");
            if (num1 > num2)
                return num2;
            else
                return num1;
        }

        //Tarea 3: Crea una función "EsPrimo", que reciba un número y devuelva el valor booleano "true" si es un número primo o "false" en caso contrario.

        public static bool EsPrimo(int numero)
        {
            Console.WriteLine("\n---EsPrimo---\n");
            int factorial = 1;
            for (int i = 1; i <= numero-1; i++)
            {
                factorial *= i;
            }
            //Console.WriteLine(factorial);
            return (factorial + 1) % numero == 0;
        }

        //Tarea 4: Analice el código ¿Qué hace este código? Realizar captura de pantalla del código con su resultado y análisis del mismo.
      
        public static void Analizar()
        {
            Console.Clear();
            Console.WriteLine("\n---Analizar---");

            for (int fila = 1; fila <= 7; fila++)
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write(" ");

                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("*");
                
                Console.WriteLine(" ");
                
            }
        }

        /*
         El código dibuja una pirámide de asteriscos, Dibujando espacios en blanco dependiendo del numero de fila actual y luego los asteriscos q formaran la piramide.
         Por cada fila disminuye el numero de espacios y aumenta el de asteriscos cuanto mas cerca se esta de la base de la piramide.
             */

        //Tarea 5: Crea una calculadora básica, llamada "calcula", que deberá sumar, restar, multiplicar o dividir los dos números que se le indiquen como parámetros. Ejemplos de su uso sería "calcula 2 + 3" o "calcula 5 * 60". (Utilice Funciones)

        public static int Calcula(string operacion)
        {
            Console.WriteLine("\n---Calculadora---\n");
            int num1 = 0; 
            int num2 =0;

            string val = "";
            bool num1encontrado = false;

            foreach(char c in operacion)
            {
                if (c != ' '||c != '+'|| c != '-' || c != '*' || c!='/')
                {
                    val += c;

                    if (!num1encontrado)
                    {
                        num1 = Int32.Parse(val);
                        num1encontrado = true;
                        val = "";
                    }
                    else
                        Int32.TryParse(val,out num2);
                }
            }

            if (operacion.Contains("*"))
                return num1 * num2;

            if (operacion.Contains("+"))
                return num1 + num2;

            if (operacion.Contains("-"))
                return num1 - num2;

            if (operacion.Contains("/"))
                return num1 / num2;

            return 0;
        }

        //Tarea 6: Crea una función "SumaCifras" que reciba un numero cualquiera y que devuelva como resultado la suma de sus dígitos.Por ejemplo, si el número fuera 123 la suma sería 6.

        public static int SumaCifras(int numero)
        {
            Console.WriteLine("\n---SumaCifras---\n");

            int suma = 0;

            while (numero != 0) 
            {
                suma += numero % 10;
                numero /= 10;
                
            }
            return suma;
        }

        /*Tarea 7(Opcional): Crea una función "Triángulo" que reciba una letra y un número, y escriba un "triángulo" formado por esa letra, que tenga como anchura inicial la que se ha indicado.Por ejemplo, si la letra es* y la anchura es 4, debería escribir
        ****
        ***
        **
        *                           */
        public static void Triangulo(char letra,int numero)
        {
            Console.WriteLine("\n---Triangulo---\n");
            while(numero!=0)
            {
                for (int i = 0; i < numero; i++)
                {
                    Console.Write(letra);
                }
                --numero;
                Console.WriteLine("\r");
            }
        }
        
    }

}