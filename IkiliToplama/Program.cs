using System;
using System.Linq;

namespace IkiliToplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ardışık sayıları aralarında boşluklarla giriniz. ");
            string sayilar = Console.ReadLine().Trim();
            IkiliToplama(sayilar);
        }

        public static void IkiliToplama(string sayilar)
        {
            string[] Dizi = sayilar.Split(' ');

            
            try
            {
                for (int i = 0; i < Dizi.Length; i += 2)
                {

                    if (Dizi[i] == Dizi[i + 1])
                    {
                        int çarpım = Convert.ToInt32(Dizi[i]) + Convert.ToInt32(Dizi[i + 1]);
                        Console.WriteLine($"Dizinin ardışık yazılmış {i} elemanı çarpımı: {çarpım * çarpım} ..");
                    }
                    else
                    {
                        int toplama = Convert.ToInt32(Dizi[i]) + Convert.ToInt32(Dizi[i + 1]);
                        Console.WriteLine($"Dizinin {i}. elemanı ile {i + 1}. elemanı toplamı: {toplama} ..");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ardışık means çiftli sayılar gülüm..Hadi tekrar başla\n" + (ex.Message));
            }
            



        }
    
    }
}
