using System;

namespace OrtalamaHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciOrtHesaplama();

        }

        private static void FibonacciOrtHesaplama()
        {
            int a = 0;
            int b = 1;
            int sayi;

            Console.Write("Kaç eleman olsun..");
            sayi = Convert.ToInt32(Console.ReadLine());

            Console.Write(a + " " + b + " ");

            for (int i = 3; i < sayi; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
