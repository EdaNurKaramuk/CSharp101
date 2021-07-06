using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //1'den başlayarak consoledan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp consolea yazdıran program
            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama: " + (toplam/sayi));

            //a'dan z'ye kadar tüm harfleri console'a yazdıran program
            char karakter = 'a';
            while (karakter <= 'z')
            {
                Console.Write(karakter);
                karakter++;
            }
            
            Console.WriteLine();
            Console.WriteLine("****** Foreach ******");

            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
