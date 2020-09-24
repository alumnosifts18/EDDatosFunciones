using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PatricioBelinSarmiento_TAREA5
{       /*Crea una función llamada "Signo", que reciba un número real, 
         * y devuelva un número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.*/
    /*class Program
    {
        static void Main(string[] args)

        {
            Signo(2);   /*llamamos a la funcion agregandole un número como parametro
            Console.ReadLine();
        }

        public static void Signo(int num)
        {
            if (num < 0)
                Console.WriteLine("-1");
            if (num > 0)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
    }*/
}
/* ejercicio 2 
class Program
{
    static void Main(string[] args)
    {
        Menor(2, 7);   /*llamamos a la funcion agregandole dos números como parametro
        Console.ReadLine();
    }
    public static void Menor(int num1, int num2)
    {
        if (num1 < num2)
            Console.WriteLine(num1);
       else
            Console.WriteLine(num2); 
    }
}
//ejercicio 3
class Program
{
    static void Main(string[] args)

    {
        
        
        EsPrimo(2); 
        Console.ReadLine();
    }

    public static  Boolean EsPrimo(int numero)    
{

        int a = 0;

        for (int i = 1; i < (numero + 1); i++)
        {
            if (numero % i == 0)
            {
                a++;
            }
        }
        if (a != 2)
        {
        Console.WriteLine(numero + " No es primo");
            return false;
        }
        else
        {
            Console.WriteLine(numero + " Si es primo");
            return true;
        }
        
    }
}
//ejercicio 4
class program
{
static void Main(string[] args)
{
    Console.Clear();
//dibujo de cada linea (bucle externo)
for (int fila=1; fila <= 7; fila++) //este bucle genera las filas que tendra la salida de este programa
                                    // al ponerle como parametro fila <= 7, el dibujo tendra 6 filas
    {
        //dibuja espacios en blanco (1er bucle interno)
        for (int espacios = 7 - fila; espacios > 0; espacios--)// este bucle claramente genera espacios gracias a que la
                                                               // variable 'espacio' se inicializa en el valor (7 - fila) creando cinco espacios
            // dibuja estrellas (2do bucle interno)
        for (int conta = 1; conta < (2 * fila); conta++)
                Console.Write("*");
        Console.WriteLine(" ");


    }
    Console.ReadLine();
}

//ejercico 5
class Program
{
    static void Main(string[] args)

    {
        Calcula(20,'/',5);   
        Console.ReadLine();
    }

    public static void Calcula(int num1, char operador, int num2)
    {
        if (operador == '+')
        {
            Console.WriteLine(num1 + num2);
            Console.ReadLine();
        }
        if (operador == '*')
        {
            Console.WriteLine(num1 * num2);
            Console.ReadLine();
        }
        if (operador == '-')
        {
            Console.WriteLine(num1 - num2);
            Console.ReadLine();
        }
        if (operador == '/')
        {
            Console.WriteLine(num1 / num2);
            Console.ReadLine();
        }
    }
 //ejercico 6    
class Program
    {
        static void Main(string[] args)

        {
            SumaCifras(3456);
            
            Console.ReadLine();
        }
        public static void SumaCifras(int numero)
    {
        int suma=0;
        while (numero != 0)
        {
            suma += numero % 10;
            numero /= 10;
        }
        Console.WriteLine(suma);
    }
    }*/
    



