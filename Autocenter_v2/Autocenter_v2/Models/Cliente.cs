using System;
using System.Collections.Generic;
using System.Text;
using Autocenter_v2.Controllers;

namespace Autocenter_v2.Models
{
    class Cliente : Pessoa
    {
        private int qtdPontosFidelidade;


        public Cliente() { }
        public Cliente(string nome, string cpf, string endereco, int idade) : base()
        {
            this.setNome(nome);
            this.setCPF(cpf);
            this.setEndereco(endereco);
            this.setIdade(idade);
            this.qtdPontosFidelidade = 0;
        }

        public void AdicionarPontos()
            {
            this.qtdPontosFidelidade += 10;
            }

        public int getQtdPontosFidelidade() { return qtdPontosFidelidade; }

    }
}
