using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] Texto = new string[5];
            Texto[0] = "palavra 1";
            Texto[1] = "palavra 2";
            Texto[2] = "palavra 3";
            Texto[3] = "palavra 4";
            Texto[4] = "palavra 5";
            int contador = 0;

            foreach (string palavra in Texto)
            {
                Console.WriteLine("Iteração: {0} - {1}", contador, palavra);
                contador++;
            }


            Console.WriteLine();


            List<string> texto = new List<string>();
            texto.Add("palavra 1");
            texto.Add("palavra 2");
            texto.Add("palavra 3");
            texto.Add("palavra 4");
            texto.Add("palavra 5");
            contador = 0;

            foreach(string palavra in texto)
            {
                Console.WriteLine("Iteração: {0} - {1}", contador, palavra);
                contador++;
            }




            Console.ReadKey();
        }
    }
}
