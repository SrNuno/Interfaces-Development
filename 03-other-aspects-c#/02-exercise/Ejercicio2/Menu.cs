using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio2
{
    internal class Menu
    {
        Aula aula;
        string[] nombres;
        string[] asig;

        public Menu(params string[] nombres)
        {
            this.nombres = nombres;
            aula = new Aula(this.nombres);
        }
        public void pintaMenu(string[] opciones, int opcion, string titulo)
        {
            Console.Clear();
            Console.WriteLine(titulo);
            for (int i = 0; i < opciones.Length; i++)
            {
                if (i == opcion)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine(opciones[i]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public int subMenu(bool alumMateria)
        {
            string[] opt;
            string titulo;
            bool exit = false;
            int opcion = 0;
            int seleccion = -1;

            if (alumMateria)
            {
                opt = nombres;
                titulo = "Select a student:";
            }
            else
            {
                opt = Enum.GetNames(typeof(Aula.Asig));
                titulo = "Select a subject:";
            }

            Console.CursorVisible = false;
            pintaMenu(opt, opcion, titulo);
            Console.WriteLine("Press enter to select");

            do
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.DownArrow:
                        opcion = opcion < opt.Length - 1 ? opcion + 1 : opcion;
                        break;
                    case ConsoleKey.UpArrow:
                        opcion = opcion > 0 ? opcion - 1 : opcion;
                        break;
                    case ConsoleKey.Enter:
                        seleccion = opcion;
                        exit = true;
                        break;
                    case ConsoleKey.Escape:
                        seleccion = opt.Length - 1;
                        break;

                }
                pintaMenu(opt, opcion, titulo);
                Console.WriteLine("Pulse ENTER to select");

            } while (!exit);
            Console.Clear();
            return seleccion;
        }
        public void inicio()
        {
            bool valid = false;
            int opcion = 0;
            int aux;
            int k = 1;
            asig = Enum.GetNames(typeof(Aula.Asig));

            while (!valid)
            {
                try
                {
                    Console.WriteLine("1. Show average table");
                    Console.WriteLine("2. Show average student");
                    Console.WriteLine("3. Show average subject");
                    Console.WriteLine("4. Show notes a student");
                    Console.WriteLine("5. Show notes a subject");
                    Console.WriteLine("6. Show maximum and minimum notes");
                    Console.WriteLine("7. Show all table");
                    Console.WriteLine("8. Exit");
                    Console.Write("\tChoose an option: ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            mostrarMedia();
                            break;

                        case 2:
                            aux = subMenu(true);
                            mediaAlumno(aux);
                            break;

                        case 3:
                            aux = subMenu(false);
                            mediaAsignatura(aux);
                            break;

                        case 4:
                            aux = subMenu(true);
                            mostrarNotasAlumnos(aux, asig);
                            break;

                        case 5:
                            aux = subMenu(false);
                            mostrarNotasAsignatura(aux, k);
                            break;

                        case 6:

                            break;

                        case 7:

                            break;

                        case 8:
                            valid = true;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Option invalid");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\tSorry, enter a option number no a letter\n");
                }
            }

        }

        public void mostrarMedia()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The average of the notes to the table is {aula.calcMedia()}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void mediaAlumno(int alumno)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The average of the {nombres[alumno]} is: {aula.mediaAlumno(alumno)}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void mediaAsignatura(int subject)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The average of the {asig[subject]} is: {aula.mediaAsignatura(subject)}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void mostrarNotasAlumnos(int indexAlum, string[] asignaturas)
        {
            Console.WriteLine($"Notes by {nombres[indexAlum]}:");
            foreach (string asig in asignaturas)
            {
                Console.Write($"{asig, -12}|");
            }
            Console.WriteLine();
            for (int i = 0; i < aula.notas.GetLength(0); i++)
            {
                Console.Write($"{aula[i, indexAlum], 12}|");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void mostrarNotasAsignatura(int indexAsig, int k)
        {
            Console.WriteLine($"Notes by {asig[indexAsig]}:");
            foreach (string alum in nombres)
            {
                Console.Write($"{alum, -10}|");
            }
            Console.WriteLine();
            for (int i = 0; i < aula.notas.GetLength(1); i++)
            {
                Console.Write($"{aula[indexAsig, i], 10}|");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
