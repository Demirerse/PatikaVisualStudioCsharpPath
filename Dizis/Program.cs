using System;

namespace Dizis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int[] sayiDizisi = new int[20];
            //int toplam = 0;
            //for (int i = 0; i < sayiDizisi.Length; i++)
            //{
            //    Console.Write("Lütfen {0}. sayıyı girin:", i + 1);
            //    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayiDizisi[i];
            //}
            //double ortalama = toplam / 20;
            //Console.WriteLine("Sayıların ortalaması: " + ortalama);
            //Console.ReadLine();

            //var positiveNumbers = 0;
            //var negativeNumbers = 0;
            //var zeroNumbers = 0;
            ////No need to capture the size of array. I use array's length property instead.
            //Console.ReadLine();
            //var arr_temp = Console.ReadLine().Split(' ');
            //var arr = Array.ConvertAll(arr_temp, Int32.Parse);

            //for (int arr_i = 0; arr_i < arr.Length; arr_i++)
            //{
            //    if (arr[arr_i] > 0)
            //        ++positiveNumbers;
            //    else if (arr[arr_i] < 0)
            //        ++negativeNumbers;
            //    else
            //        ++zeroNumbers;
            //}

            //Console.WriteLine((double)positiveNumbers / arr.Length);
            //Console.WriteLine((double)negativeNumbers / arr.Length);
            //Console.WriteLine((double)zeroNumbers / arr.Length);


            int[] sayiDizisi = { 1, 3, 4, 9, 8, 7 };

            Array.Reverse(sayiDizisi);
            Console.WriteLine(sayiDizisi);
        }
    }
}
