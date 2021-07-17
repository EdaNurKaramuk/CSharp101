using System;

namespace kalitim_inheritance
{
    public class Bitkiler : Canlilar
    {
        public void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir.");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.UyaranlaraTepki();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }

}