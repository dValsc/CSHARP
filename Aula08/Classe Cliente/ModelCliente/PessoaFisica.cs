using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Cliente.ModelCliente
{
    public class PessoaFisica : Cliente
    {

        private int idade;
        public PessoaFisica(string nome, int id, string endereco, int contato, int cpf, string status, int idade) : base(nome, id, endereco, contato, cpf, status)
        {
            this.idade = idade;
        }

        public int GetIdade()
        {
            return this.idade;
        }

        public void GetIdade(int idade)
        {
            this.idade = idade;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Idade:" + this.idade);


        }
    }
}
