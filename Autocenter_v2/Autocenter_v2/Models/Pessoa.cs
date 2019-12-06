using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    public class Pessoa
    {
        private string nome;
        private string cpf;
        private string endereco;
        private int idade;

        public Pessoa() { }
        public Pessoa(string nome,string cpf,string endereco,int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.idade = idade;
        }

        public string getNome() { return nome; }
        public string getCPF() { return cpf; }
        public string getEndereco() { return endereco; }
        public int getIdade() { return idade; }
        public void setNome(string no) { nome = no; }
        public void setCPF(string cp) { cpf = cp; }
        public void setEndereco(string ed) { endereco = ed; }
        public void setIdade(int id) { idade = id; }
    }
}
