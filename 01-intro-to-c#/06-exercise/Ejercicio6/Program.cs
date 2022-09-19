#define DIR
namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f = 45;
            int i = 75;
#if !DIR
            calcFactorial(45, ref f);
            System.Console.WriteLine("Result: " + f);
#else
            paintAsterisk();
#endif
            Console.ReadKey();
        }


        static bool calcFactorial(int n, ref double facto)
        {
            if (n < 0 || n > 10)
            {
                return false;
            }
            facto = 1;
            for (int i = n; i > 0; i--)
            {
                facto *= i;
            }

            return true;
        }

        static void paintAsterisk(int n = 10)
        {
            Random random = new Random();
            int auxCol;
            int auxRow;

            for (int i = 0; i < n; i++)
            {
                auxCol = random.Next(1, 21);
                auxRow = random.Next(1, 21);

                Console.SetCursorPosition(auxCol, auxRow);
                Console.WriteLine("*");
            }
        }

    }
}