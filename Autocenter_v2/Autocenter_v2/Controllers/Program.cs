using Autocenter_v2.Models;
using Autocenter_v2.Controllers;
using System;
using Autocenter_v2.Utils;

namespace Autocenter_v2
{
    
    public class Program
    {

        ClienteController clienteController = new ClienteController();
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            FuncionarioController funcController = new FuncionarioController();
            

            Console.WriteLine("Informe o usuário: ");
            string user = Console.ReadLine().ToLower();
            
            Console.WriteLine("Informe a senha: ");
            string senha = Console.ReadLine();

            func.setUsuario(user);
            func.setSenha(senha);

            bool funcPermitido = funcController.efetuarLogin(func);
            string opc;
            string msg = "";

            if (funcPermitido)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(msg);
                    msg = "";

                    Console.WriteLine("================================\n" +
                        "1. Cadastrar clientes\n" +
                        "2. Cadastrar funcionários\n" +
                        "3. Solicitar orçamento\n" +
                        "4. Pagar com sexo\n" +
                        "5. Sair\n" +
                        "================================\n");

                    Console.WriteLine("Escolha uma opção: ");
                    opc = Console.ReadLine();


                    switch (opc)
                    {
                        case "1":
                            bool clienteValido = cadastrarCliente();

                            if (clienteValido)
                            {
                                msg = "Cliente cadastrado com Sucesso!";
                            }
                            else
                            {
                                msg = "Cliente NÃO Cadastrado!";
                            }
                            break;

                        case "2":
                            break;

                        case "3":
                            break;

                        case "4":
                            break;

                        case "5":
                            Console.WriteLine("Programa finalizado!");
                            break;

                        default:
                            msg = "\nOpção inválida, tente novamente!";
                            break;

                    }
                } while (!opc.Equals("5"));
            }
            else
            {
                Console.WriteLine("Funcionario NÃO AUTORIZADO!");
            }

           
        }
        
        public static bool cadastrarCliente()
        {
            bool clienteCadastrado = false;

            Console.WriteLine("Nome do cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("CPF do cliente: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Endereço do cliente \nRua: ");
            string endereco = Console.ReadLine();

            Console.WriteLine("Bairro: ");
            endereco += ", " + Console.ReadLine();

            Console.WriteLine("Nº: ");
            endereco += ", " + Console.ReadLine();

            Console.WriteLine("Cidade / ES: ");
            endereco += ", " + Console.ReadLine();

            Console.WriteLine("Idade do cliente: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Cliente cliente = new Cliente();
            cliente = new Cliente(nome, cpf, endereco, idade);
            bool cpfValido = Validator.validarCPF(cliente.getCPF());

            if (cpfValido) { 
            ClienteController clienteController = new ClienteController();
            clienteCadastrado = clienteController.cadastrarCliente(cliente);

            }
            else
            {
                Console.WriteLine("CPF Inválido!");
            }

            return clienteCadastrado;
        }

    }
}
