using System;

namespace KarakterCikarma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir yazı yazın..");
            string yazi = Console.ReadLine();

            Console.Write("Çıkarılacak elemanın indexini giriniz..");
            int n = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine(yazi.Remove(n, 1));


        }
    }
}
