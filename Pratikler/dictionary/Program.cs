using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic
            //key -> int ; value -> string olsun dedik.
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();
            
            kullanicilar.Add(10, "Ayşe Yılmaz");
            //Key'ler unique olmalı.
            kullanicilar.Add(12, "Ahmet Yılmaz");
            //kullanicilar.Add(12, "Mehmet Yıldırım");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Coşar");

            //Elemanlara erişim
            Console.WriteLine("*** Elemanlara Erişim ***");
            Console.WriteLine(kullanicilar[12]); //key'i 12 olan elemanı getir. Index mantığı gibi.

            foreach(var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("*** Count ***");
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine("*** Contains ***");
            Console.WriteLine(kullanicilar.ContainsKey(10));
            Console.WriteLine(kullanicilar.ContainsValue("Eda Karamuk"));

            //Remove
            Console.WriteLine("*** Remove ***");
            kullanicilar.Remove(12);
            foreach(var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Keys
            //Values
            Console.WriteLine("*** Keys ***");
            foreach(var item in kullanicilar)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine();
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*** Values ***");
            foreach(var item in kullanicilar)
            {
                Console.WriteLine(item.Value);
            }
             Console.WriteLine();
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
