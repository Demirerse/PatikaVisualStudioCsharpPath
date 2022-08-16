using System;

namespace KarakterDegistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bize bir cümle lazım ama kelimelerin içeriğini bozacağız..");
            string cumle = Console.ReadLine();
            KarakterDegistirme(cumle);
        }

        static void KarakterDegistirme(string cumle)
        {
            string[] kelimeler = cumle.Split(" ");

            Console.WriteLine("Bir de böyle okuyalım..");
            for (int i = 0; i < kelimeler.Length; i++)
            {
                char[] harfler = kelimeler[i].ToCharArray();

                char ilkHarf = harfler[0];

                harfler[0] = harfler[^1];
                harfler[^1] = ilkHarf;

                string sonuc = string.Concat(harfler);
                Console.Write(sonuc + " ");
            }
        }
    }
}
