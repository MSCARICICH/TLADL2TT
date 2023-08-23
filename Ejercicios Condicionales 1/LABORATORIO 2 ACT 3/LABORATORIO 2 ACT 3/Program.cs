using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_2_ACT_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string cadena1, cadena2;
            int lado;
            Console.Write("Ingresar lado del cuadrado: ");
            cadena1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\t¿Que desea hacer?");
            Console.WriteLine("\n\t1 = Calcular Perimetro del cuadrado.");
            Console.WriteLine("\n\t2 = Calcular Area del cuadrado.");
            Console.Write("\nOpcion: ");
            cadena2 = Console.ReadLine();
            if (int.TryParse(cadena1, out lado)!= false)
            {
                if(cadena2 == "1")
                {
                    lado = lado * 4;
                    Console.Clear();
                    Console.WriteLine($"\n\tEl perimetro del cuadrado es: {lado} cm", Console.ForegroundColor = ConsoleColor.Yellow);
                }
                else
                {
                    if(cadena2 == "2")
                    {
                        lado = lado * lado;
                        Console.Clear();
                        Console.WriteLine($"\n\tEl area del cuadrado es: {lado} cm2", Console.ForegroundColor = ConsoleColor.Cyan);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
