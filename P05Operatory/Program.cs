using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // wstawka liczby 
            int a = 1;
            a++;
            a = a + 1;

            a += 3; //a=a+3;
            a -= 2; // zmniejsz o 2 
            a *= 2; // przemnoz przez 2 
            a /= 4; // przedziel przez 4 

            a = 1;
            a++; // zwiekszenie zmiennej po uzyciu 
            a--;
            ++a; // zwiekszenie zmiennej przed uzyciem 

            bool c1 = a == 1;
            bool c2 = a < 2;
            bool c3 = a >= 3;

            bool c4 = a < 1 || a >5;
            bool c5 = (a < 2 && a >= 0) || a==1;

            bool c6 = a != 5;

            bool c7 = !(a == 5);

            string s = Convert.ToString(10, 2);

            int b = 10;
            b = b >> 2;

            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
