using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Cilente:Pessoa
    {
        public int QtdPontosFidelidade { get; set; }


        public Cliente() { }
        public Cliente(int qtdPontosFidelidade)
        {
            this.QtdPontosFidelidade = qtdPontosFidelidade;
        }

        public int VerificaPontos()
        {

        }
        public int AdicionaPontos()
        {

        }

    }
}
