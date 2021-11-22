using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[3];
            
            List<int> lista = new List<int>();

            lista.Add(4);
            lista.Add(6);
            lista.Add(7);

            int dlugoscListy = lista.Count;

            lista.Insert(1, 5);

            List<int> lista2;

            //lista2.Add(4);

            List<string> listaNapisow = new List<string>();



        }
    }
}
