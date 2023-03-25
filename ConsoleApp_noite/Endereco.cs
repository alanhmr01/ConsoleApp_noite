using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_noite
{
    public class Endereco
    {
        private string Rua;
        private int N;
        private string Bairro;
        private string CEP;
        private string Cidade;
        private string Estado;

        public Endereco(string rua, int n, string bairro, string cep, string cidade, string estado)
        {
            Rua = rua;
            N = n;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
        }
        public string EnderecoCompleto()
        {
            return Rua + ", " + N + " Bairro:" + Bairro + "Cidade: " + Cidade + "/" + Estado;
        }

        public Endereco BuscaporCep(string cep)
        {
            return new Endereco("", 5, "", cep, "", "");
        }
        public string EstadoPorCidade(string estado)
        {
            if (Estado == "sp")
            {
                return "Monte Alto";
            }
            return Cidade;
        }

        public void InserirNoBanco(Endereco endereco)
        {
            //db.ENDERECO.ADD(endereco)
            //db.savechanges();
        }
        public string GetRua() => Rua;
        public void setRua(string rua)
        {
            Rua = rua;
        }
        public int getN() => N;

        public void setN(int n)
        {
            N = n;
        }
        public string getCep() => CEP;

        public void setCEP(string cep)
        {
            CEP = cep;
        }
        public string getBairro() => Bairro;

        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }
        public string getCidade() => Cidade;

        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }
        public string getEstado() => Estado;

        public void setN(string estado)
        {
            Estado = estado;
        }
    }
}