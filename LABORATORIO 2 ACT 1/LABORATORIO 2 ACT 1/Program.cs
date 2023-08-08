using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_2_ACT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string cadena1;
            int nota;
            Console.Write("Ingresar nota de alumno: ");
            cadena1 = Console.ReadLine();
            if (int.TryParse(cadena1, out nota)!=false)
            {
                if(nota>6)
                {
                    Console.Clear();
                    Console.WriteLine("\n\tEste alumno esta aprobado :)", Console.ForegroundColor=ConsoleColor.Green);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\tEste alumno esta desaprobado :(", Console.ForegroundColor = ConsoleColor.Red);
                }
            }
            Console.ReadKey();
        }
    }
}
