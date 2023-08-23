using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_2_ACT_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string cadena1;
            int num1;
            Console.Write("Ingresar un numero: ");
            cadena1 = Console.ReadLine();
            if(int.TryParse(cadena1, out num1)!=false)
            {
                if(num1%2==0)
                {
                    Console.Clear();
                    Console.WriteLine("\n\tEl numero ingresado es par.", Console.ForegroundColor = ConsoleColor.Green);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\tEl numero ingresado es impar.", Console.ForegroundColor = ConsoleColor.Red);
                }
            }
            Console.ReadKey();
        }
    }
}
