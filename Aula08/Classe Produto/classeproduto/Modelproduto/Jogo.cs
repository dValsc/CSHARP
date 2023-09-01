using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeproduto.Modelproduto
{
    public class Jogo : Produto
    {

        private decimal preco;

        public Jogo(string produto, int id, string descricao, string fornecedor, int quantidade, string status, decimal preco) : base(produto, id, descricao, fornecedor, quantidade, status)
        {
            this.preco = preco;
        }

        public decimal GetPreco()
        {
            return this.preco;
        }

        public void GetPreco(int preco)
        {
            this.preco = preco;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Preço:" + this.preco);


        }
    }
}
