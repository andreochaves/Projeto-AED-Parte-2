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
        public bool verificarIdade()
        {
         bool valido = false;
            if (this.idade >= 18)
            {
                valido = true;
            }
            return valido;
        }

        public bool verificarCpf(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++) { 
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            }
            resto = soma % 11;

            if (resto < 2) { 
                resto = 0;
            }else {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++) { 
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma % 11;

            if (resto < 2) { 

                resto = 0;

            }else {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();
            return true;
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
