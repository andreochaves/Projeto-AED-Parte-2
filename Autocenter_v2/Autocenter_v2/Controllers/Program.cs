
using Autocenter_v2.Models;
using Autocenter_v2.Controllers;
using System;
using Autocenter_v2.Utils;

namespace Autocenter_v2
{
    
    public class Program
    {
        public static string msg = "";
        ClienteController clienteController = new ClienteController();
        OrcamentoController orcamentoController = new OrcamentoController();
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
                        "3. Tabela de Preços\n" +
                        "4. Solicitar orçamento\n" +
                        "5. Sair\n" +
                        "================================\n");

                    Console.WriteLine("Escolha uma opção: ");
                    opc = Console.ReadLine();


                    switch (opc)
                    {
                        case "1":

                            bool clienteValido = ClienteController.cadastrarCliente();

                            if (clienteValido)
                            {
                                msg += "Cliente cadastrado com Sucesso!\n";
                            }
                            else
                            {
                                msg += "Cliente NÃO Cadastrado!\n";
                            }
                            break;

                        case "2":

                            bool funcionarioValido = funcController.cadastrarFuncionario();
                            if (funcionarioValido)
                            {
                                msg += "Funcionario cadastrado com Sucesso!";
                            }
                            else
                            {
                                msg += "Funcionario NÃO Cadastrado!";
                            }
                            break;

                        case "3":
                            break;

                        case "4":
                            bool orcamentoValido = OrcamentoController.cadastrarOrcamento();
                            if (orcamentoValido)
                            {
                                msg += "Orçamento cadastrado com Sucesso!";
                            }
                            else
                            {
                                msg += "Orçamento NÃO Cadastrado!";
                            }
                            break;

                        case "5":
                            Console.WriteLine("Programa finalizado!");
                            break;

                        default:
                            msg += "\nOpção inválida, tente novamente!\n";
                            break;

                    }
                } while (!opc.Equals("5"));
            }
            else
            {
                Console.WriteLine("Funcionario NÃO AUTORIZADO!");
            }
        }
    }
}
