using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieTekst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int wyn = a + b;

            //Console.WriteLine("wynik to "+ wyn);

            int dlugosc = Convert.ToString(wyn).Length;

            //Console.WriteLine("długośc to " + dlugosc);

            string s1 = "wynik to " + wyn + " a liczba znaków to: " + dlugosc;
            string s2 = $"wynik to {wyn} a liczba znaków to: {dlugosc}";
            string s3 = string.Format("wynik to {0} a liczba znaków to: {1}", wyn, dlugosc);

            Console.WriteLine(s3);

            Console.ReadKey();


        }
    }
}
