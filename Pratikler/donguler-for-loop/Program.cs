using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdırma.
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if(i % 2 == 1)
                    Console.WriteLine(i);
            }


            //1 ile 1000 arasındaki tek ve çift sayıların toplamını hesaplayıp ekrana yazdırma.
            int ciftToplam = 0;
            int tekToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i % 2 == 1)
                    tekToplam += i;
                else if(i % 2 == 0)
                    ciftToplam += i; //cT = cT + i;
            }
            Console.WriteLine("Tek Sayılar Toplamı= " + tekToplam);
            Console.WriteLine("Çift Sayılar Toplamı= " + ciftToplam);

            //break - continue
            //break -> Döngüden çıkmak için
            //continue -> Bir şarta bağlı olarak mevcut döngüde o case'in atlanması için
            Console.WriteLine("*** break ***");
            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    break;
                Console.WriteLine(i);
            }

            Console.WriteLine("*** continue ***");
            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
