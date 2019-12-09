using Autocenter_v2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Autocenter_v2.DAO
{
    class MotoDAO
    {
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        Connection ConnBD = new Connection();

        public bool inserirMoto(Moto moto)
        {
            cmd.CommandText = @"INSERT INTO Cliente
           (marca
           , modelo
           , placa
           , cor
           , cilindradas)
     VALUES
            (@marca
           , @modelo
           , @placa
           , @cor
           , @cilindradas)";  //Comando Sql

            cmd.Parameters.AddWithValue("@marca", moto.getMarca());     //Recebe Valor p/ Pesquisa no BD
            cmd.Parameters.AddWithValue("@modelo", moto.getModelo());
            cmd.Parameters.AddWithValue("@placa", moto.getPlaca());
            cmd.Parameters.AddWithValue("@cor", moto.getCor());
            cmd.Parameters.AddWithValue("@cilindradas", moto.getCilindradas());

            bool motoCadastrado = false;
            try
            {
                cmd.Connection = ConnBD.Conectar();     //Abre Conexão com o BD
                dr = cmd.ExecuteReader();                  //Armazena Informações do BD
                ConnBD.Desconectar();
                motoCadastrado = true;
            }
            catch (Exception ex)
            {
                ConnBD.Desconectar();
                Console.WriteLine(ex.Message);
                motoCadastrado = false;
            }

            return motoCadastrado;
        }
    }
}
