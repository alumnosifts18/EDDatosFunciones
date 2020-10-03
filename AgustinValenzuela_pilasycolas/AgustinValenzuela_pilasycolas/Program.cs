using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AgustinValenzuela_pilasycolas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa que pida al usuario 6 números enteros y luego los muestre en orden contrario,
            utilizando una pila.*/

            Stack miPila = new Stack();
            string numero;
            int valor, i;

            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = Console.ReadLine();
                valor = int.Parse(numero);
                miPila.Push(valor);
            }
            for (byte f = 0; f < 6; f++)
            {
                valor = (int)miPila.Pop();
                Console.WriteLine(valor);
            }
            Console.ReadLine();
            

            /*Crea un programa que pida al usuario 6 números reales de doble precisión, los guarde en una cola
            y luego los muestre en pantalla*/

            Queue miCola = new Queue();
            string number;
            int value, a;

            for (a = 0; a < 6; a++)
            {
                Console.WriteLine("Ingrese un numero: ");
                number = Console.ReadLine();
                value = int.Parse(number);
                miCola.Enqueue(value);
            }
            for (byte f = 0; f < 6; f++)
            {
                value = (int)miCola.Dequeue();
                Console.WriteLine(value);
            }
            Console.ReadLine();
                   
                

            /*Crea un programa que pida frases al usuario, hasta que introduzca una frase vacía. En ese
            momento, mostrará todas las frases que se habían introducido.*/

            Queue usuario = new Queue();

            String frases = "";

            do
            {
                Console.WriteLine("Ingrese una frase: ");
                frases = Console.ReadLine();
                usuario.Enqueue(frases);
            } 
            while (frases != "");

            int longitud = usuario.Count;
            for (byte b = 1; b <= longitud; b++)
            {
                Console.WriteLine((String)usuario.Dequeue());
            }
            Console.ReadLine();

            
        }
    }
}
