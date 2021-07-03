using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int dateMonth = DateTime.Now.Month;

            //Expression
            switch (dateMonth)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi.");
                    break;
            }

            switch (dateMonth)
            {
                case 1:
                case 2:
                    Console.WriteLine("Kış Ayı");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Ayı");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Ayı");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Ayı");
                    break;
                case 12:
                    goto case 1;
                default:
                    Console.WriteLine("Yanlış veri girişi.");
                    break;
            }
        }
    }
}
