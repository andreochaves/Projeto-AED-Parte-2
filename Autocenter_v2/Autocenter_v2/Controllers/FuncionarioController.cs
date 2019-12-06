using Autocenter_v2.DAO;
using Autocenter_v2.Models;
using Autocenter_v2.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Controllers
{
    public class FuncionarioController
    {
        public bool efetuarLogin(Funcionario func)
        {
            FuncionarioDAO funcDAO = new FuncionarioDAO();
            bool autenticado = false;
            
            autenticado = funcDAO.Logar(func);

            if (autenticado)
            {
                return true;
            }
            return false;
        }

        public bool cadastrarFuncionario()
        {
            bool funcionarioCadastrado = false;
            Console.WriteLine("Digite o nome do funcionario: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf do funcionario: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("\nEndereço do funcionario \nRua: ");
            string endereco = Console.ReadLine();

            Console.WriteLine("Bairro: ");
            endereco += ", " + Console.ReadLine();

            Console.WriteLine("Nº: ");
            endereco += ", " + Console.ReadLine();

            Console.WriteLine("Cidade / ES: ");
            endereco += ", " + Console.ReadLine();
            Console.WriteLine("\nDigite a idade do funcionario: ");
            string idd = Console.ReadLine();
            Console.WriteLine("Digite o usuáro do funcionario: ");
            string user = Console.ReadLine();
            Console.WriteLine("Digite a senha do funcionario:  ");
            string senha = Console.ReadLine();

            int idade = 0;

            try
            {
                idade = Convert.ToInt32(idd);
                if (idade <= 0)
                {
                    return false;
                }
            }
            catch
            {
                Program.msg += "Idade inválida, favor digitar um número inteiro positivo!\n";
                return false;
            }

            if (!Validator.validarIdade(idade))
            {
                Program.msg += "Idade mínima para cadastro é de 18 anos!\n";
                return false;
            }

            Funcionario novofuncionario = new Funcionario();
            novofuncionario = new Funcionario(nome, cpf, endereco, idade, user, senha);
            bool cpfValido = Validator.validarCPF(novofuncionario.getCPF());

            if (cpfValido)
            {
                FuncionarioController funcionarioController = new FuncionarioController();
                FuncionarioDAO funcDao = new FuncionarioDAO();
                funcionarioCadastrado = funcDao.InserirFuncionario(novofuncionario);
            }
            else
            {
                Program.msg += "CPF Inválido!\n";
                return false;
            }

            return funcionarioCadastrado;
        }

    }
}
