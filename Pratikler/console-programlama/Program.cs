using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Hello " + name + " " + surname);
        }
    }
}
