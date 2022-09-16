namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool exit = false;
            bool final = false;

            while (!exit)
            {
                try
                {
                    Console.WriteLine("1. Enter number");
                    Console.WriteLine("2. Guess the number");
                    Console.WriteLine("3. Football pools");
                    Console.WriteLine("4. Play everyone");
                    Console.WriteLine("5. Exit");
                    Console.Write("\tEnter option number (1-5): ");
                    option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            char answer;
                            int number;
                            int[] die = new int[10];
                            Random random = new Random();

                            Console.Write("\tDo you want enter number finish? (Y/N):");
                            answer = Convert.ToChar(Console.ReadLine().ToUpper());
                            if (answer == 'Y' )
                            {
                                do
                                {
                                    Console.Write("\tEnter number greater than 1: ");
                                    number = Convert.ToInt32(Console.ReadLine());
                                } while (number <= 1);
                            }
                            else
                            {
                                number = 6;
                            }

                            for (int i = 0; i < die.Length; i++)
                            {
                                die[i] = random.Next(1, number);
                                Console.WriteLine("\tDado " + i + ": " + die[i]);
                            }

                            Console.WriteLine();
                            if (final == true)
                            {
                                goto case 2;
                            }
                            break;

                        case 2:
                            Console.WriteLine("\tWelcome to the play. The game consists of finding a random number from 1 to 100 in 5 attempts.");
                            Console.Write("\tEnter your name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine();

                            Random genNum = new Random();
                            int numberUser;
                            int numRandom = genNum.Next(1, 101);
                            int attempts = 5;

                            Console.Write($"\tWelcome {name}, enter a number between 1 and 100: ");
                            numberUser = Convert.ToInt32(Console.ReadLine());

                            if (numberUser != numRandom)
                            {
                                while (numberUser != numRandom && attempts > 1)
                                {
                                    attempts--;
                                    Console.WriteLine($"\tNumber of attempts: {attempts}");
                                    if (numberUser < numRandom)
                                    {
                                        Console.Write("\tYour number is lower: ");
                                    }
                                    else
                                    {
                                        Console.Write("\tYour number is upper: ");
                                    }
                                    numberUser = Convert.ToInt32(Console.ReadLine());
                                }
                            }

                            if (numberUser != numRandom)
                            {
                                Console.WriteLine($"\tSorry, you have lost. The number correct is {numRandom}");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine($"\tCongratulations {name}, {numberUser} is correct!!");
                                Console.WriteLine();
                            }
                            if (final == true)
                            {
                                goto case 3;
                            }
                            break;

                        case 3:
                            string[] results = new string[14];
                            for (int i = 0; i < results.Length; i++)
                            {
                                Console.WriteLine("\tResult {0,10}: {1,2}", i, returnResult());
                            }
                            Console.WriteLine();
                            break;

                        case 4:
                            final = true;
                            goto case 1;

                        case 5:
                            exit = true;
                            Console.WriteLine("\tThanks and come back soon");
                            break;

                        default:
                            Console.WriteLine("\tChoose an option to 1 an 5\n");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\tSorry, enter a option number no a letter\n");
                }
            }
            Console.ReadLine();

            static string returnResult()
            {
                Random random = new Random();
                int result = random.Next(1, 101);

                switch (result)
                {
                    case <= 60: return "1";
                    case > 60 and <= 85: return "X";
                    case > 85: return "2";
                }
            }
        }
    }
}