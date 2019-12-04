using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    public class Pessoa
    {
        protected string Nome { get; set; }
        protected string Cpf { get; set; }
        protected string Endereco { get; set; }
        protected int Idade { get; set; }

        public Pessoa() { }
        public Pessoa(string nome,string cpf,string endereco,int idade)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereco = endereco;
            this.Idade = idade;
        }
        public bool verificarIdade()
        {
         bool valido = false;
            if (this.Idade >= 18)
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


    }
}
