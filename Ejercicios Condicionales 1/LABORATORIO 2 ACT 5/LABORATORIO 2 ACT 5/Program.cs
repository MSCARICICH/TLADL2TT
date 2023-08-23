using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_2_ACT_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena1, cadena2;
            int num1;
            Console.Write("Ingresar edad:  ");
            cadena1 = Console.ReadLine();
            Console.Write("Ingresar fecha (dia y mes):  ");
            cadena2 = Console.ReadLine();
            Console.Clear();
            if (int.TryParse(cadena1, out num1)!=false)
            {
                num1 = 2023-num1;
                if (num1 == 2004)
                {
                    Console.WriteLine($"\n\ttu edad es valida ya que naciste en el año {num1}", Console.ForegroundColor=ConsoleColor.Green);
                }
            }
            if (cadena2 == "26/11")
            {
                Console.WriteLine("\n\tHoy es tu cumpleaños :)", Console.ForegroundColor=ConsoleColor.Yellow);
            }
            else
            {
                Console.WriteLine("\n\tHoy no es tu cumpleaños :(", Console.ForegroundColor = ConsoleColor.Red);
            }
            Console.ReadKey();
        }
    }
}
