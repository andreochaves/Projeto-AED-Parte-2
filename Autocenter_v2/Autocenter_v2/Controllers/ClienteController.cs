using Autocenter_v2.DAO;
using Autocenter_v2.Models;
using Autocenter_v2.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Controllers
{
    class ClienteController
    {
        public static bool cadastrarCliente()
        {
            bool clienteCadastrado = false;

            Console.WriteLine("Nome do cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("CPF do cliente: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("\nEndereço do cliente \nRua: ");
            string endereco = Console.ReadLine();

            Console.WriteLine("Bairro: ");
            endereco += ", " + Console.ReadLine();

            Console.WriteLine("Nº: ");
            endereco += ", " + Console.ReadLine();

            Console.WriteLine("Cidade / ES: ");
            endereco += ", " + Console.ReadLine();

            Console.WriteLine("Idade do cliente: ");
            string idd = Console.ReadLine();
            int idade = 0;

            try
            {
                idade = Convert.ToInt32(idd);
                if(idade <= 0)
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

            Cliente cliente = new Cliente();
            cliente = new Cliente(nome, cpf, endereco, idade);
            bool cpfValido = Validator.validarCPF(cliente.getCPF());

            if (cpfValido)
            {
                bool veiculoValido = false;
                string resp;

                do { 
                    Console.WriteLine("Digite 1 para cadastrar seu carro ou 2 para sua moto: ");
                    string veiculo = Console.ReadLine();

                    if (veiculo.Equals("1"))
                    {
                        veiculoValido = VeiculoController.cadastrarCarro();
                    }
                    else if (veiculo.Equals("2"))
                    {
                        veiculoValido = VeiculoController.cadastrarMoto();
                    }

                    Console.WriteLine("Deseja cadastrar outro veículo?");
                    resp = Console.ReadLine(); 
                } while (resp.Equals("sim"));


                if (veiculoValido)
                {

                ClienteDAO clienteDAO = new ClienteDAO();
                clienteCadastrado = clienteDAO.inserirCliente(cliente);

                }
                else
                {
                    Program.msg += "Veículo não Cadastrado!\n";
                }
            }
            else
            {
                Program.msg += "CPF Inválido!\n";
            }

         return clienteCadastrado;
        }
    }
}
