using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Out parametreler
            string sayi = "999";
            //sayi'nin çevirilip çevirilemeyeceğini kontrol et.
            bool result = int.TryParse(sayi, out int outSayi);
            if(result)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar metotlar = new Metotlar();
            metotlar.Topla(2,3,out int sonuc);
            Console.WriteLine(sonuc);

            //Metot Aşırı Yükleme - Overloading

            int ifade = 999;
            metotlar.EkranaYazdir(ifade.ToString());
            metotlar.EkranaYazdir(ifade);
            metotlar.EkranaYazdir("Eda","Karamuk");

            //Metot İmzası
            //Metot adı + parametre sayısı + parametre tipi
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
