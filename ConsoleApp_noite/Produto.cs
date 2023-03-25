using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_noite
{
    internal class Produto
    {
        private int Id;
        private decimal Valor;
        private string Descricao;

        public Produto(int id, decimal valor, string descricao)
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;
        }
        public string ExibirDados()
        { return " Descrição do Item: " + Descricao + "O ID é: " + Id + " Valor do item: R$" + Valor; }
        public string getDescricao() => Descricao;

        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public int getId() => Id;

        public void setId(int id)
        {
            Id = id;
        }
        public decimal getValor() => Valor;

        public void setValor(decimal valor)
        {
            Valor = valor;
        }

    }
}