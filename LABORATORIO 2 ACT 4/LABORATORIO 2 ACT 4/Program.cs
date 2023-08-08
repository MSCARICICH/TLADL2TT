using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_2_ACT_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena1, cadena2, cadena3;
            int num1, num2, num3;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ingresar el primer numero: ");
            cadena1 = Console.ReadLine();
            Console.Clear();
            Console.Write("Ingresar el segundo numero: ");
            cadena2 = Console.ReadLine();
            Console.Clear();
            Console.Write("Ingresar el tercer numero: ");
            cadena3 = Console.ReadLine();
            Console.Clear();
            if(int.TryParse(cadena1, out num1)!=false &&  int.TryParse(cadena2,out num2)!= false && int.TryParse(cadena3,out num3)!=false)
            {
                if(num1 > num2 && num1 > num3)
                {
                    Console.WriteLine($"\n\tEl mayor es el numero 1 ({num1})", Console.ForegroundColor = ConsoleColor.Green);
                    if(num2>num3)
                    {
                        Console.WriteLine($"\n\tEl medio es el numero 2 ({num2})", Console.ForegroundColor = ConsoleColor.Yellow);
                        Console.WriteLine($"\n\tEl menor es el numero 3 ({num3})", Console.ForegroundColor = ConsoleColor.Red);
                    }
                    else
                    {
                        Console.WriteLine($"\n\tEl medio es el numero 3 ({num3})", Console.ForegroundColor = ConsoleColor.Yellow);
                        Console.WriteLine($"\n\tEl menor es el numero 2 ({num2})", Console.ForegroundColor = ConsoleColor.Red);
                    }
                }
                else
                {
                    if (num2 > num1 && num2 > num3)
                    {
                        Console.WriteLine($"\n\tEl mayor es el numero 2 ({num2})", Console.ForegroundColor = ConsoleColor.Green);
                        if (num1 > num3)
                        {
                            Console.WriteLine($"\n\tEl medio es el numero 1 ({num1})", Console.ForegroundColor = ConsoleColor.Yellow);
                            Console.WriteLine($"\n\tEl menor es el numero 3({num3})", Console.ForegroundColor = ConsoleColor.Red);
                        }
                        else
                        {
                            Console.WriteLine($"\n\tEl medio es el numero 3 ({num3})", Console.ForegroundColor = ConsoleColor.Yellow);
                            Console.WriteLine($"\n\tEl menor es el numero 1 ({num1})", Console.ForegroundColor = ConsoleColor.Red);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\n\tEl mayor es el numero 3 ({num3})", Console.ForegroundColor = ConsoleColor.Green);
                        if (num2 > num1)
                        {
                            Console.WriteLine($"\n\tEl medio es el numero 2 ({num2})", Console.ForegroundColor = ConsoleColor.Yellow);
                            Console.WriteLine($"\n\tEl menor es el numero 1 ({num1})", Console.ForegroundColor = ConsoleColor.Red);
                        }
                        else
                        {
                            Console.WriteLine($"\n\tEl medio es el numero 1 ({num1})", Console.ForegroundColor = ConsoleColor.Yellow);
                            Console.WriteLine($"\n\tEl menor es el numero 2 ({num2})", Console.ForegroundColor = ConsoleColor.Red);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
