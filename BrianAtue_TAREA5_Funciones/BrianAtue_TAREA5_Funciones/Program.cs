using System;

namespace BrianAtue_TAREA5_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;
            int suma(int numero1, int numero2)
            {
                int suma = numero1 + numero2;
                return suma;
            }

            Console.Write("ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese un numero: ");
            num2 = int.Parse(Console.ReadLine());

            resultado = suma(num1, num2);

            Console.WriteLine("el resultado de la suma es: " + resultado);

        }
    }
}
