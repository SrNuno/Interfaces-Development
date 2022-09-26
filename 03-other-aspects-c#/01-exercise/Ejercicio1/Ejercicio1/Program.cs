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
            bool exit = false;

            string ip;
            int ram;


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
                            Console.Write("\tEnter IP: ");
                            ip = Console.ReadLine();

                            Console.Write("\tEnter capacity RAM: ");
                            ram = Convert.ToInt32(Console.ReadLine());

                            if (validateIP(ip) == true && validateRAM(ram) == true)
                            {
                                hashtable.Add(ip, ram);
                            }
                            Console.WriteLine();
                            break;

                        case 2:
                            Console.Write("\tEnter IP to delete: ");
                            ip = Console.ReadLine();

                            if (hashtable.ContainsKey(ip))
                            {
                                hashtable.Remove(ip);
                            }
                            Console.WriteLine();
                            break;

                        case 3:
                            foreach (DictionaryEntry de in hashtable)
                            {
                                Console.WriteLine("\t{0} -> {1}GB", de.Key, de.Value);
                            }
                            Console.WriteLine();
                            break;

                        case 4:
                            Console.Write("\tEnter IP to show specific: ");
                            ip = Console.ReadLine();
                            Console.WriteLine($"\t{ip}, your RAM is {hashtable[ip]}");
                            Console.WriteLine();
                            break;

                        case 5:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("\tOption invalid");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\tError, you have entered a letter or another character distinct the number");
                }
            }
        }

        static bool validateIP(string ip)
        {
            string[] aux = ip.Split('.');
            for (int i = 0; i < aux.Length; i++)
            {
                if (Convert.ToInt32(aux[i]) < 0 || Convert.ToInt32(aux[i]) >= 256)
                {
                    return false;
                }
            }
            return true;
        }

        static bool validateRAM(int ram)
        {
            if (ram > 0)
            {
                return true;
            }
            return false;
        }
    }
}
