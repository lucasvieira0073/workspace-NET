using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //é permitido implementar classe e tambem interface, seguindo a sequencia de classe primeiro e depois interface
    //ficaria assim   class Funcionario : Pessoa, IPessoa
    //isso vale para java , não é permitido herança multipla de classes, mas de interface sim
    //no java também é possivel ficaria assim  class Funcionario : Pessoa, IPessoa, ICliente
    class Funcionario : Pessoa
    {

        public String cargo;

        public Funcionario(String nome, int idade, String cargo)
            : base(nome, idade)// igual ao super() do java lembre que não tem ponto e virgula
        {
            this.cargo = cargo;
        }

        public void Teste()
        {
            Console.WriteLine("Classe funcionario OK");
        }

        public override string ProcessaNome()
        {
            return "Funcionario " + nome;
        }



    }
}
