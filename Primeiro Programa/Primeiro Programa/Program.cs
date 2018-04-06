using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Escreva sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("{0}, você tem {1} anos de idade.", nome, idade);

            
            Console.WriteLine();
            Console.WriteLine(nome.Length);

            Console.WriteLine();
            Console.WriteLine(nome.Substring(0,1));

            Console.WriteLine();

            

            if (nome.Length == 5 && nome == "lucas" || nome == "marcos")
            {
                Console.WriteLine("O nome tem 5 letras");
            }
            else
            {
                Console.WriteLine("O nome não tem 5 letras");
            }

            Console.WriteLine();

            switch (nome.Length)
            {
                case 5:
                    Console.WriteLine("Case retornou 5");
                    break;
                default:
                    Console.WriteLine("Valor default");
                    break;
            }


            Console.ReadKey();
        }
    }
}
