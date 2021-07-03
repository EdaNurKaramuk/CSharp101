using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Hataya neden olabilecek kod yazılır.
                 Console.WriteLine("Bir sayı giriniz.");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz Sayı: " + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message.ToString());
            }
            finally
            {
                //Bir kod bloğu hata alsın ya da almasın, her koşulda çalışmasını istediğimiz kod bloğunu buraya yazarız.
                Console.WriteLine("İşlem tamamlandı.");
            }

            Console.WriteLine("-----------------------------");

            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("-----------------------------");

            try
            {
                int b = int.Parse("test");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("-----------------------------");

            try
            {
                byte c = byte.Parse("256");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }
}
