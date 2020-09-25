using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7
{
    class Program
    {
        /*Crea una función "Triángulo" que reciba una letra y un número, y escriba un
        "triángulo" formado por esa letra, que tenga como anchura inicial la que se ha indicado. */
        public static void Triangulo(int ancho, string letra)

        {
            int cantidad = ancho;
            for (int i = ancho; i > 0; i--)
            {
                for (int j = cantidad; j > 0; j--)
                {
                    Console.Write(letra);
                }
                cantidad--;
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            int ancho=0;
            string letra;
            Console.Write("Ingresar ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresar letra: ");
            letra = Console.ReadLine();

                Triangulo(ancho, letra);
            Console.ReadKey();


        }
    }
}
