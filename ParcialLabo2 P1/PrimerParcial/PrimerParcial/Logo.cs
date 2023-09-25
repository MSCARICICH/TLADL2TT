using System;

namespace PrimerParcial
{
    public class Logo
    {
        public static void Show(ConsoleColor? color = null)
        {

            Console.ForegroundColor = color ?? ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("\t██╗   ██╗████████╗███╗   ██╗");
            Console.WriteLine("\t██║   ██║╚══██╔══╝████╗  ██║");
            Console.WriteLine("\t██║   ██║   ██║   ██╔██╗ ██║");
            Console.WriteLine("\t██║   ██║   ██║   ██║╚██╗██║");
            Console.WriteLine("\t╚██████╔╝   ██║   ██║ ╚████║");
            Console.WriteLine("\t ╚═════╝    ╚═╝   ╚═╝  ╚═══╝");
            Console.ResetColor();
            Console.WriteLine(Constants.HeadTitle);
        }
    }

}