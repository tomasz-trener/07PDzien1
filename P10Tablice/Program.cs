using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imie1 = "Adam";
            string imie2 = "Ala";
            string imie3 = "Jan";
                
            string[] tab = new string[3];
            
            tab[0] = imie1;
            tab[1] = "Ola";
            // tab[3] = imie2;

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }

            Console.ReadKey();
        }
    }
}
