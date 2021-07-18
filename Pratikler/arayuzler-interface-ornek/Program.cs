using System;

namespace arayuzler_interface_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++INTERFACE++++++++++");

            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Console.WriteLine("+++++++++++++++++");
            
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            
            Console.WriteLine("+++++++ABSTRACT++++++++++");

            NewFocus newFocus = new NewFocus();
            Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur());
            Console.WriteLine(newFocus.StandartRengiNe().ToString());
            
            Console.WriteLine("+++++++++++++++++");

            NewCivic newCivic = new NewCivic();
            Console.WriteLine(newCivic.HangiMarkaninAraci().ToString());
            Console.WriteLine(newCivic.KacTekerlektenOlusur());
            Console.WriteLine(newCivic.StandartRengiNe().ToString());
            
        }
    }
}
