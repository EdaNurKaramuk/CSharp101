using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // erisim_belirteci geri_donusTipi metot_adi(parametreListesi/arguman)
            // {
                //komutlar
            // }

            int a = 2;
            int b = 3;

            Console.WriteLine(a+b);

            int result = Topla(a,b);
            Console.WriteLine(result);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(result.ToString());

            int result2 = ornek.ArttirVeTopla(a,b);
            ornek.EkranaYazdir(result2.ToString());

            int result3 = ornek.ArttirVeToplaRef(ref a, ref b);
            ornek.EkranaYazdir(result3.ToString());
        }

        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(int sayi1, int sayi2)
        {
            sayi1 += 1;
            sayi2 += 1;
            return sayi1 + sayi2;
        }

        public int ArttirVeToplaRef(ref int sayi1, ref int sayi2)
        {
            sayi1 += 1;
            sayi2 += 1;
            return sayi1 + sayi2;
        }
    }
}
