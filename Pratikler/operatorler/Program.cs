using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Atama
            int x = 3;
            int y = 3;

            y = y + 3;
            y+=3;
            y/=9;

            x*=2;

            Console.WriteLine("x:" + x + " " + "y:" + y);

            //Mantıksal Operatörler
            // ||, &&, !
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }

            if(isSuccess || isCompleted)
            {
                Console.WriteLine("Great!");
            }

            if(isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }
            
            //İlişkisel Operatörler
            // <, >, <=, >=, ==, !=
            int a = 3;
            int b = 4;

            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc= a > b;
            Console.WriteLine(sonuc);
            sonuc= a >= b;
            Console.WriteLine(sonuc);
            sonuc= a <= b;
            Console.WriteLine(sonuc);
            sonuc= a == b;
            Console.WriteLine(sonuc);
            sonuc= a != b;
            Console.WriteLine(sonuc);

            //Aritmetik Operatörler
            // /, *, +, -
            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);

            //sonuc1 = sayi1++; -> sayi1 önce sonuc1'e atanır, sonra bir arttırılır.
            //sonuc1 = ++sayi1; -> Önce sayi1 bir arttırılır, sonrasında sonuc1'e atanır.
            sonuc1 = ++sayi1;
            Console.WriteLine(sonuc1);

            // % : Mod alır.
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);
        }
    }
}
