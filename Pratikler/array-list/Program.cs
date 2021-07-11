using System;
using System.Collections;
using System.Collections.Generic;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //İçerisindeki verilere erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange -> Birden fazla elemanı toplu halde nasıl ekleriz
            Console.WriteLine("*** AddRange ***");
            string[] renkler = {"Kırmızı", "Sarı", "Yeşil"};
            List<int> sayilar = new List<int>(){1, 3, 7, 9, 92, 5};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("*** Sort ***");
            //Sadece sayilar generic list'ini bırakıp Sort'u, Binary Search'ü ve de Reverse'ü kullandık.
            //liste.Sort(); //Runtime esnasında hata verir.

            //Binary Search
            Console.WriteLine("*** Binary Search ***");
            //Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("*** Reverse ***");
            //Console.WriteLine(liste.Reverse());
            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // }

            //Clear
            Console.WriteLine("*** Clear ***");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
