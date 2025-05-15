using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sem08_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animar();
            Calculadora();
        }
        static void Animar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("░░▒▓│la calculadora iniciara en...░░▒▓│");
            Console.Beep(600, 700);
            Thread.Sleep(400);
            Console.Clear();//limpia la consola
            Console.WriteLine("░░▒▓│3░░▒▓│");//alt+176+177+178
            Console.Beep(600, 700);
            Thread.Sleep(400);
            Console.Clear();//limpia la consola
            Console.WriteLine("░░▒▓│2░░▒▓│");
            Console.Beep(600, 700);
            Thread.Sleep(400);
            Console.Clear();//limpia la consola
            Console.WriteLine("░░▒▓│1░░▒▓│");
            Console.Beep(1200, 900);
            Thread.Sleep(1000);
            Console.Clear();//limpia la consola
            Console.ResetColor();
        }
        static void Calculadora()
        {
            int opcion;
            do
            {
                Console.Clear(); //limpiar los valores de la consola
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("0. Salir");
                opcion = int.Parse(Console.ReadLine());//opcion 1
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("saliendo...");
                        break;
                    case 1: //sumar
                        Sumar();
                        break;
                    case 2:
                        Console.WriteLine("ingrese el numero 1: ");
                        float n1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el numero 2: ");
                        float n2 = float.Parse(Console.ReadLine());
                        resta(n1, n2);
                        break;
                    case 3://multiplicar
                        Console.WriteLine("ingrese el numero 1: ");
                        float m1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el numero 2: ");
                        float m2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("La multiplicacion es: " + multiplicar(m1, m2));
                        break;
                    case 4:
                        dividir();
                        Console.WriteLine("dividir");//dividir
                        break;
                    default: Console.WriteLine("opcion no valida");//opcion no valida
                        break;
                }
                Console.ReadKey();
            } while (opcion != 0);//true false
        }
        static void Sumar()
        {
            Console.WriteLine("ingrese el numero 1: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 2: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("la suma es: " + (n1 + n2));

        }
        static void resta(float num1, float num2) //argumento-parametros
        {
            float resultado = num1 - num2;
            Console.WriteLine("La resta es: " + resultado);
        }
        static float multiplicar (float n1, float n2)
        {
            float resultado = n1 * n2;
            return resultado;   
        }
        static float dividir()
        {
            Console.WriteLine("ingrese el numero 1: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 2: ");
            float n2 = float.Parse(Console.ReadLine());
            if (verificar(n2))
            {
                float resultado = n1 / n2; //12 / 0
                return resultado;
            }
            else
            {
                Console.WriteLine("No es divisible entre 0");
                return 0;
            }
        }
        static bool verificar(float n2)
        {
            if (n2 == 0) { 
            return false;   //no es divisible
            }
            else
            {
                return true;    //si es divisible
            }
        }
    }
}

