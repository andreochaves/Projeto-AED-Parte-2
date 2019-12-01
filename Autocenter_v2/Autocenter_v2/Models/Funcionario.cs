using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Funcionario:Pessoa
    {
        private string usuario;
        private string senha;

        public Funcionario(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
}
