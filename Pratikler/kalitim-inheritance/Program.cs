using System;

namespace kalitim_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.Beslenme();
            tohumluBitki.Bosaltim();
            tohumluBitki.Solunum();
            tohumluBitki.FotosentezYapmak();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("**********************");

            Ordek ordek = new Ordek();
            ordek.Solunum();
            ordek.Beslenme();
            ordek.Bosaltim();
            ordek.SuruHalindeHareket();
            ordek.Yuzmek();
        }
    }
}
