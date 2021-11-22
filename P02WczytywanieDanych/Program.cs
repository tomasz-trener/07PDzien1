using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WczytywanieDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jakiś tekst");
            string zmiennaTekstowa= Console.ReadLine();

            zmiennaTekstowa = zmiennaTekstowa.ToUpper();

            Console.WriteLine(zmiennaTekstowa);

            Console.WriteLine("Podaj liczbe");
            string zmiennaTekstowa2 = Console.ReadLine();

            int liczba = Convert.ToInt32(zmiennaTekstowa2);

            liczba++;

            int liczba2 = liczba + liczba;

            Console.WriteLine(liczba2);

            Console.ReadKey();
        }
    }
}
