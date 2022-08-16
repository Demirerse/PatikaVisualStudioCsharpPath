using System;
using System.Collections.Generic;

namespace VotingApp
{
    public class Program
    {
        Database db;
        public Program()
        {
            db = new Database();
        }
        static void Main(string[] args)
        {
            string programaDevam = "";
            while (programaDevam !="exit")
            {
                Program program = new Program();
                program.KisiBul();
                Console.WriteLine("Sonuclari görmek ister misiniz? Y / N ");
                Console.WriteLine("Çıkmak için -exit- o.0");
                string yn = Console.ReadLine();
                if (yn.ToUpper() == "Y")
                {
                    List<string> oylar = program.OySonuclari();
                    foreach (var item in oylar)
                    {
                        Console.WriteLine(item);
                    }
                }else if(yn =="exit")
                {
                    programaDevam="exit";
                }
            }
        }

        public void KisiBul()
        {
            OyPusulasi oy = new OyPusulasi(db);
            oy.OyPusulasiFormu();
            string oyTercihi = oy.OySecenekleri();

        }

        public List<string> OySonuclari()
        {
            return db.SonuclariGoster();
        }
    }
}
