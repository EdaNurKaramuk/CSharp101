using System;

namespace metotlar_recursive_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Öz Yinelemeli
            // 3 üzeri 4 hesaplanması -> 3*3*3*3
            int result = 1;
            for(int i = 1; i <= 4; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);

            Islemler islemler = new Islemler();
            Console.WriteLine(islemler.Expo(3,4));

            //Extension Metotlar
            string ifade = "Eda Nur Karamuk";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            //Int diziyi sıralayan extension için
            int[] dizi = {9, 3, 6, 2, 1, 5, 0};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if(us < 2)
                return sayi;
            return Expo(sayi,us-1) * sayi;
        }
        //Expo(3,4)
        //Expo(3,3) * 3
        //Expo(3,2) * 3 * 3
        //Expo(3,2) * 3 * 3 * 3
        // 3 * 3 * 3 * 3
    }

    //Class ve metotlar static olmalı.
    public static class Extensions
    {
        //Boşluk kontrolü yapan metot
        public static bool CheckSpaces(this string param)
        {
            //this anahtar kelimesi ile, bu extension metod yalnızda string tipindeki veriler için kullanılabilir demektir.
           return param.Contains(" ");
        }

        //Boşluk var ise, o boşlukları silen metot
        public static string RemoveSpaces(this string param)
        {
            //Bu string'i, boşluklara göre ayır ve diziye ata.
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        //String ifadedeki harfleri büyük harfe çeviren metot.
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        //String ifadedeki harfleri küçük harfe çeviren metot.
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        //Int diziyi sıralayan extension
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        //Int diziyi ekrana yazdıran extension
        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            //0. indexten başlayıp, bir karakter getir bana. Yani ilk karakteri getirmiş olacak.
            return param.Substring(0,1);
        }
    }
}
