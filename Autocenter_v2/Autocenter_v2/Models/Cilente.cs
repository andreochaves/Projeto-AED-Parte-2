using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Cilente:Pessoa
    {
        private int qtdPontosFidelidade;

        public Cliente(int qtdPontosFidelidade)
        {
            this.qtdPontosFidelidade = qtdPontosFidelidade;
        }

        public int VerificaPontos()
        {

        }
        public int AdicionaPontos()
        {

        }

    }
}
