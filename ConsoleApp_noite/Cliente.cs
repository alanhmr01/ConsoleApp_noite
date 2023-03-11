using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_noite
{
    public class Cliente
    {

        private int Id;
        private string Nome;
        private string Telefone;
        private Endereco endereco;

    public Cliente(int id, string nome, string telefone, Endereco _endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            endereco = _endereco;
        }

        public void setEndereco(Endereco _endereco){ endereco = _endereco;}
        public Endereco getEndereco(){return endereco;}
        public string getNome(){return Nome;}
        public void setNome(string nome){Nome = nome;}
        public string getTelefone(){return Telefone;}
        public void setTelefone(string telefone){Telefone = telefone;}
        public int getId(){return Id;}
        public void setId(int id){Id = id;}
    }

}
