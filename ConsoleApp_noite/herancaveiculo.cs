using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Alan.HERANCA
{
    public class Veiculo
    {
        public int numeroAssentos;
        public int numeroPortas;
        public bool TemMotor;


        public string ExibirDados()
        {
            if (TemMotor == true)
            {
                return "Com Motor.     " + "Assentos: " + numeroAssentos + " Nº Portas: " + numeroPortas;
            }
            else
            {
                return "Assentos: " + numeroAssentos + "  Nº Portas: " + numeroPortas;
            }

        }
    }

}