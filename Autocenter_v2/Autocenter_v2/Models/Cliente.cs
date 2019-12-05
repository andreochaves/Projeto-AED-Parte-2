using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Cliente : Pessoa
    {
        private int qtdPontosFidelidade;


        public Cliente() { }
        public Cliente(int qtdPontosFidelidade)
        {
            this.qtdPontosFidelidade = qtdPontosFidelidade;


            

        }
        void VerificaPontos()
            {

            }
        void AdicionaPontos()
            {

            }
        public int getQtdPontosFidelidade() { return qtdPontosFidelidade; }
        public void setQtdPontosFidelidade(int qpf) { qtdPontosFidelidade = qpf; }
    }
}
