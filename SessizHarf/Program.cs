using System;
using System.Linq;

namespace SessizHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SessizHarf();
        }

        private static void SessizHarf()
        {

            Console.WriteLine("Kelimelerin içinde çok gizli şifreler olan bir cümle giriniz: ");
            Console.WriteLine("Şifreyi poroğğramım çözerse true vericek veremezse false");
            string[] Dizi = Console.ReadLine().Split();

            foreach (string item in Dizi)
            {
                bool yanyana = false;
                for (int i = 1; i < item.Length; i++)
                {
                    if (HarfKontrol(item[i]) == HarfKontrol(item[i - 1]))
                        yanyana = true;
                }
                Console.WriteLine($"Cümlenin {item} kelimesinde yanyana harf var: {yanyana}");
                Console.WriteLine("**--**");
            }

            bool HarfKontrol(char sessizHarf)
            {
                if (true)
                {

                }
                return !"aeıioöuü".ToCharArray().Contains(sessizHarf);
            }
        }
    }
}
