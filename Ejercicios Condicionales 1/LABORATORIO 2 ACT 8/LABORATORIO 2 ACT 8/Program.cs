using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_2_ACT_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            string cadena1;
            string avion = "Avion", elefante = "Elefante", iglesia = "Iglesia", octubre = "Octubre", universidad = "Universidad";
            Console.WriteLine("Presione Cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ingrese una vocal (A E I O U {MAYUS}): ");
            cadena1 = Console.ReadLine();
            switch(cadena1)
            {
                case "A":
                    {
                        Console.WriteLine($"\n\t{avion}");
                        break;
                    }
                case "E":
                    {
                        Console.WriteLine($"\n\t{elefante}");
                        break;
                    }
                case "I":
                    {
                        Console.WriteLine($"\n\t{iglesia}");
                        break;
                    }
                case "O":
                    {
                        Console.WriteLine($"\n\t{octubre}");
                        break;
                    }
                case "U":
                    {
                        Console.WriteLine($"\n\t{universidad}");
                        break;
                    } 
            }
            Console.ReadKey();
        }
    }
}
