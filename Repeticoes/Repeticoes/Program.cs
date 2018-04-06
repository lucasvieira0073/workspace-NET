using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticoes
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteração {0}", i);
            }


            Console.WriteLine();

            int cont = 0;
            while(cont < 5)
            {
                Console.WriteLine("Iteração {0}", cont);
                cont++;
            }

            Console.WriteLine();

            cont = 0;
            do
            {
                Console.WriteLine("Iteração {0}", cont);
                cont++;
            } while (cont < 5);


           

            Console.ReadKey();
        }
    }
}
