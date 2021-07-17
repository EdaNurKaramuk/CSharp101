using System;

namespace kurucu_metotlar
{
    class Program
    {
        //Erişim Belirleyiciler
        //public -> Her yerden erişilebilir.
        //private -> Sadece tanımlandığı class'tan erişilebilir.
        //protected -> Sadece tanımlandığı class'ta veya sınıftan miras alan diğer sınıflardan erişilebilir.
        //internal -> Sadece bulunduğu proje içerisinderişilebilir.
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.ad = "Ayşe";
            calisan1.soyad = "Kara";
            calisan1.no = 23415634;
            calisan1.departman = "İnsan Kaynakları";

            calisan1.CalisanBilgileri();

            Console.WriteLine("--------------------");

            Calisan calisan2 = new Calisan();
            calisan2.ad = "Deniz";
            calisan2.soyad = "Arda";
            calisan2.no = 25646789;
            calisan2.departman = "Satın Alma";

            calisan2.CalisanBilgileri();

            Console.WriteLine("--------------------");

            Calisan calisan3 = new Calisan("Eda", "Karamuk", 85674616, "Bilişim");
            calisan3.CalisanBilgileri();

            Console.WriteLine("--------------------");

            Calisan calisan4 = new Calisan("Mehmet", "Çınar");
            calisan4.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;

        //Constructor - Kurucu Metot
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.no = no;
            this.departman = departman;
        }

        //Constructor da overload edilebilir.
        public Calisan()
        {

        }

        public Calisan(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", ad);
            Console.WriteLine("Çalışan Soyadı: {0}", soyad);
            Console.WriteLine("Çalışan Numarası: {0}", no);
            Console.WriteLine("Çalışan Departmanı: {0}", departman);
        }
    }

}
