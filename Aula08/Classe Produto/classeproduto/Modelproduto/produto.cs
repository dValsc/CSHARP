using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeproduto.Modelproduto
{
    public class Produto
    {
        private string produto = string.Empty;
        private int id;
        private string descricao = string.Empty;
        private string fornecedor = string.Empty;
        private int quantidade;
        private string status = string.Empty;

        public Produto(string produto, int id, string descricao, string fornecedor, int quantidade, string status)
        {
            this.produto = produto;
            this.id = id;
            this.descricao = descricao;
            this.fornecedor = fornecedor;
            this.quantidade = quantidade;
            this.status = status;
        }

        /*Métodos Get e Set*/
        public string Getproduto()
        {
            return produto;
        }

        public void Setproduto(string produto)
        {
            this.produto = produto;
        }

        public int Getid()
        {
            return id;
        }

        public void Setid(int id)
        {
            this.id = id;
        }

        public string Getdescricao()
        {
            return descricao;
        }

        public void Setdescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string Getfornecedor()
        {
            return fornecedor;
        }

        public void Setfornecedor(string fornecedor)
        {
            this.fornecedor = fornecedor;
        }

        public int Getquantidade()
        {
            return quantidade;
        }

        public void Setquantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public string Getstatus()
        {
            return status;
        }

        public void Setstatus(string status)
        {
            this.status = status;
        }

        public void Visualizar()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("                    Dados do Cliente                 ");
            Console.WriteLine("*****************************************************");
            Console.WriteLine($"  Nome do produto: {this.produto}");
            Console.WriteLine($"  ID: {this.id}");
            Console.WriteLine($"  Descricao: {this.descricao}");
            Console.WriteLine($"  Fornecedor: {this.fornecedor}");
            Console.WriteLine($"  Quantidade: {this.quantidade}");
            Console.WriteLine($"  STATUS: {this.status}");

        }

    }



}

