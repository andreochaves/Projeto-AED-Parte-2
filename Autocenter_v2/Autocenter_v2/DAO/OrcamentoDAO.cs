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
            cmd.CommandText = @"INSERT INTO Cliente
           (nome
           , cpf
           , endereco
           , idade
           , qtd_pontos_fidelidade)
     VALUES
            (@nome
           , @cpf
           , @endereco
            , @idade
           , @qtd_pontos_fidelidade)";  //Comando Sql

            cmd.Parameters.AddWithValue("@nome", cliente.getNome());     //Recebe Valor p/ Pesquisa no BD
            cmd.Parameters.AddWithValue("@cpf", cliente.getCPF());
            cmd.Parameters.AddWithValue("@endereco", cliente.getEndereco());
            cmd.Parameters.AddWithValue("@idade", cliente.getIdade());
            cmd.Parameters.AddWithValue("@qtd_pontos_fidelidade", cliente.getQtdPontosFidelidade());

            bool usuarioCadastrado = false;
            try
            {
                cmd.Connection = ConnBD.Conectar();     //Abre Conexão com o BD
                dr = cmd.ExecuteReader();                  //Armazena Informações do BD
                ConnBD.Desconectar();
                usuarioCadastrado = true;
            }
            catch (Exception ex)
            {
                ConnBD.Desconectar();
                Console.WriteLine(ex.Message);
                usuarioCadastrado = false;
            }

            return usuarioCadastrado;
        }
}
