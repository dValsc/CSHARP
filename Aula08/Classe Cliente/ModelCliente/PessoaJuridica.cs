using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Cliente.ModelCliente
{
    internal class PessoaJuridica : Cliente
    {

        private String mei;

        public PessoaJuridica(string nome, int id, string endereco, int contato, int cpf, string status, string mei) : base(nome, id, endereco, contato, cpf, status)
        {
            this.mei = mei;
        }

        public string GetMei()
        {
            return this.mei;
        }

        public void GetMei(string mei)
        {
            this.mei = mei;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Mei:" + this.mei);


        }
    }
}
