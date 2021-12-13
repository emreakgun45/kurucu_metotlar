using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class SinifAdi
            //{
            //  [Erişim Belirleyici][Veri Tipi] ÖzellikAdi;
            //  [Erişim Belirleyici][Veri Tipi] MetotAdi[Parametre Listesi];
            //  {
                //Metot Komutları
            //  }    
            //}

            //Erişim Belirleyiciler
            //*Public
            //*Private
            //*Internal
            //*Protected
            System.Console.WriteLine("***********Çalışan 1**********");

            Calisan calisan1 = new Calisan("Ayşe","Kara",23425634,"İnsan Kaynakları");

            calisan1.CalisanBilgileriListele();
            System.Console.WriteLine("***********Çalışan 2**********");

            Calisan calisan2 = new Calisan();

            calisan2.Ad="Deniz";
            calisan2.SoyAd="Arda";
            calisan2.No= 25646789;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgileriListele();
        }
    }

    class Calisan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyAd, int no, string departman)
        {
            this.Ad = ad;
            this.SoyAd = soyAd;
            this.No = no;
            this.Departman = departman;
        }
        //OverLoad etmek(Aşırı yüklemek)
        public Calisan(string ad, string soyAd)
        {
            this.Ad = ad;
            this.SoyAd = soyAd;
        }

        public Calisan()
        {
        }

    


        public void CalisanBilgileriListele()
        {
            System.Console.WriteLine("Çalışanın Adı:{0}",Ad);
            System.Console.WriteLine("Çalışanın Soyadı:{0}",SoyAd);
            System.Console.WriteLine("Çalışanın Numarası:{0}",No);
            System.Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
        }

    }
}
