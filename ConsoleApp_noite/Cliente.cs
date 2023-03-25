using ConsoleApp_noite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_App___Chicao
{
    public class Cliente
    {
        private int Id;
        private string Nome;
        private string Telefone;
        private Endereco Endereco;

        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        public string ExibeDadosClientes()
        {
            return "O id é:" + Id + "O nome do cliente é: " + Nome + " O telefone: " + Telefone;
        }
        public void SetEndereco(Endereco endereco) { Endereco = endereco; }
        public Endereco GetEndereco() => Endereco;
        public int getId() => Id;
        public void setId(int id)
        {
            id = Id;
        }
        public string getNome() => Nome;
        public void setNome(string nome)
        {
            Nome = nome;
        }
        public string getTelefone() => Telefone;
        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}
