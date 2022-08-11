using System;
using System.Collections.Generic;
using System.Linq;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CiftleriAyirmayalimSoru1();

            //CiftleriAyirdikVallaSoru2();

            //TersIcatlarSoru3();

            HarfKelimeSaySoru4();

        }

        private static void HarfKelimeSaySoru4()
        {
            Console.Write("Dokunma KELime, ver bana bir cümle..:");
            string cümle = Console.ReadLine().Trim();

            string[] kelimeler = cümle.Split(" ");
            int kelimeSayisi = kelimeler.Count();
            Console.WriteLine("KEL(ime)ler sayısı:" + kelimeSayisi);

            //boşlukları eleman saymadan harf sayısı
            int harfSayisi = cümle.Count() - (kelimeSayisi - 1);
            Console.WriteLine("Harf sayısı :" + harfSayisi);
        }

        private static void TersIcatlarSoru3()
        {
            Console.WriteLine("Pozitif bir tam sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> kelimeler = new List<string>();

            Console.WriteLine("Bu sefer numaranız : " + n + " kadar kelime giriniz..:)");


            for (int i = 0; i < n; i++)
            {
                Console.Write("Dokunma KELime, ver bana bir kelime..:");
                string kelime = Console.ReadLine().Trim();
                kelimeler.Add(kelime);
            }

            Console.WriteLine("Yazdığın kelimeleri tersten yazdıran dizi icat ettik");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(kelimeler[i]);
            }
        }

        private static void CiftleriAyirdikVallaSoru2()
        {
            Console.WriteLine("Pozitif bir tam sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Pozitif bir tam sayı daha giriniz");
            int m = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> sayilar = new List<int>();

            Console.WriteLine("Numaranız : " + n + " kadar pozitif tam sayı giriniz.");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Gimme gimme more..:");
                int sayi = Convert.ToInt32(Console.ReadLine().Trim());
                if (m % sayi == 0)
                {
                    sayilar.Add(sayi);
                }

            }

            Console.WriteLine("Numaranız : " + m + " ile kalansız bölünebilen sayılarınız..;");
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
        }

        private static void CiftleriAyirmayalimSoru1()
        {
            Console.WriteLine("Pozitif bir tam sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Numaranız : " + n + " kadar pozitif tam sayı giriniz.");

            List<int> sayilar = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Gimme more..:");
                int ciftOlmali = Convert.ToInt32(Console.ReadLine().Trim());
                if (ciftOlmali % 2 == 0)
                {
                    sayilar.Add(ciftOlmali);
                }
            }

            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }

        }
    }
}
