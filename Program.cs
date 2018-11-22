using System;

namespace Nr_prim
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, k = 0;

            Console.WriteLine("Introduce un numar:");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0 || num1 == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                        k++;
                }
                if (k != 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }

        }
    }
}
