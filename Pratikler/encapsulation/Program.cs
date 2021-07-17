using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Ayşe";
            ogrenci1.Soyad = "Yılmaz";
            ogrenci1.OgrenciNo = 293;
            ogrenci1.Sinif = 3;
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();
            
            Ogrenci ogrenci2 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();

            Ogrenci ogrenci3 = new Ogrenci("Eda", "Karamuk", 133, 12);
            ogrenci3.OgrenciBilgileriniGetir();
            ogrenci3.SinifAtlat();
            ogrenci3.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string ad;
        private string soyad;
        private int ogrenciNo;
        private int sinif;


        //propfull + Tab ile otomatik oluşturulabilir.
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Soyad { get => soyad; set => soyad = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }
                else if(value > 12)
                {
                    Console.WriteLine("Sınıf en fazla 12 olabilir.");
                    sinif = 12;
                }
                else
                {
                    sinif = value;
                }
            } 
        }

        
        public Ogrenci()
        {
            
        }

        public Ogrenci(string ad, string soyad, int ogrenciNo, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***** Öğrenci Bilgileri *****");
            Console.WriteLine("Öğrencinin Adı:   {0}", Ad);
            Console.WriteLine("Öğrencinin Soyadı:   {0}", Soyad);
            Console.WriteLine("Öğrencinin Öğrenci Numarası:   {0}", OgrenciNo);
            Console.WriteLine("Öğrencinin Sınıfı:   {0}", Sinif);
        }

        public void SinifAtlat()
        {
            Sinif = Sinif + 1;
        }
        
        public void SinifDusur()
        {
            Sinif = Sinif - 1;
        }
    }
}
