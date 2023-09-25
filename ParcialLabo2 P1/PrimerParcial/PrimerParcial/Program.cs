using System.IO;
using System;

namespace PrimerParcial
{
    public class Program
    {
        /**
         * Esta es la funcion principal, contiene la logica para mostrar el menu y luego enviar a cada implementacion lo que se haya requerido.
         * Las opciones posibles para la ejercitacion es Crear el archivo plano, Agregar un nuevo valor y Listar todos los valores existentes. 
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int selectedIndex = 0;
            bool salir = false;
            Console.CursorVisible = false;
            while (salir == false)
            {
                Console.Clear();
                Console.ResetColor();

                Logo.Show();

                Console.WriteLine();
                Console.WriteLine("Seleccione una opción con las flechas {0} o {1}", (char)24, (char)25);
                Console.WriteLine("-----------------------------------------------------");

                for (int i = 0; i < Constants.menuOptions.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write((char)2 + " ");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write("  ");
                    }

                    Console.WriteLine(Constants.menuOptions[i]);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = Math.Max(0, selectedIndex - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndex = Math.Min(Constants.menuOptions.Length - 1, selectedIndex + 1);
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.Spacebar:
                        if (selectedIndex == Constants.menuOptions.Length - 1)
                            salir = true;
                        else
                            HandleMenuOption(Constants.menuOptions[selectedIndex]);
                        break;
                }
            }
        }

        /**
         * Este metodo esta encargado de recibir la opcion de menu deseada por el usuario 
         * Por cada opcion del menu, ejecutaremos Crear, Agregar o Listar según se haya solicitado dicha acción.
         * Las opciones que arroja excepciones en tiempo de ejecucion, deben ser controladas para que el usuario resuelva dicho caso.
         */
        public static void MenuAsync(string userInput)
        {
            switch (userInput)
            {
                case "Agregar":
                    Console.WriteLine("Agregar Vehiculo al archivo");
                    try
                    {
                        AgregarVehiculo();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "Listar":
                    Console.WriteLine("Listar todos los vehiculos");
                    try
                    {
                        ListarVehiculos();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadKey();
                    }
                    break;
            }
        }

        //else
        //{
        //    throw new Labo2NoContentOrOnlyWhiteSpaces();
        //}

        /**
         * Este metodo se encarga de obtener la opcion y mostrar cual fue la opcion de menu deseada.  
         * Luego llamaremos al método Menú quien contiene las acciones que llaman a las implementaciones. 
         */
        static void HandleMenuOption(string option)
        {
            // Aquí puedes implementar la lógica para manejar cada opción del menú
            Console.Clear();
            Console.WriteLine($"Seleccionaste: {option}");
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            MenuAsync(option);
        }

        public static bool NombreVehiculo(string userInput)
        {
            if (userInput.Length < 3 || userInput.Length > 20)
            {
                throw new InvalidNombreVehiculoFormatException();
            }
            else
            {
                return true;
            }
        }
        public static int NumeroEntero(string userInput)
        {
            try
            {
                int n = int.Parse(userInput);
                return n;
            }
            catch
            {
                Console.WriteLine(userInput);
                throw new Exception();
            }
        }

        public static void ListarVehiculos()
        {
            StreamReader Leer;
            FileStream Archivo;
            Console.Clear();

            double totVehicles = 0;
            double totLength = 0;
            double totSpeed = 0;

            if (File.Exists($"{Constants.FileNameCSV}") != false)
            {
                Archivo = new FileStream(Constants.FileNameCSV, FileMode.Open);
                Leer = new StreamReader(Archivo);

                Console.WriteLine("Archivo Existente");
                Leer.ReadLine();
                while (!Leer.EndOfStream)
                {
                    string row = Leer.ReadLine();
                    string[] atributos = row.Split(',');
                    Console.WriteLine("-Name: " + atributos[0].PadLeft(24));
                    Console.WriteLine("-Length: " + atributos[1].PadLeft(22));
                    Console.WriteLine("-Max Atmospherig Speed: " + atributos[2].PadLeft(7));
                    Console.WriteLine("-Crew: " + atributos[3].PadLeft(23));
                    Console.WriteLine("-Passengers: " + atributos[4].PadLeft(17));
                    Console.WriteLine("===================================================");

                    totLength += float.Parse(atributos[1]);
                    totSpeed += float.Parse(atributos[2]);
                    totVehicles++;
                }

                Console.WriteLine($"\n\n-Promedio de largo: {totLength / totVehicles}");
                Console.WriteLine($"-Promedio de velocidad: {totSpeed / totVehicles}");

                Leer.Close();
                Archivo.Close();
            }
            else
            {
                Console.WriteLine("Archivo Inexistente");
            }
            Console.ReadKey();

        }
        public static void AgregarVehiculo()
        {
            FileStream file;
            StreamWriter writer;
            file = new FileStream(Constants.FileNameCSV, FileMode.Append);
            writer = new StreamWriter(file);

            string name = "";
            int length = 0;
            int speed = 0;
            int crew = 0;
            int passangers = 0;

            bool validInput = false;

            string tempS;
            do
            {
                try
                {
                    Console.Write("Ingrese el nombre del vehiculo: ");
                    tempS = Console.ReadLine();
                    if (NombreVehiculo(tempS))
                    {
                        name = tempS;
                    }
                    validInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    validInput = false;
                }
            } while (!validInput);
            Console.Clear();

            do
            {
                try
                {
                    Console.Write("Ingrese el largo del vehiculo: ");
                    length = NumeroEntero(Console.ReadLine());
                    validInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    validInput = false;
                }
            } while (!validInput);

            Console.Clear();

            do
            {
                try
                {
                    Console.Write("Ingrese la velocidad máxima del vehiculo: ");
                    speed = NumeroEntero(Console.ReadLine());
                    validInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    validInput = false;
                }
            } while (!validInput);

            Console.Clear();

            do
            {
                try
                {
                    Console.Write("Ingrese la cantidad de tripulacion para este vehiculo: ");
                    crew = NumeroEntero(Console.ReadLine());
                    validInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    validInput = false;
                }
            } while (!validInput);

            Console.Clear();

            do
            {
                try
                {
                    Console.Write("Ingrese la cantidad de pasajeros del vehiculo: ");
                    passangers = NumeroEntero(Console.ReadLine());
                    validInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    validInput = false;
                }
            } while (!validInput);

            writer.WriteLine($"{name},{length},{speed},{crew},{passangers}");

            writer.Close();
            file.Close();
        }
    }
}