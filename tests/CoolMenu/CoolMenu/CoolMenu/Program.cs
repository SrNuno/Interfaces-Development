using System;

namespace CoolMenu
{
    class Program
    {

        static void pintaMenu(string[] opciones, int opcion)
        {
            string titulo = "MENU";

            Console.Clear();
            Console.WriteLine(titulo);
            for (int i = 0; i < opciones.Length; i++)
            {
                if (i == opcion) // Pinta la opción seleccionada en Video Inverso
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(opciones[i]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            }

        }

        static void Main(string[] args)
        {

            int opcion = 0;
            int seleccion = -1;
            string[] opciones = { "Opción 0", "Opción 1", "Opción 2", "Opción 3", "Salir" };
            Console.CursorVisible = false;
            pintaMenu(opciones, opcion);
            do
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.DownArrow:
                        opcion = opcion < opciones.Length - 1 ? opcion + 1 : opcion;
                        break;
                    case ConsoleKey.UpArrow:
                        opcion = opcion > 0 ? opcion - 1 : opcion;
                        break;
                    case ConsoleKey.Spacebar:
                        seleccion = opcion;
                        break;
                    case ConsoleKey.Escape:
                        seleccion = opciones.Length - 1;
                        break;

                }
                pintaMenu(opciones, opcion);
                Console.WriteLine("Opción elegida: {0}", seleccion);

            } while (seleccion != opciones.Length - 1); // Última opción Salir

        }
    }
}