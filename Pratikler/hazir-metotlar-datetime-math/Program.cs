using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //Günün tarihi
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            
            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //09
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Fri
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Friday

            Console.WriteLine(DateTime.Now.ToString("MM")); //07
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Jly
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //July

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021

            //Math Kütüphanesi
            Console.WriteLine("****** Math Kütüphanesi ******");
            Console.WriteLine(Math.Abs(-25)); //Mutlak Değer
            Console.WriteLine(Math.Sin(10)); //Cos, Tan...

            //22.3'ten büyük, en küçük tamsayıyı getirir. -> 23
            Console.WriteLine(Math.Ceiling(22.3)); 

            //Hangisine daha yakınsa onu getirir. -> 22
            Console.WriteLine(Math.Round(22.3)); 
            Console.WriteLine(Math.Round(22.7));

            //22.7'den küçük, en büyük tamsayıyı getirir. -> 22 
            Console.WriteLine(Math.Floor(22.7));

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4)); // 3^4 = 81
            Console.WriteLine(Math.Sqrt(9)); // Karekök alır. -> 3
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Exp(3)); // e^3
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı
            
        }
    }
}
