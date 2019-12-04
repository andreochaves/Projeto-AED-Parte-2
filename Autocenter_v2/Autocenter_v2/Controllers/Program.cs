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
            user = Console.ReadLine();
            
            Console.WriteLine("Informe a senha: ");
            senha = Console.ReadLine();

            func.setUsuario(user);
            func.setSenha(senha);

            bool funcPermitido = funcController.efetuarLogin(func);

            if (funcPermitido)
            {
                Console.WriteLine("Logou, Funcionario autorizado!");
            }
            else
            {
                Console.WriteLine("Funcionario NÃO AUTORIZADO!");
            }

            

        }
    }
}
