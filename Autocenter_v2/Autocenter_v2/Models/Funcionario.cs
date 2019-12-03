using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Funcionario:Pessoa
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Funcionario() { }
        public Funcionario(string usuario, string senha)
        {
            this.Usuario = usuario;
            this.Senha = senha;
        }
    }
}
