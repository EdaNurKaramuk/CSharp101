using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz";
            string degisken2 = "CSharp";

            //Length
            Console.WriteLine("--- Karakter Sayısı ---");
            Console.WriteLine(degisken.Length);

            //ToUpper - ToLower
            Console.WriteLine("--- ToUpper ToLower ---");
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            //Merhaba ile birleştirsin.
            Console.WriteLine("--- Concat ---");
            Console.WriteLine(string.Concat(degisken, " Merhaba"));

            //Compare - CompareTo
            Console.WriteLine("--- CompareTo ---");
            //1. değişken 2. değişkene eşit olursa 0 döner, 1. değişken 2. değişkenden daha büyük karakter sayısına sahipse 1 döner; daha küçükse -1 döner.
            Console.WriteLine(degisken.CompareTo(degisken2));

            Console.WriteLine("--- Compare ---");
            //true -> Remove case sensitive
            //false -> Case sensitive
            Console.WriteLine(string.Compare(degisken, degisken2, true));
            Console.WriteLine(string.Compare(degisken, degisken2, false));

            //Contains
            Console.WriteLine("--- Contains ---");
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            Console.WriteLine("--- IndexOf ---");
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Eda"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine("--- Insert ---");
            Console.WriteLine(degisken.Insert(0, "Merhabalar "));
            
            //PadLeft - PadRight
            //2. değişkenin soluna 30'a tamamlayacak kadar boşluk ekler. Eğer karakter sayıs 30'dan büyük olsaydı hiçbir şey olmayacaktı.
            Console.WriteLine("--- PadLeft & PadRight ---");
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30 , '*'));

            Console.WriteLine(degisken.PadRight(32) + degisken2);
            Console.WriteLine(degisken.PadRight(32, '-') + degisken2);

            //Remove
            Console.WriteLine("--- Remove ---");
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine("--- Replace ---");
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine("--- Split ---");
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine("--- Substring ---");
            //4. index'ten başlayarak sonuna kadar getirir.
            Console.WriteLine(degisken.Substring(4));
            //4. index'ten başlayarak 6 karakter getirir.
            Console.WriteLine(degisken.Substring(4,6));
        }
    }
}
