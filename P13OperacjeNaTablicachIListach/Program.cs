using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13OperacjeNaTablicachIListach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string napis = "ala ma kota";

            string[] tablica=  napis.Split(' ');

            string napis2=  string.Join("*", tablica);

            List<string> lista = new List<string>();
            lista.Add("ala");
            lista.Add("Jan");
            lista.Add("lukasz");

            string napis3 = string.Join(" ", lista);

            List<string> lista2 = tablica.ToList();

            List<string> lista3 = napis.Split(' ').ToList();

            string[] tablica2 = lista3.ToArray();

            string napis4 = "ala!*ma!*kota";

            string[] wyrazeniaSpecjalne = new string[1];
            wyrazeniaSpecjalne[0] = "!*";

            string[] tablica4 = napis4.Split(wyrazeniaSpecjalne, StringSplitOptions.RemoveEmptyEntries);

            string[] tab = new string[2] { "ala", "jan" };
            string[] tab2 = new string[] { "ala", "jan" };
            string[] tab3 = { "ala", "jan" };

            string[] tablica5= napis4.Split(new string[] { "!*" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> lista4 = new List<string>();
            lista4.Add("jan");

            List<string> lista5 = new List<string>() { "jan", "ala", "lukasz" };

            string ala = lista[1];
            lista[1] = "ola";

             

        }
    }
}
