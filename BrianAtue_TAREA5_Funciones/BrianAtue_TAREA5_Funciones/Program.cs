using System;

namespace BrianAtue_TAREA5_Funciones
{

    class Program
    {
        /*
        //Tarea 1: Crea una función llamada "Signo", que reciba un número real, y devuelva un 
        //número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.
        static void Main(string[] args)
        //bloque de codigo donde se llama a la funcion
        {
            Console.WriteLine("Escriba un numero a analizar: ");
            int num1 = int.Parse(Console.ReadLine());
            Signo(num1);
        }
        //funcion solicitada
        static void Signo(int numero)
        {
            if (numero > 0)

                Console.WriteLine("\n1");
            else
                if (numero < 0)
                Console.WriteLine("\n-1");
                else
                Console.WriteLine("\n0");

        }
        */

        /*
        //Tarea 2: Crea una función "Menor" que calcule el menor de dos números enteros que 
        //recibirá como parámetros. El resultado será otro número entero.
        static void Main(string[] args)
        //bloque de codigo donde se llama a la funcion
        {
            Console.WriteLine("Escriba el primer numero a analizar: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero a analizar: ");
            int num2 = int.Parse(Console.ReadLine());
            Menor(num1, num2);

        }
        //Funcion solicitada
        static void Menor(int numero1, int numero2)
        {
            if (numero1 > numero2)
                Console.WriteLine(numero2 + " Es el menor");
            else
                Console.WriteLine(numero1 + " Es el menor");
        }
        */

        /*
        //Tarea 3: Crea una función "EsPrimo", que reciba un número y devuelva el valor 
        //booleano "true" si es un número primo o "false" en caso contrario.

        //bloque de codigo donde se llama a la funcion
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero a analizar: ");
            int num1 = int.Parse(Console.ReadLine());
            EsPrimo(num1);

        }
        //funcion pedida
        static void EsPrimo(int numero)
        {
            int contador = 2;
            Boolean primo = true;
            while ((primo) && (contador != numero))
            {
                if (numero % contador == 0)
                    primo = false;
                contador++;
            }
            Console.WriteLine(primo);
        }
        */

        /*
        //Tarea 4: Analice el código ¿Qué hace este código? Realizar captura de pantalla del 
        //código con su resultado y análisis del mismo.
        static void Main(string[] args)
        {
            Console.Clear();
            //dibujo de cada linea (bucle externo)
            for (int fila = 1; fila <= 7; fila++)
            {
                //dibuja espacios en blanco (1er bucle interno)
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write(" ");// espai en blanc

                //dibuja estrellas (2° bucle interno)
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("*");

                Console.Write(" ");
            }
        }
        */
        /*
        // Tarea 5: Crea una calculadora básica, llamada "calcula", que deberá sumar, restar, 
        // multiplicar o dividir los dos números que se le indiquen como parámetros. 
        // Ejemplos de su uso sería "calcula 2 + 3" o "calcula 5 * 60". 
        // (Utilice Funciones)

        static int Suma(int numero1, int numero2)//funcion sumar
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
        static int Resta(int numero1, int numero2)//funcion restar
        {
            int resultado = numero1 - numero2;
            return resultado;
        }
        static int Multiplicacion(int numero1, int numero2)//funcion multiplicar
        {
            int resultado = numero1 * numero2;
            return resultado;
        }
        static float Division(int numero1, int numero2)//funcion dividir
        {
            float resultado = numero1 / numero2;
            return resultado;
        }

        static void Main(string[] args)//programa de calculadora
        {
            Console.WriteLine("Elija una operación a realizar");
            Console.WriteLine("Aprete:\n1 para sumar\n2 para restar\n3 para multiplicar\n4 para dividir");
            int operacion = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el primer numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            float respuesta;

            switch (operacion)//switch que llama a las diferentes funciones segun el 
                              //usuario lo halla elegido
            {
                case 1: 
                    respuesta = Suma(num1, num2);
                    Console.WriteLine("el resultado es: " + respuesta);
                    break;
                case 2:
                    respuesta = Resta(num1, num2);
                    Console.WriteLine("el resultado es: " + respuesta);
                    break;
                case 3:
                    respuesta = Multiplicacion(num1, num2);
                    Console.WriteLine("el resultado es: " + respuesta);
                    break;
                case 4:
                    respuesta = Division(num1, num2);
                    Console.WriteLine("el resultado es: " + respuesta);
                    break;
            }
        }
        */

        /*
        //Tarea 6: Crea una función "SumaCifras" que reciba un numero cualquiera y que
        //devuelva como resultado la suma de sus dígitos. Por ejemplo, si el número fuera 123 la
        //suma sería 6.
        //https://www.youtube.com/watch?v=Pz37A6BQqJk
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero que desea sumar sus cifras");
            int num1 = int.Parse(Console.ReadLine());
            int resultado = SumaCifras(num1);

            Console.WriteLine("la suma de las cifras son: " + resultado);
        }

        static int SumaCifras(int numero)
        {
            if (numero < 10)
            {
                return numero;
            }
            else
            {
                return (numero % 10) + SumaCifras(numero / 10);
            }
        }
        */

        //Tarea 7 (Opcional): Crea una función "Triángulo" que reciba una letra y un número, y 
        //escriba un "triángulo" formado por esa letra, que tenga como anchura inicial la que se 
        //ha indicado. Por ejemplo, si la letra es * y la anchura es 4, debería escribir 
        //****
        //***
        //**
        //*
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la letra que decida: ");
            string let = Console.ReadLine();
            Console.WriteLine("ingrese el numero para repetir la letra");
            int num = int.Parse(Console.ReadLine());


            Triangulo(let, num);
        }

        static void Triangulo(string letra, int numero)// funcion
        {
            while (numero > 0)
            {                
               numero--;            
                for (int fila = 0; fila <= numero; fila++)
                    Console.Write(letra);// escribe letra 
                    Console.Write("\n");// salto de linea
            }

        }
        */
    }
}
