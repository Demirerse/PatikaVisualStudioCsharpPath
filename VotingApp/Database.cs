using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VotingApp
{
    public class Database
    {
        List<KisiKaydi> kisikaydiDb;

        public Database()
        {
            kisikaydiDb = new List<KisiKaydi>();
        }

        public void Kaydet(KisiKaydi kisi)
        {
            kisikaydiDb.Add(kisi);
        }

        public string OyKaydet(string oyTercihi, Guid id)
        {
            KisiKaydi kisi = kisikaydiDb.Find(x => x.Id == id);
            kisi.TercihAdi = oyTercihi;
            return oyTercihi;
        }

        public List<string> SonuclariGoster()
        {
            List<string> oylar = new List<string>();
            {
                string oy1 = kisikaydiDb.Where(x => x.OyTercihi == "React").Count().ToString();
                string oy2 = kisikaydiDb.Where(x => x.OyTercihi == "VueJs").Count().ToString();

                oylar.Add("React oy sayısı..: " + oy1);
                oylar.Add("VueJs oy sayısı..: " + oy2);
            }
            return oylar;
        }
    }
}
