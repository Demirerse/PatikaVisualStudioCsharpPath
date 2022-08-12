using System;
using System.Collections;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Pozitif bir tam sayı giriniz");
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            Sorular sorular = new Sorular();
            //sorular.Soru1();
            //sorular.Soru2();
            sorular.Soru3();

        }

        

        
    }

    class Sorular
    {
        public void Soru3()
        {
            Console.Write("Cümle Giriniz: ");
            string cumle = Console.ReadLine().ToLower();

            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            ArrayList sesliElemanlar = new ArrayList();

            int toplam = 0;
            foreach (char karakter in cumle)
                foreach (char sesli in sesliler)
                    if (karakter == sesli)
                        sesliElemanlar.Add(sesli);
                        toplam++;

            Console.WriteLine("Cümlede {0} Tane Sesli Harf Vardır", toplam);
            Console.WriteLine("==========");
            Console.WriteLine("Sesli elemanlar sırasıyla;");
            foreach (char item in sesliElemanlar)
            {
                Console.Write(item + " ");
            }

        }

        public void Soru2()
        {
            int[] sayilar = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. sayıyı girin:", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(sayilar);
            int enKucuk = sayilar[0];
            int enKucuk2 = sayilar[1];
            int enKucuk3 = sayilar[2];
            int enBuyuk3 = sayilar[17];
            int enBuyu2 = sayilar[18];
            int enBuyuk = sayilar[19];

            Console.WriteLine("Girilen en küçük sayılar toplamı={0}", enKucuk + enKucuk2 + enKucuk3);
            Console.WriteLine("Girilen en küçük sayılar ortalaması={0}", (enKucuk + enKucuk2 + enKucuk3)/3 );

            Console.WriteLine("Girilen en büyük sayılar toplamı={0}", enBuyuk + enBuyu2 + enBuyuk3);
            Console.WriteLine("Girilen en büyük sayılar ortalaması={0}", (enBuyuk + enBuyu2 + enBuyuk3)/3);
            Console.ReadKey();
        }


        public void Soru1()
        {
            int toplam = 0, ortalama = 0;
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. sayıyı girin:", i + 1);
                
                try
                {
                    int s = Convert.ToInt32(Console.ReadLine());
                    toplam += s;
                    if ( s <= 0)
                    {
                        throw new Exception("Sayı 0'dan büyük olmalı");
                    }
                    else
                    {
                        if (asalmi(s))
                        {
                            asalSayilar.Add(s);
                        }
                        else
                        {
                            asalOlmayanSayilar.Add(s);
                        }
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }
            ortalama = toplam / 20;
            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine("ASAL SAYILAR");
            foreach (int sayi in asalSayilar)
            {
                Console.Write(sayi + "    ");
            }
            Console.WriteLine();
            Console.WriteLine("ASAL OLMAYAN SAYILAR");
            Console.WriteLine("===========================");
            foreach (int sayi in asalOlmayanSayilar)
            {
                Console.Write(sayi + "    ");
            }

            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine("Sayıların ortalaması : {0}", ortalama);

            
            Console.WriteLine("===========================");
            Console.WriteLine("Asal sayı eleman adeti : {0}", asalSayilar.Count);

            Console.WriteLine("===========================");
            Console.WriteLine("Asal olmayan eleman adeti : {0}", asalOlmayanSayilar.Count);
        }

        public static bool asalmi(int sayi)
        {
            bool durum = false;

            int kontrol = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            return durum;
        }
    }
}
