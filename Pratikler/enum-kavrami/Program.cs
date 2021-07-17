using System;

namespace enum_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazar);

            int sicaklik = 32;
            if(sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            }
            else if(sicaklik >= (int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
            }
            else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Hadi dışarıya çıkalım.");
            }
        }
    }

    enum Gunler
    {
        // Pazartesi,
        Pazartesi = 1, // Bu şekilde index 1'den başlar. Normalde 0.
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        //Programda kullanacağımız sabit normları belirliyoruz.
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}
