using Autocenter_v2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Autocenter_v2.DAO
{
    class ClienteDAO
    {

        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        Connection ConnBD = new Connection();

        public bool cadastrarCliente(Cliente cliente) {
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

            bool usuarioCadastrado = false;
            try
            {
                cmd.Connection = ConnBD.Conectar();     //Abre Conexão com o BD
                dr = cmd.ExecuteReader();                  //Armazena Informações do BD

                if (dr.HasRows)                            //Verifica se Encontrou Dados no BD
                {
                    usuarioCadastrado = true;   
                }
                ConnBD.Desconectar();
            }
            catch (Exception ex)
            {
                ConnBD.Desconectar();
                Console.WriteLine(ex.Message);
            }

            return usuarioCadastrado;
        }
    }
}
