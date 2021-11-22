using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03OperacjeNaNapisach
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            // napisy 

            string s = "ala ma kota";
            int dlugosc = s.Length;

            string s1 = s.Substring(4); // ma kota
            string s2 = s.Substring(4,2); // ma

            string s3 = s.Replace("ma", "bedzie miala");

            bool czyMa= s.Contains("ma");

            string s4 = s.ToLower(); //ToUpper() 

            string s5 = s + " i psa";

            bool czyTakieSame = s == "ala ma kota";

            int pozycja= s.IndexOf("ma"); //4 

        }
    }
}
