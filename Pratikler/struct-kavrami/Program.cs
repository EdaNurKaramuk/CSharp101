using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            // dikdortgen.kisaKenar = 3;
            // dikdortgen.uzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı= {0}", dikdortgen.AlanHesapla());

            //Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
            //new ile nesnesini oluşturmadan da property'lere erişilebilir.
            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct(3,4);
            Console.WriteLine("Struct Alan Hesabı= {0}", dikdortgen_Struct.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen()
        {
            kisaKenar = 3;
            uzunKenar = 4;
        }

        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int kisaKenar;
        public int uzunKenar;

        //Struct'ta, parametresiz constructor oluşturulmasına izin verilmedi.
        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }
}
