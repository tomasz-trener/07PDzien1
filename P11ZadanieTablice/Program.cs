using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadanieTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Podaj ile imion chcesz przechowywać");
            //    int maksImion = Convert.ToInt32(Console.ReadLine());
            const int maksImion = 50;

            Console.WriteLine("Wczytaj imiona");
            string[] imiona = new string[maksImion];

          //  int dlTab = imiona.Length;

            int i = 0;
            do
            {
                string wczytaneImie= Console.ReadLine();
                if (wczytaneImie != "koniec" && i < maksImion)
                {
                    imiona[i] = wczytaneImie;
                    i++;
                }
                else
                    break;

            } while (true);

            for (int j = 0; j < i; j++)
                Console.WriteLine(string.Format("{0} ({1})", imiona[j],imiona[j].Length));

            Console.ReadKey();

        }
    }
}
