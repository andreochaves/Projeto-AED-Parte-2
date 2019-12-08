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
            bool OrcamentoCadastrado = false;

            Console.WriteLine("CPF do cliente: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("\nSelecione o Servico: ");
            string servico = Console.ReadLine();

            Console.WriteLine("Forma de Pagamento: ");
            string formaPagamento =  Console.ReadLine();


            Orcamento orcamento = new Orcamento();
            orcamento = new Cliente(nome, cpf, endereco, idade);
            bool cpfValido = Validator.validarCPF(cliente.getCPF());

            if (cpfValido)
            {
                ClienteController clienteController = new ClienteController();
                ClienteDAO clienteDAO = new ClienteDAO();

                clienteCadastrado = clienteDAO.inserirCliente(cliente);
            }
            else
            {
                Program.msg += "CPF Inválido!\n";
            }

            return clienteCadastrado;
        }
    }
}
