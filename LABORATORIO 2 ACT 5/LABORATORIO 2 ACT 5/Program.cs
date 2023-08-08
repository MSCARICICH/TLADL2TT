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
            int num1 = 2004;
            Console.Write("Ingresar edad:  ");
            cadena1 = Console.ReadLine();
            Console.Write("Ingresar fecha (dia y mes):  ");
            cadena2 = Console.ReadLine();
            if(cadena1)
            if (cadena2 == "26/11")
            {
                Console.WriteLine("Hoy es tu cumpleaños :)");
            }
            else
            {
                Console.WriteLine("Hoy no es tu cumpleaños :(");
            }
            Console.ReadKey();
        }
    }
}
