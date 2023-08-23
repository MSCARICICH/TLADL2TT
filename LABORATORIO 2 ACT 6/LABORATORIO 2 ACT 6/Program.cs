using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_2_ACT_6
{
    internal class Program
    {
        public class InvalidFormatException1: Exception
        {
            public InvalidFormatException1(string message): base(message)
            {
                Console.WriteLine(message);
                Console.ReadKey();
                Console.Clear();
            }
        }
        public class InvalidFormatException2: Exception
        {
            public InvalidFormatException2 (string message): base(message)
            {
                Console.WriteLine(message);
                Console.ReadKey();
                Console.Clear();
            }
        }
        static int Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            string cadena1, cadena2, cadena3 ,cadena4;
            int hijos;
            double monto, montoSUB, desc;
            Console.Write("Ingresar Nombre: ");
            cadena1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingresar sexo: ");
            cadena2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingresar cantidad de hijos: ");
            cadena3 = Console.ReadLine();
            try
            {
                hijos = int.Parse(cadena3);
            }
            catch
            {
                throw new InvalidFormatException1("El formato no se puede convertir a INT");
            }   
            Console.Clear();
            Console.WriteLine("Ingresar monto neto: ");
            cadena4 = Console.ReadLine();
            try
            {
                monto = float.Parse(cadena4);
                montoSUB = float.Parse(cadena4);
            }
            catch
            {
                throw new InvalidFormatException2("El formato no se puede convertir a FLOAT");
            }
            if(cadena2 == "M")
            {
                if(hijos == 0)
                {
                    desc = monto * 0.025;
                    monto = monto - (monto * 0.025);
                    Console.Clear();
                    Console.WriteLine($"\t| Señor {cadena1} |\n");
                    Console.WriteLine($"\tSubtotal: {montoSUB}\n");
                    Console.WriteLine($"\tDescuento: {desc} (2.5%)\n");
                    Console.WriteLine($"\tMonto Total: {monto}\n");
                    Console.ReadKey();
                }
                else
                {
                    if(hijos > 0)
                    {
                        desc = monto * 0.05;
                        monto = monto - (monto * 0.05);
                        Console.Clear();
                        Console.WriteLine($"\t| Señor {cadena1} |\n");
                        Console.WriteLine($"\tSubtotal: {montoSUB}\n");
                        Console.WriteLine($"\tDescuento: {desc} (5%)\n");
                        Console.WriteLine($"\tMonto Total: {monto}\n");
                        Console.ReadKey();
                    }
                }
            }
            if(cadena2 == "F")
            {
                if(hijos == 0)
                {
                    desc = monto * 0.10;
                    monto = monto - (monto * 0.10);
                    Console.Clear();
                    Console.WriteLine($"\t| Señorita {cadena1} |\n");
                    Console.WriteLine($"\tSubtotal: {montoSUB}\n");
                    Console.WriteLine($"\tDescuento: {desc} (10%)\n");
                    Console.WriteLine($"\tMonto Total: {monto}\n");
                    Console.ReadKey();
                }
                else
                {
                    if(hijos == 1 || hijos == 2)
                    {
                        desc = monto * 0.15;
                        monto = monto - (monto * 0.15);
                        Console.Clear();
                        Console.WriteLine($"\t| Señora {cadena1} |\n");
                        Console.WriteLine($"\tSubtotal: {montoSUB}\n");
                        Console.WriteLine($"\tDescuento: {desc} (15%)\n");
                        Console.WriteLine($"\tMonto Total: {monto}\n");
                        Console.ReadKey();
                    }
                    else
                    {
                        if(hijos > 2)
                        {
                            desc = monto * 0.20;
                            monto = monto - (monto * 0.20);
                            Console.Clear();
                            Console.WriteLine($"\t| Señora {cadena1} |\n");
                            Console.WriteLine($"\tSubtotal: {montoSUB}\n");
                            Console.WriteLine($"\tDescuento: {desc} (20%)\n");
                            Console.WriteLine($"\tMonto Total: {monto}\n");
                            Console.ReadKey();
                        }
                    }
                }
            }
            Console.Clear();
            return 0;
        }
    }
}
