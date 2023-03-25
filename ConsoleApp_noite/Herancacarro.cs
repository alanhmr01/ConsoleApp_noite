using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Alan.HERANCA
{
    public class Carro : Veiculo
    {
        public bool cintoSeguranca;
        public bool ArCondicionado;
        public string marcaRadio;

        public string fabricante;



        public string ExibirMarca()
        {
            return "O fabricante deste veiculo é: " + fabricante;
        }
    }
}
