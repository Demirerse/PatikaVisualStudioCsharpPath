using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> renkler = new List<string>();

            renkler.Add("Mavi");
            renkler.Add("Kırmızı");

            ArrayList dizi = new ArrayList();

            dizi.Add("Kedi");
            dizi.Add(99);
            dizi.Add(true);

            Dictionary<int, string> renklers = new Dictionary<int, string>();

            renklers.Add(3, "Kırmızı");
            renklers.Add(5, "Sarı");
        }
    }
}
