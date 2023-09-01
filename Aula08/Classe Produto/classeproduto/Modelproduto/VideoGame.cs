using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeproduto.Modelproduto
{
    public class VideoGame : Produto
    {

        private string tipo;

        public VideoGame(string produto, int id, string descricao, string fornecedor, int quantidade, string status, string tipo) : base(produto, id, descricao, fornecedor, quantidade, status)
        {
            this.tipo = tipo;
        }

        public string GetTipo()
        {
            return this.tipo;
        }

        public void GetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Tipo:" + this.tipo);


        }
    
    }
}
