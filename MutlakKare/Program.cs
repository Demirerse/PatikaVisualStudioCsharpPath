using System;

namespace MutlakKare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("67 Severler Derneğine Hoş Geldiniz. Bir kaç sayınızı alırız..");
            string sayilar = Console.ReadLine().Trim();
            MutlakKareToplam(sayilar);
        }

        public static void MutlakKareToplam(string sayilar)
        {
            string[] Dizi = sayilar.Split(' ');

            int toplam = 0;
            int carpim = 0;
            for (int i = 0; i < Dizi.Length; i++)
            {   //toint64 olmuyor neden??
                int sayi = Convert.ToInt32(Dizi[i]);
                if (sayi < 67)
                {
                    toplam = (67 - sayi) + toplam;
                }
                else
                {
                    carpim = (int)Math.Pow(Math.Abs(sayi - 67), 2);
                }
            }
            Console.WriteLine($"67 sevmeyenlerin fark toplamı : {toplam}" +
                              $"\n67 sevenler fark karesi toplamı : {carpim} ");
        }
    }
}
