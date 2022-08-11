using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            

        }

        public void EkranaYazdir(int deger)
        {
            Console.WriteLine(deger);
        }

        public void EkranaYazdir(string deger)
        {
            Console.WriteLine(deger);
        }

        public void EkranaYazdir(string deger1, string deger2)
        {
            Console.WriteLine(deger1 + deger2);
        }

        public int Toplam(int a, int b, out int toplam)
        {
            toplam = a + b;
            return toplam;
        }

        static int FibonacciSerisi(int sayi)
        {
            if(sayi==0)
            { return 0; }
            else if(sayi==1)
            { return 1; }
            else
            { return FibonacciSerisi(sayi - 1) + FibonacciSerisi(sayi - 2); }
        }


    }

    public static class MyExtensionClass
    {
        public static bool IsEventNumber(this int value)
        {
            if (value % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
