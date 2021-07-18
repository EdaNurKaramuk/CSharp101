using System;

namespace arayuzler_interface_ornek
{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }
    }
}