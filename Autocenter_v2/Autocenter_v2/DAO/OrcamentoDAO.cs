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

        public void exibirServicos()
        {
            cmd.CommandText = @"SELECT nome FROM Servico";  //Comando Sql
            try
            {
                cmd.Connection = ConnBD.Conectar();     //Abre Conexão com o BD
                dr = cmd.ExecuteReader();                  //Armazena Informações do BD

                if (dr.HasRows)                            //Verifica se Encontrou Dados no BD
                {
                    foreach (string s in dr)
                    {
                        Console.WriteLine(s);
                    }
                }
                ConnBD.Desconectar();
            }
            catch (Exception ex)
            {
                ConnBD.Desconectar();
                Console.WriteLine(ex.Message);
            }

        }

        public bool inserirOrcamento(Orcamento orcamento)
        {
            cmd.CommandText = @"INSERT INTO Orcamento
           (cpfCliente
           , veiculo
           , placa
           , servico
           , formaPagamento
           , valorTotal)
     VALUES
           (@cpfCliente
           , @veiculo
           , @placa
           , @servico
           , @formaPagamento
           , @valorTotal)";  //Comando Sql

            cmd.Parameters.AddWithValue("@cpfCliente", orcamento.getCPFCliente());     //Recebe Valor p/ Pesquisa no BD
            cmd.Parameters.AddWithValue("@veiculo", orcamento.getVeiculo());
            cmd.Parameters.AddWithValue("@placa", orcamento.getPlaca());
           // cmd.Parameters.AddWithValue("@servico", orcamento.getServicos());
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
