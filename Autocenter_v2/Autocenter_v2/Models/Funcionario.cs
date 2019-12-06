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
        public Funcionario(string nome, string  cpf, string endereco, int idade, string usuario, string senha) : base()
        {
            this.setNome(nome);
            this.setCPF(cpf);
            this.setEndereco(endereco);
            this.setIdade(idade);
            Usuario = usuario;
            Senha = senha;
        }
    }
}
