using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);

            // while do while, for, foreach 

            int i = 0;
            while (i < 10)
            {
                //....

                if (i == 5)
                {
                    break;
                }

                //..
                Console.WriteLine(i);
                i++;
            }

            i = 0;

            while (true)
            {
                if (i == 10)
                {
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }

            i = 0;
            bool f = true;
            while (f)
            {
                if (i==5)
                {
                    //f = !f;
                    f= false;
                }
                Console.WriteLine(i);
                i++;
            }

            // petlą while najwazniejsza 

            do
            {

            } while (true);


            // pele for 

            i= 0;
            while (i<10)
            {
                Console.WriteLine(i);
                i++;
            }


            for (int j = 3; j < 10; j+=2)
            {
                Console.WriteLine(j);
            }

            for (int j = 10; j > 0; j--)
            {
                Console.WriteLine(j);
            }

            // foreach 


            Console.ReadKey();



        }
    }
}
