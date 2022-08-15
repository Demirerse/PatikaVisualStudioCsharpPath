using System;

namespace UcgenCizme
{
    class Program
    {
        static void Main(string[] args)
        {
            //DikUcgen();

            PiramitUcgen();
        }

        private static void PiramitUcgen()
        {
            Console.Write("Kaç yıldızlı üçgenimiz olsun..");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int k = i; k < n; k++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x <= i; x++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }

        private static void DikUcgen()
        {
            Console.Write("Kaç yıldızlı üçgenimiz olsun..");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
