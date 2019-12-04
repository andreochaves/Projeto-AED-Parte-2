using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    public class Funcionario:Pessoa
    {
        private string Usuario;
        private string Senha; 

        public string getUsuario() { return Usuario; }
        public string getSenha() { return Senha; }
        public void setSenha(string senha) { this.Senha = senha; }
        public void setUsuario(string user) { this.Usuario = user; }

        public Funcionario() { }
        public Funcionario(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}
