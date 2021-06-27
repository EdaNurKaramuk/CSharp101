using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case sensitive
            // string degisken = null;
            // string Degisken = null;

            // int deger = 2;
            // Console.WriteLine(deger);

            //Veri Tipleri
            String degisken = " ";
            byte b = 5;     //1 byte
            sbyte sb = 5;   //1 byte
            short s = 5;    //2 byte
            ushort us = 5;  //2 byte
            Int16 i16 = 2;  //2 byte
            int i = 2;      //4 byte
            Int32 i32= 2;   //4 byte
            Int64 i64 = 2;  //8 byte
            uint ui = 2;    //4 byte
            long l = 4;     //8 byte
            ulong ul = 4;   //8 byte

            //Reel Sayılar İçin
            float f = 5;    //4 byte
            double d = 5;   //8 byte
            decimal de = 5; //16 byte

            char ch = 'E';          //2 byte
            string str = "Eda";     //Sınırsız

            bool bl1 = false;
            bool bl2 = true;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //String ifadeler
            string str1 = null;
            string str2 = string.Empty;
            str2 = "Eda Karamuk";
            string ad = "Eda";
            string soyad = "Karamuk";
            string tamIsim = ad + " " + soyad;

            //Integer tanımlama şekilleri
            int int1 = 5;
            int int2 = 3;
            int carpim = int1 * int2;

            //Boolean
            bool bool1 = 10<2;

            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);
            
            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);

            //datetime
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            //Gün, ay ve yılı aralarında nokta ile getir.
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            //saat
            string dateTime3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(dateTime3);
        }
    }
}
