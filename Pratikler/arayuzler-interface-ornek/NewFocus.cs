using System;

namespace arayuzler_interface_ornek
{
    public class NewFocus : Otomobil
    {
        //Abstract metodu implemente etmek zorundayız.
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }
    }
}