using Autocenter_v2.DAO;
using Autocenter_v2.Models;
using Autocenter_v2.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Controllers
{
    class OrcamentoController
    {

        public static bool cadastrarOrcamento()
        {
            string resposta;
            string servico;
            bool OrcamentoCadastrado = false;

            Console.WriteLine("CPF do cliente: ");
            string cpfCliente = Console.ReadLine();

            Console.WriteLine("\nVeículo:" +
                "\n1 - Carro" +
                "\n2 - Moto ");
            string veiculo = Console.ReadLine();
            switch (veiculo)
            {
                case "1": 
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Opçao Invalida,tente novamente!");
                    break;
            }
            Console.WriteLine("Placa: ");
            string placa = Console.ReadLine();

            Console.WriteLine("Serviço: ");
            servico = Console.ReadLine();
            do
            {
                Console.WriteLine("Deseja incluir mais algum servico?" +
                    "\n1 - Sim" +
                    "\n2 - Não");
                resposta = Console.ReadLine();

                Console.WriteLine("Serviço: ");
                servico += "," + Console.ReadLine();
            } while (!resposta.Equals("2"));

            Console.WriteLine("Forma de Pagamento: ");
            string formaPagamento =  Console.ReadLine();


           // Orcamento orcamento = new Orcamento();
            //orcamento = new Orcamento(cpfCliente, veiculo, placa, servico,formaPagamento,valorTotal);
           
            return OrcamentoCadastrado;
        }
    }
}
