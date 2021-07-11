using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T -> Object türündedir. Listenin içerisindeki nesnelerin tipini ifade eder.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count -> Eleman sayısı
            Console.WriteLine("*** Count ***");
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Elemanları Ekrana Yazdırma
            //foreach
            Console.WriteLine("*** Elemanları Ekrana Yazdırma ***");
            foreach(var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            //List.ForEach
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Eleman çıkarma
            Console.WriteLine("*** Eleman çıkarma ***");
            sayiListesi.Remove(4); //4 elemanını çıkar.
            renkListesi.Remove("Yeşil"); //Yeşil elemanını çıkar.
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0); //0. indexteki elemanı çıkar.
            renkListesi.RemoveAt(1); //1. indexteki elemanı çıkar.
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            Console.WriteLine("*** Liste içerisinde arama ***");
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste içerisinde bulundu.");
            }

            //Eleman ile index'e erişme
            Console.WriteLine("*** Eleman ile index'e erişme ***");
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi List'e çevirme
            Console.WriteLine("*** Diziyi List'e çevirme ***");
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);
            
            //Listeyi temizleme
            Console.WriteLine("*** Listeyi temizleme ***");
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            Console.WriteLine("*** List içerisinde nesne tutmak ***");
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Eda";
            kullanici1.Soyisim = "Karamuk";
            kullanici1.Yas = 21;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Ayşe";
            kullanici2.Soyisim = "Yılmaz";
            kullanici2.Yas = 15;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 32
            });

            foreach (Kullanicilar kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcının Yaşı: " + kullanici.Yas);
            }

            yeniListe.ForEach(yeniKullanici => Console.WriteLine("Kullanıcının Adı Soyadı ve Yaşı: " + yeniKullanici.Isim + " " + yeniKullanici.Soyisim +  " - " + yeniKullanici.Yas));

            yeniListe.Clear();
        }
    }

    public class Kullanicilar
    {
        string isim; 
        string soyisim;
        int yas;

        //Encapsulation
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }

}
