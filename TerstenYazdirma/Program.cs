using System;
using System.Collections;
using System.Linq;

namespace TerstenYazdirma
{
    class Program
    {
        static void Main(string[] args)
        {



            //ArrayList cumle = new ArrayList();
            //cumle.Add(metin);

            ////metin.Length "-1" deme sebebimiz diziler
            ////diziler "0". indisden başlamaktır
            //Console.WriteLine("Metnimizin ters hali..");


            //foreach (var item in cumle)
            //{

            //    for (int i = metin.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(metin[i]);
            //        //cumle.Add(metin[i]);
            //    }
            //    Console.Write(item);
            //}


            //Console.Write("Lütfen bir metin giriniz..");
            //string cumle = Console.ReadLine();
            //string[] metin = cumle.Split(' ');
            //Array.Reverse(metin);
            ////string.Join(" ", metin);
            ////Console.WriteLine(string.Join(" ", metin));

            //Console.WriteLine("-----");

            //for (int i = metin.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(metin[i]);
            //}

            //Console.ReadKey();



            //Console.Write("Cümle Giriniz: ");
            //string cumle = Console.ReadLine();

            //string ters = "";
            //for (int i = 1; i <= cumle.Length; i++)
            //    ters += cumle.Substring(cumle.Length - i, 1);

            //Console.WriteLine("Girdiğiniz Metnin Tersi: " + new string(cumle.Reverse().ToArray()));

            Console.WriteLine("lütfen bir yazı yazın");
            string yazi = Console.ReadLine();
            string tersten = "";

            for (int i = yazi.Length - 1; i >= 0; i--)
            {
                tersten += yazi.Substring(i, 1);
            }
            

            System.Console.WriteLine(tersten);
        }
    }
}
