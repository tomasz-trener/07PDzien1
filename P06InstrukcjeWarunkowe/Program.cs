using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06InstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost");
            int wzrost = Convert.ToInt32(Console.ReadLine());

            bool c1= wzrost > 185;

            if (c1) // c1 == true
                Console.WriteLine("jeśteś wysoki");
            else
                Console.WriteLine("jesteś niski");

            
            if (wzrost>185)
                Console.WriteLine("jesteś wysoki");
            else if (wzrost> 160)
                Console.WriteLine("jesteś średni");
            else if (wzrost > 150)
                Console.WriteLine("jesteś niski");
            else
                Console.WriteLine("jesteś bardzo niski");

            if (wzrost>185)
            {
                if (wzrost>200)
                    Console.WriteLine("jesteś bardzo wysoki");
                else
                    Console.WriteLine("jesteś wysoki");
            }
            else
            {
                Console.WriteLine("jesteś niski");
            }


            string wyn;
            if (wzrost > 185)
                wyn = "jestś wysoki";
            else
                wyn = "jesteś niski";

            Console.WriteLine(wyn);

            string wyn2 = wzrost > 185 ? "jestś wysoki" : "jesteś niski";

            string wyn3 = wzrost > 185 ? "jesteś wysoki" : 
                wzrost > 160 ? "jesteś średni" : "jesteś niski";



        }
    }
}
