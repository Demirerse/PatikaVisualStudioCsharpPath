using System;
using System.Collections.Generic;
using System.Text;

namespace VotingApp
{
    public class OyPusulasi
    {
        List<KisiKaydi> kisiKaydiDb;
        KisiKaydi kisi;
        Guid uniqueId;
        Database db;

        public OyPusulasi(Database db)
        {
            kisi = new KisiKaydi();
            kisiKaydiDb = new List<KisiKaydi>();
            this.db = db;
        }

        public void OyPusulasiFormu()
        {
            Console.WriteLine("İsminizi giriniz..:");
            kisi.Adi = Console.ReadLine();

            uniqueId = Guid.NewGuid();
            kisi.Id = uniqueId;

            db.Kaydet(kisi);

            Console.WriteLine("uniqueId..: " + uniqueId);
            #region
            //while (!string.IsNullOrEmpty(Console.ReadLine()))
            //{
            //    string FirstName = Console.ReadLine();
            //    regst.FirstName = Console.ReadLine();
            //}

            //Console.WriteLine("Enter last name:");
            ////string lName = Console.ReadLine();
            //regst.LastName = Console.ReadLine();

            //Console.WriteLine("Enter address:");
            //regst.Address = Console.ReadLine();

            //Console.WriteLine("Enter age:");
            //regst.Age = int.Parse(Console.ReadLine());           
            //if(regst.Age <= 18)
            //{
            //    Console.WriteLine("Under 18 years of age user doesnt qualify to poll");
            //}

            //Console.WriteLine("Any criminal offence:");
            //regst.Offence = Convert.ToBoolean(Console.ReadLine());
            //if (regst.Offence)
            //{
            //    Console.WriteLine("if committed any criminal offence, user doesnt qualify to poll ");                
            //}
            #endregion
        }

        public string OySecenekleri()
        {
            List<string> pusula = new List<string>();
            pusula.Add("React");
            pusula.Add("VueJs");
            Console.WriteLine("Hangi tech daha üstün..!");
            foreach (string item in pusula)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Birini seçiniz..:");
            string oyTercihi = Console.ReadLine();

            kisi.OyTercihi = oyTercihi;

            if (!oyTercihi.Contains(oyTercihi))
            {
                Console.WriteLine("Doğru girdi yazdığınızdan emin olun..!");
            }

            oyTercihi = db.OyKaydet(oyTercihi, uniqueId);
            return oyTercihi;
        }
    }
}
