using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Pessoa : IPessoa
    {
        protected string nome;
        protected int idade;

        public Pessoa(){}

        public Pessoa(string nome, int idade)
        {
            SetNome(nome);
            SetIdade(idade);
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public int GetIdade()
        {
            return this.idade;
        }

        //virtual diz que o metodo pode ser sobrescrito pelas classes que a herdam
        public virtual string ProcessaNome()
        {
            return "sem valor";
        }
    }
}
