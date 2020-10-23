
using System;

namespace Merkkijonolaskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijonolaskin v1.0");
            Console.WriteLine("Anna luvut pilkulla erotettuna: ");

            string syote = Console.ReadLine();

            Merkkijonolaskin laskin = new Merkkijonolaskin();
            Console.WriteLine("Lukujen summa on: " + laskin.Laske(syote));
        }
    }
}

