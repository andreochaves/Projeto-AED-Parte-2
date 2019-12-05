using Autocenter_v2.Models;
using Autocenter_v2.Controllers;
using System;

namespace Autocenter_v2
{
    public class Program
    {
        public static string user;
        public static string senha;
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            FuncionarioController funcController = new FuncionarioController();
            

        Console.WriteLine("Informe o usuário: ");
            user = Console.ReadLine().ToLower();
            
            Console.WriteLine("Informe a senha: ");
            senha = Console.ReadLine();

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
    }
}
