using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Pessoa
    {
        protected string nome;
        protected string cpf;
        protected string endereco;
        protected int idade;

        private bool valido = false;
        public bool verificarIdade()
        {
            if (this.idade >= 18)
            {
                valido = true;
            }
            return valido;
        }

        public void verificarCpf()
        {

        }
    }
}
