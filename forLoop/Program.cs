using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //        continue;
            //    Console.WriteLine(i);
            //}

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }

            //Staircase
            int T = Convert.ToInt16(Console.ReadLine());

            // loop over number of rows
            for (short i = 1; i <= T; ++i)
            {
                for (int j = 1; j <= T; ++j)
                {
                    if (j <= T - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
