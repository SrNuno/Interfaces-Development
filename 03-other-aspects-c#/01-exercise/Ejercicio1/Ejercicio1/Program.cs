using System.Collections;
using System.Net;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            int respuesta;
            Boolean exit = false;

            while (!exit)
            {
                try
                {
                    Console.WriteLine("1. Introduce data");
                    Console.WriteLine("2. Delete data (by key)");
                    Console.WriteLine("3. Show all collection");
                    Console.WriteLine("4. Show specific element");
                    Console.WriteLine("5. Exit");
                    Console.Write("\tChoose option to 1-4: ");
                    respuesta = Convert.ToInt32(Console.ReadLine());

                    switch (respuesta)
                    {
                        case 1:
                            string ip;

                            Console.Write("\tIntroduce IP: ");
                            ip = Console.ReadLine();
                            Console.WriteLine(validateIP(ip));
                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            exit = true;
                            break;

                        default:

                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\tError, you have entered a letter or another character distinct the number");
                }
            }
        }

        public static bool validateIP(string ip)
        {
           
        }
    }
}
