using System;
using System.Collections.Generic;

namespace ToDO
{
    class Program
    {
        static void Main(string[] args)
        {

            Operation operation = new Operation();
            operation.DefaultCard();
            operation.DefaultPerson();
            operation.start();
            bool kontrol = true;
            while (kontrol)
            {
                Console.WriteLine("Lütfen 1 - 5 Arasında Bir İşlem Seçiniz");
                int No = int.Parse(Console.ReadLine());
                if (No < 1 || No > 5)
                {
                    Console.WriteLine("Yanlış Bir Seçim Yaptınız Lütfen 1-5 Arasında Bir Seçim Yapınız");
                    continue;
                }
                switch (No)
                {
                    case 1: operation.listele(); break;
                    case 2: operation.add(); break;
                    case 3: operation.Delete(); break;
                    case 4: operation.transfer(); break;
                    case 5: kontrol = false; break;
                }
            }


        }
    }

    public class Operation
    {
        ToDo toDo = new ToDo();
        person person = new person();


        public void DefaultPerson()
        {
            person.Add("1", "Selim", "Demirer");
            person.Add("2", "Elif", "Demirer");
        }

        public void DefaultCard()
        {
            toDo.Add("İşsiz", "İş bul lan", "1", "2");
            toDo.Add("Müdür", "Bölge Müdüresi ol lan", "1", "3");
        }
        public void start()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(5) Programı Kapat");
        }

        public void add()
        {
            Console.WriteLine("Card Ekleme Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Kart Başlığını Giriniz");
            string baslik = Console.ReadLine();
            Console.WriteLine("Kart İçeriğini Giriniz");
            string içerik = Console.ReadLine();
        i:
            Console.WriteLine("Kart Sahibinin İD'sini Giriniz");
            string id = Console.ReadLine();
            if (!person.varmı(id))
            {
                Console.WriteLine("Yanlış bir id girdiniz");
                goto i;
            }
        b:
            Console.WriteLine("Kart Büyüklüğünü Giriniz --> XS(1),S(2),M(3),L(4),XL(5)");
            string boy = Console.ReadLine();
            if (int.Parse(boy) < 1 || int.Parse(boy) > 5)
            {
                Console.WriteLine("yanlış bir büyüklük girdiğiniz 1-5 arasında seçim yapınız");
                goto b;
            }
            toDo.Add(baslik, içerik, id, boy);
            Console.WriteLine("İşlem Başarıyla Gerçekleşti");
        }

        public void listele()
        {
            List<CardModel> list = toDo.Liste();
            Console.WriteLine("Kartları Görüntüleme Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("TODO Line");
            Console.WriteLine("*******************************************");
            foreach (var item in list)
            {
                if (item.Durum1 == 0)
                {
                    Console.WriteLine("Başlık =  {0}", item.Baslik1);
                    Console.WriteLine("İçerik  = {0}", item.İçerik1);
                    Console.WriteLine("Kart Sahibi = {0}", person.Find(item.KartSahibi1));
                    Console.WriteLine("kart Büyüklüğü = {0}", (Büyüklük)int.Parse(item.Büyüklük1));
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*******************************************");
            foreach (var item in list)
            {
                if (item.Durum1 == 1)
                {
                    Console.WriteLine("Başlık =  {0}", item.Baslik1);
                    Console.WriteLine("İçerik  = {0}", item.İçerik1);
                    Console.WriteLine("Kart Sahibi = {0}", item.KartSahibi1);
                    Console.WriteLine("kart Büyüklüğü = {0}", item.Büyüklük1);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" DONE Line");
            Console.WriteLine("*******************************************");
            foreach (var item in list)
            {
                if (item.Durum1 == 2)
                {
                    Console.WriteLine("Başlık =  {0}", item.Baslik1);
                    Console.WriteLine("İçerik  = {0}", item.İçerik1);
                    Console.WriteLine("Kart Sahibi = {0}", item.KartSahibi1);
                    Console.WriteLine("kart Büyüklüğü = {0}", item.Büyüklük1);
                }
            }

        }

        public void Delete()
        {
            List<CardModel> list = new List<CardModel>();
            Console.WriteLine("Kartları Silme Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Silmek istediğiniz kartın başlığını giriniz");
            String veri = Console.ReadLine();
            list = toDo.Find(veri, "", "", "");
            if (list.Count <= 0)
            {
                Console.WriteLine("Aradığınız Card Bulunamadı");
                Console.WriteLine("Tekrar Denemek İçin (1)");
                Console.WriteLine("İşlemi İptal etmek için (2)");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == 1)
                {
                    Delete();
                }
                if (sayi == 2)
                {

                }
            }
            else
            {
                Console.WriteLine("{0} kart ı silmek istiyor musunuz Y/N", list[0].Baslik1);
                string YN = Console.ReadLine();
                if (YN == "Y")
                {
                    toDo.Delete(list[0]);
                    Console.WriteLine("İşlem Başarıyla Gerçekleşti");
                }
                else
                {
                    Console.WriteLine("İşlem Başarıyla İptal Edildi");
                }
            }
        }

        public void transfer()
        {
            List<CardModel> list = new List<CardModel>();
            Console.WriteLine("Kart Taşıma Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Taşımak istediğiniz kartın kart başlığını giriniz");
            string veri = Console.ReadLine();
            list = toDo.Find(veri, "", "", "");
            if (list.Count <= 0)
            {
                Console.WriteLine("Aradığınız Card Bulunamadı");
                Console.WriteLine("Tekrar Denemek İçin (1)");
                Console.WriteLine("İşlemi İptal etmek için (2)");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == 1)
                {
                    transfer();
                }
                if (sayi == 2)
                {

                }
            }
            else
            {
                Console.WriteLine("Bulunan kart bilgiler");
                Console.WriteLine("*******************************************");
                foreach (var item in list)
                {
                    Console.WriteLine("Başlık =  {0}", item.Baslik1);
                    Console.WriteLine("İçerik  = {0}", item.İçerik1);
                    Console.WriteLine("Kart Sahibi = {0}", item.KartSahibi1);
                    Console.WriteLine("kart Büyüklüğü = {0}", item.Büyüklük1);
                    Console.WriteLine("Durum = {0}", item.Durum1);
                    Console.WriteLine("****** ****** ****** ******");
                l:
                    Console.WriteLine("Lütfen taşımak istediğiniz Durum'u seçiniz");
                    Console.WriteLine("(0) TODO");
                    Console.WriteLine("(1) IN PROGRESS");
                    Console.WriteLine("(2) DONE");

                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi < 0 || sayi > 2)
                    {
                        Console.WriteLine("Yanlış bir Büyüklük seçtiniz");
                        goto l;
                    }
                    item.Durum1 = sayi;
                }
            }
        }
    }



    public class ToDo
    {
        private List<CardModel> Card;

        public ToDo()
        {
            Card = new List<CardModel>();
        }

        public List<CardModel> Liste()
        {
            return Card;
        }

        public void Add(string baslik, string içerik, string kartsahibi, string büyüklük)
        {
            CardModel cardModel = new CardModel();
            cardModel.Baslik1 = baslik;
            cardModel.İçerik1 = içerik;
            cardModel.KartSahibi1 = kartsahibi;
            cardModel.Büyüklük1 = büyüklük;
            Card.Add(cardModel);
        }

        public void Delete(CardModel cardModel)
        {
            Card.Remove(cardModel);
        }

        public List<CardModel> Find(string baslik, string içerik, string kartsahibi, string büyüklük)
        {
            List<CardModel> result = new List<CardModel>();

            foreach (var item in Card)
            {
                if (item.Baslik1 == baslik || item.İçerik1 == içerik || item.KartSahibi1 == kartsahibi || item.Büyüklük1 == büyüklük)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }

    public class TodoPersonModel
    {
        private string No;
        private string İsim;
        private string Soyisim;

        public string No1 { get => No; set => No = value; }
        public string İsim1 { get => İsim; set => İsim = value; }
        public string Soyisim1 { get => Soyisim; set => Soyisim = value; }
    }

    public class person
    {
        private List<TodoPersonModel> personn;

        public person()
        {
            personn = new List<TodoPersonModel>();
        }

        public void Add(string no, string isim, string soyisim)
        {
            TodoPersonModel personModel = new TodoPersonModel();
            personModel.No1 = no;
            personModel.İsim1 = isim;
            personModel.Soyisim1 = soyisim;
            personn.Add(personModel);
        }

        public string Find(string sayi)
        {
            string result = "";

            foreach (var item in personn)
            {
                if (item.No1 == sayi)
                {
                    result = item.İsim1 + " " + item.Soyisim1;
                }
            }
            return result;
        }

        public bool varmı(string sayi)
        {
            bool result = false;

            foreach (var item in personn)
            {
                if (item.No1 == sayi)
                {
                    result = true;
                }
            }
            return result;
        }
    }

    public class CardModel
    {
        private string Baslik;
        private string İçerik;
        private string KartSahibi;
        private string Büyüklük;
        private int Durum = 0;

        public string Baslik1 { get => Baslik; set => Baslik = value; }
        public string İçerik1 { get => İçerik; set => İçerik = value; }
        public string KartSahibi1 { get => KartSahibi; set => KartSahibi = value; }
        public string Büyüklük1 { get => Büyüklük; set => Büyüklük = value; }
        public int Durum1 { get => Durum; set => Durum = value; }
    }

    public enum Büyüklük
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}
