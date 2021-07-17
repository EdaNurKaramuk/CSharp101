using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan c1 = new Calisan("Ayşe", "Yılmaz", "İK");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan c2 = new Calisan("Deniz", "Arda", "İK");
            Calisan c3 = new Calisan("Eda", "Karamuk", "BT");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            //Static Class Kullanımı
            Console.WriteLine("Toplam= " + Islemler.Topla(100,200));
            Console.WriteLine("Toplam= " + Islemler.Cikar(400,50));
        }
    }

    class Calisan
    {
        private static int calisanSayisi; //Field
        private string isim;
        private string soyisim;
        private string departman;

        public static int CalisanSayisi { get => calisanSayisi; } //Property

        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi++;
        }

        static Calisan()
        {
            calisanSayisi = 0;
        }
    }


    //Static class'ın içerisindeki propert, metodlar da static olmak zorundadır. Ve static class'tan kalıtım alınamaz.
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
