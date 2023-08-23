using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_2_ACT_7
{
    internal class Program
    {
        public class InvalidFormatException1: Exception
        {
            public InvalidFormatException1(string message): base(message)
            {
                Console.WriteLine(message);
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            string cadena1, cadena2, cadena3;
            int lado1, lado2, lado3;
            Console.WriteLine("Presione Cualquier tecla para continuar...");
            Console.Clear();
            Console.WriteLine("Ingresar valor del primer lado: ");
            cadena1 = Console.ReadLine();
            Console.Clear();
            try
            {
                lado1 = int.Parse(cadena1);
            }
            catch
            {
                throw new InvalidFormatException1("No se puede convertir el valor a int.");
            }
            Console.WriteLine("Ingresar valor del segundo lado: ");
            cadena2 = Console.ReadLine();
            Console.Clear();
            try
            {
                lado2 = int.Parse(cadena2);
            }
            catch
            {
                throw new InvalidFormatException1("No se puede convertir el valor a int.");
            }
            Console.WriteLine("Ingresar valor del tercer lado: ");
            cadena3 = Console.ReadLine();
            Console.Clear();
            try
            {
                lado3 = int.Parse(cadena3);
            }
            catch
            {
                throw new InvalidFormatException1("No se puede convertir el valor a int.");
            }
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("\n\tEl triangulo es de tipo Equilatero.");
            }
            else
            {
                if(lado1 == lado2 && lado3 != lado1 
                   || lado2 == lado3 && lado2 !=lado1 
                   || lado1 == lado3 && lado2 != lado1)
                {
                    Console.WriteLine("\n\tEl triangulo es de tipo Isosceles.");
                }
                else
                {
                    if(lado1 != lado2 && lado2 != lado3 && lado1!=lado3)
                    {
                        Console.WriteLine("\n\tEl triangulo es de tipo Escaleno.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
