using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanIgnacioRuiz_Tarea5
{
    class Program
    {
        //funcione ejercicio 5 calculadoras


        public static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public static int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        public static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        public static int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
        //Finalizo las funciones de la calculadora basica punto 5




        //funciones ejercicio 6


        public static int SumaCifra(string numeroEntrada)
        {
            int resultado = 0;
            int cifra;
            for (int i = 0; i < numeroEntrada.Length; i++)
            {

                cifra = Convert.ToInt32(numeroEntrada.Substring(i, 1));
                resultado += cifra;
            }
            return resultado;
        }
        //cierro funciones ejercicio 6





        //Funciones ejercicio 7


        public static char Triangulo(char letra, int anchura)
        {

            for (int i = anchura; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(letra);
                }
                for (int c = anchura; c < i; c++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine();//agrega uno abajo de otro, osea cuando pone una fila de la letra,vagrega uno menos abajo cada iteracion del 1er for
            }
            return letra;


        }

        static void Main(string[] args)
        {






            //---------------------***EJERCICIOS***----------------------------------------
            //EJERCICIO 1

            int nro;

            int Signo(int numero)
            {
                if (numero > 0)
                    return 1;
                if (numero < 0)
                    return -1;
                else
                    return 0;
            }
            Console.WriteLine("ingrese un numero");
            nro = int.Parse(Console.ReadLine());

            Console.WriteLine(Signo(nro));





            //EJERCICIO 2

            int nro1;
            int nro2;
            int resultado;
            int Menor(int numero1, int numero2)
            {
                if (numero1 < numero2)
                    return numero1;
                else
                    return numero2;
            }

            Console.WriteLine("ingrese dos numero");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());
            resultado = Menor(nro1, nro2);
            Console.WriteLine("el menor es {0} ", resultado);




            //Ejercicio 3

            int nro;
            bool resultado;
            Boolean esPrimo(int numero)
            {
                int a = 0;
                for (int i = 1; i < (numero + 1); i++)
                {
                    if (numero % i == 0)
                        a++;

                }
                if (a != 2)
                    return false;
                else
                    return true;

            }
            Console.WriteLine("ingrese un numero ");
            nro = int.Parse(Console.ReadLine());
            resultado = esPrimo(nro);
            if (resultado)
            {
                Console.WriteLine("es primo");
            }
            {
                Console.WriteLine("no es primo");
            }







            //EJERCICIO 4
            //ESTE FRAGMENTO DE CODIGO FORMA UN TRIANGULO
            Console.Clear();//limpia la consola
            //DIBUJO DE CADA LINEA (BUCLE EXTERNO).
            for (int fila = 1; fila <= 7; fila++)//por cada fila que va a dibujar, mientras //que el numero de fila sea menor o igual a 7, va a sumar una fila a dibujar
            {
                //DIBUJA ESPACIOS EN BLANCO (1ER BUCLE INTERNO)
                for (int espacios = 7 - fila; espacios > 0; espacios--)//por cada espacio //que quiero dibujar, que van a ser 7, menos la cantidad de filas, que se iran creciendo  																//en cada bucle , 
                                                                       // si cada uno de //estos espacios es mayor a 0, hacer que los espacios vayan disminuyendo 
                                                                       //su cantidad, //para darle la forma de triangulo.
                {
                    Console.Write(" ");//espacio en blanco que va a ir corriendo la //estrellita al medio,
                                       //a medida que avanza, ese espacio va //disminuyendo

                }
                //dibuja estrellas (2do BUCLE INTERNO)
                for (int conta = 1; conta < (2 * fila); conta++)//aca conta representa //su contador de estrellas, mientras contador sea menor que el doble de las filas,las //vas va a ir sumando 
                {
                    Console.Write("*");

                }
                Console.WriteLine(" ");//espacio del otro lado 
            }
            Console.ReadKey();







            //EJERCICIO 5 Calculadora 

            int num1, num2, resultado;
            string operador;
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese operador");
            operador = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    Console.WriteLine("la suma de {0} y {1} es {2}", num1, num2, Sumar(num1, num2));
                    break;
                case "-":
                    Console.WriteLine("la resta de {0} y {1} es {2}", num1, num2, Restar(num1, num2));
                    break;
                case "*":
                    Console.WriteLine("la multiplicacion de {0} y {1} es {2}", num1, num2, Multiplicar(num1, num2));
                    break;
                case "/":
                    Console.WriteLine("la division de {0} y {1} es {2}", num1, num2, Dividir(num1, num2));
                    break;
                default:

                    break;
            }






            //Ejercicio 6


            string numero;
            Console.WriteLine("Ingrese el numero de las cifras que quiera");
            numero = Console.ReadLine();
            Console.WriteLine("la suma de {0} es {1}", numero, SumaCifra(numero));




            //Ejercicio 7

            char caracter;
            int cantidad;


            Console.WriteLine("Ingrese el caracter que desée: ");
            caracter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ahora ingresa la cantidad de iteraciones:  ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Triangulo(caracter, cantidad));

        }

    }
}
