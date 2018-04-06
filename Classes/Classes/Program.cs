using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("Lucas Vieira", 26, "Programador");

            Funcionario f2 = new Funcionario("Teste", 20, "Testador");

            Console.WriteLine("Nome: {0}, idade: {1}, cargo: {2}", f1.GetNome(), f1.GetIdade(), f1.cargo);

            Console.WriteLine();

            Console.WriteLine("Nome: {0}, idade: {1}, cargo: {2}", f2.GetNome(), f2.GetIdade(), f2.cargo);

            Console.WriteLine();

            Console.WriteLine(f2.ProcessaNome());

            Console.WriteLine();

            //IPessoa pessoa = new Funcionario("Lucas", 26, "Analista");

            int n1 = 10;
            int n2 = 0;

            int n3 = 0;

            try
            {
                n3 = n1 / n2;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Ocorreu um erro por divisão por zero");
            }
            

            Console.ReadKey();
            //quando atribuimos um objeto para um objeto do mesmo tipo, os dois apontam para o mesmo endereço de memória
        }
    }
}
