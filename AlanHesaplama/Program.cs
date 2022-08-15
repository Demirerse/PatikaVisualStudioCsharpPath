using System;
using System.Collections.Generic;

namespace AlanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ara beni bul beni Manyak Manyak işler hesap makinesine hoş geldiniz \nBasic alan hacim vs hesaplayacağız!");

            
            Geometri geo = new Geometri();
            
            string programDevam = "";
            while (programDevam != "exit")
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)  \nProgramdan Çıkış için 'exit' giriniz");
                Console.WriteLine("? ? ? ? ? ? ?");
                Console.WriteLine("(1) Alan Hesaplamak");
                Console.WriteLine("(2) Çevre Hesaplama");
                Console.WriteLine("(3) Hacim Hesaplamak");


                programDevam = Console.ReadLine().ToLower();
                // System.Console.WriteLine("Seçilen Program: " + programDevam);
                switch (programDevam)
                {
                    case "1":
                        geo.AlanHesaplama();
                        break;
                    case "2":
                        geo.CevreHesaplama();
                        break;
                    case "3":
                        Console.WriteLine("3 boyuta girmeye hazır değilim :)");
                        break;
                    
                    case "exit": break;
                    default:
                        Console.WriteLine("1-3 arası program seçiniz ya da exit ile çıkınız.");
                        break;
                }
            }

        }
    }

    class Geometri
    {
        //todo
        //error handling eksik!
        readonly List<GeometrikSekil> sekiller = new List<GeometrikSekil>();

        public Geometri()
        {
            sekiller.Add(new GeometrikSekil("Üçgen", 3));
            sekiller.Add(new GeometrikSekil("Daire", 0));
            sekiller.Add(new GeometrikSekil("Kare", 1));
            sekiller.Add(new GeometrikSekil("Dikdörtgen", 2));
        }

        public void AlanHesaplama()
        {

            GeometrikSekil hangiSekil = new GeometrikSekil();
            Console.WriteLine("(1) Alan Hesaplamak");
            Console.WriteLine("Hesaplamak istediğiniz cismin kodunu giriniz.");
            Console.WriteLine("Elimizdeki cisimler ;");
            Console.WriteLine("Kare = 1 ,\nDikdörtgen = 2, \nÜçgen = 3, \nDaire = 4 \n.. Şimdilik..");
            hangiSekil.Sekil = Console.ReadLine().ToLower();

            switch (hangiSekil.Sekil)
            {
                case "1":
                    KareAlanHesaplama();
                    break;

                case "2":
                    DikdortgenAlanHesaplama();
                    break;

                case "3":
                    UcgenAlanHesaplama();
                    break;

                case "4":
                    DaireAlanHesaplama();
                    break;
            }
            //Console.WriteLine("Girdiğiniz cisme göre kenar bilgilerini giriniz");
            //hangiSekil.KoseSayisi = Convert.ToInt32(Console.ReadLine());
            

            static void DikdortgenAlanHesaplama()
            {
                int ukenar = 0, kkenar = 0, alan = 0, cevre = 0;
                Console.Write("Dikdörtgenin uzun kenarını giriniz:");
                ukenar = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dikdörtgenin kısa kenarını giriniz:");
                kkenar = Convert.ToInt32(Console.ReadLine());
                alan = ukenar * kkenar;
                cevre = (ukenar + kkenar) * 2;
                Console.WriteLine("Çevre= {0} \nAlan= {1}", cevre, alan);
                Console.ReadKey();
            }

            static void KareAlanHesaplama()
            {
                int kenar = 0, alan = 0, cevre = 0;
                Console.Write("Karenin bir kenar uzunluğunu giriniz:");
                kenar = Convert.ToInt32(Console.ReadLine());
                alan =Convert.ToInt32 (Math.Pow(kenar, 2));
                cevre = (kenar) * 4;
                Console.WriteLine("Çevre= {0} \nAlan= {1}", cevre, alan);
                Console.ReadKey();
            }

            static void UcgenAlanHesaplama()
            {
                int kenar, yukseklik, alani;

                Console.Write("Üçgenin kenar uzunluğunu giriniz: ");

                kenar = Convert.ToInt32(Console.ReadLine());

                Console.Write("Üçgenin yüksekliği giriniz : ");

                yukseklik = Convert.ToInt32(Console.ReadLine());

                alani = kenar * yukseklik / 2;

                Console.WriteLine("Üçgenin alanı = " + alani);
            }

            static void DaireAlanHesaplama()
            {
                const double pi = 3.14;
                double cevre, alan, r;
                Console.Write("Yarıçapı Gir : ");
                r = Convert.ToDouble(Console.ReadLine());
                cevre = 2 * pi * r;
                alan = pi * r * r;
                Console.WriteLine("===============================");
                Console.WriteLine("Alan: " + alan);
                Console.WriteLine("Çevre: " + cevre);
                Console.ReadKey();
            }

        }

        public void CevreHesaplama()
        {
            GeometrikSekil hangiSekil = new GeometrikSekil();
            Console.WriteLine("(2) Çevre Hesaplamak");
            Console.WriteLine("Hesaplamak istediğiniz cismin kodunu giriniz.");
            Console.WriteLine("Elimizdeki cisimler ;");
            Console.WriteLine("Kare = 1 ,\nDikdörtgen = 2, \nÜçgen = 3, \nDaire = 4 \n.. Şimdilik..");
            hangiSekil.Sekil = Console.ReadLine().ToLower();

            switch (hangiSekil.Sekil)
            {
                case "1":
                    KareCevreHesaplama();
                    break;

                case "2":
                    DikdortgenCevreHesaplama();
                    break;

                case "3":
                    UcgenCevreHesaplama();
                    break;

                case "4":
                    DaireCevreHesaplama();
                    break;
            }
            


            static void DikdortgenCevreHesaplama()
            {
                int ukenar = 0, kkenar = 0, alan = 0, cevre = 0;
                Console.Write("Dikdörtgenin uzun kenarını giriniz:");
                ukenar = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dikdörtgenin kısa kenarını giriniz:");
                kkenar = Convert.ToInt32(Console.ReadLine());
                alan = ukenar * kkenar;
                cevre = (ukenar + kkenar) * 2;
                Console.WriteLine("Çevre= {0} \nAlan= {1}", cevre, alan);
                Console.ReadKey();
            }

            static void KareCevreHesaplama()
            {
                int kenar = 0, alan = 0, cevre = 0;
                Console.Write("Karenin bir kenar uzunluğunu giriniz:");
                kenar = Convert.ToInt32(Console.ReadLine());
                alan = Convert.ToInt32(Math.Pow(kenar, 2));
                cevre = (kenar) * 4;
                Console.WriteLine("Çevre= {0} \nAlan= {1}", cevre, alan);
                Console.ReadKey();
            }

            static void UcgenCevreHesaplama()
            {
                int kenar1, kenar2, kenar3, cevre;

                Console.Write("Üçgenin 1.kenar uzunluğunu giriniz: ");
                kenar1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Üçgenin 2.kenar uzunluğunu giriniz: ");
                kenar2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Üçgenin 3.kenar uzunluğunu giriniz: ");
                kenar3 = Convert.ToInt32(Console.ReadLine());


                cevre = kenar1+ kenar2+ kenar3;

                Console.WriteLine("Üçgenin çevresi = " + cevre);

            }

            static void DaireCevreHesaplama()
            {
                const double pi = 3.14;
                double cevre, alan, r;
                Console.Write("Yarıçapı Gir : ");
                r = Convert.ToDouble(Console.ReadLine());
                cevre = 2 * pi * r;
                alan = pi * r * r;
                Console.WriteLine("===============================");
                Console.WriteLine("Alan: " + alan);
                Console.WriteLine("Çevre: " + cevre);
                Console.ReadKey();
            }
        }
    }

    class GeometrikSekil
    {
        string sekil;
        int koseSayisi;

        public string Sekil { get => sekil; set => sekil = value; }
        public int KoseSayisi { get => koseSayisi; set => koseSayisi = value; }

        public GeometrikSekil(string sekil, int koseSayisi)
        {
            Sekil = sekil;
            KoseSayisi = koseSayisi;
        }

        public GeometrikSekil()
        {
        }
    }
}
