using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Cliente.ModelCliente
{
    public class Cliente
    {
        private string nome = string.Empty;
        private int id;
        private string endereco = string.Empty;
        private int contato;
        private int cpf;
        private string status = string.Empty;

        public Cliente(string nome, int id, string endereco, int contato, int cpf, string status)
        {
            this.nome = nome;
            this.id = id;
            this.endereco = endereco;
            this.contato = contato;
            this.cpf = cpf;
            this.status = status;
        }

       
        /*Métodos Get e Set*/
        public string Getnome()
        {
            return nome;
        }

        public void Setnome(string nome)
        {
            this.nome = nome;
        }

        public int Getid()
        {
            return id;
        }

        public void Setid(int id)
        {
            this.id = id;
        }

        public string Getendereco()
        {
            return endereco;
        }

        public void Setendereco(string endereco)
        {
            this.endereco = endereco;
        }

        public int Getcontato()
        {
            return contato;
        }

        public void Setcontato(int contato)
        {
            this.contato = contato;
        }

        public int Getcpf()
        {
            return cpf;
        }

        public void Setcpf(int cpf)
        {
            this.cpf = cpf;
        }
        public string Getstatus()
        {
            return status;
        }

        public void Setstatus(string status)
        {
            this.status = status;
        }

        public virtual void Visualizar()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("                    Dados do Cliente                 ");
            Console.WriteLine("*****************************************************");
            Console.WriteLine($"  Nome do cliente: {this.nome}");
            Console.WriteLine($"  ID: {this.id}");
            Console.WriteLine($"  Endereço: {this.endereco}");
            Console.WriteLine($"  Contato: {this.contato}");
            Console.WriteLine($"  CPF: {this.cpf}");
            Console.WriteLine($"  STATUS: {this.status}");

        }

    }

    
    
}

