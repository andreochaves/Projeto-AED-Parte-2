using Autocenter_v2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Autocenter_v2.DAO
{
    public class FuncionarioDAO
    {
        
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        Connection ConnBD = new Connection();

        public bool Logar(Funcionario func)
        {
            cmd.CommandText = "SELECT * FROM Funcionario Func WHERE Func.usuario = @usuario and Func.senha = @senha";  //Comando Sql

            cmd.Parameters.AddWithValue("@usuario", func.getUsuario());     //Recebe Valor p/ Pesquisa no BD
            cmd.Parameters.AddWithValue("@senha", func.getSenha());     

            bool Validacao = false;

            try
            {
                cmd.Connection = ConnBD.Conectar();     //Abre Conexão com o BD
                dr = cmd.ExecuteReader();                  //Armazena Informações do BD

                if (dr.HasRows)                            //Verifica se Encontrou Dados no BD
                {
                    Validacao = true;
                }
                ConnBD.Desconectar();
            }
            catch (Exception ex)
            {
                ConnBD.Desconectar();
                Console.WriteLine(ex.Message);
            }

            return Validacao;
        }

    }
}

