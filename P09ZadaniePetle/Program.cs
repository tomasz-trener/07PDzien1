using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadaniePetle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj zdanie");
            string zdanie = Console.ReadLine().ToLower();

            Console.WriteLine("Wczytaj szukany wyraz");
            string wyraz = Console.ReadLine().ToLower();

            //  ma
            // ala ma kota i ma pasa

            int i = 0;
            int suma=0;
            string s;

            int dlZdania = zdanie.Length;
            int dlWyraz = wyraz.Length;

            while (i < dlZdania - dlWyraz)
            {
                s= zdanie.Substring(i, dlWyraz);
                if (s == wyraz)
                    suma++;

                i++;
            }

            Console.WriteLine(suma);
            Console.ReadKey();




        }
    }
}
