using Autocenter_v2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Autocenter_v2.DAO
{
    class OrcamentoDAO
    {

        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        Connection ConnBD = new Connection();

        public bool inserirOrcamento(Orcamento orcamento)
        {
            cmd.CommandText = @"INSERT INTO Orcamento
           (nomeCliente
           , veiculo
           , placa
           , servico
           , formaPagamento
           , valorTotal)
     VALUES
           (@nomeCliente
           , @veiculo
           , @placa
           , @servico
           , @formaPagamento
           , @valorTotal)";  //Comando Sql

            cmd.Parameters.AddWithValue("@nomeCliente", orcamento.getNomeCliente());     //Recebe Valor p/ Pesquisa no BD
            cmd.Parameters.AddWithValue("@veiculo", orcamento.getVeiculo());
            cmd.Parameters.AddWithValue("@placa", orcamento.getPlaca());
            cmd.Parameters.AddWithValue("@servico", orcamento.getServicos());
            cmd.Parameters.AddWithValue("@formaPagamento", orcamento.getFormaPagamento());
            cmd.Parameters.AddWithValue("@valorTotal", orcamento.getValorTotal());

            bool orcamentoCadastrado = false;
            try
            {
                cmd.Connection = ConnBD.Conectar();     //Abre Conexão com o BD
                dr = cmd.ExecuteReader();                  //Armazena Informações do BD
                ConnBD.Desconectar();
                orcamentoCadastrado = true;
            }
            catch (Exception ex)
            {
                ConnBD.Desconectar();
                Console.WriteLine(ex.Message);
                orcamentoCadastrado = false;
            }

            return orcamentoCadastrado;
        }
    }
}
