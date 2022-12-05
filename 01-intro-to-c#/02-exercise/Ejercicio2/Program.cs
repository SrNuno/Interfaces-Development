#define FRASE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter phrase: ");
            string f1 = Console.ReadLine();
            Console.Write("Enter second phrase: ");
            string f2 = Console.ReadLine();
#if FRASE
            Console.WriteLine("\"{0}\" \\{1}\\", f1, f2);
#else
            Console.WriteLine("{0}\t{1}\n{0}\n{1}", f1, f2);
#endif
            Console.ReadLine();
        }
    }
}
