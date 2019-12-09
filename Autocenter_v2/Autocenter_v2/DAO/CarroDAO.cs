using Autocenter_v2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Autocenter_v2.DAO
{
    class CarroDAO
    {

        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        Connection ConnBD = new Connection();

        public bool inserirCarro(Carro carro)
        {
            cmd.CommandText = @"INSERT INTO Cliente
           (marca
           , modelo
           , placa
           , cor
           , cavalos
           , torque_motor)
     VALUES
            (@marca
           , @modelo
           , @placa
           , @cor
           , @cavalos
           , @torque_motor)";  //Comando Sql

            cmd.Parameters.AddWithValue("@marca", carro.getMarca());     //Recebe Valor p/ Pesquisa no BD
            cmd.Parameters.AddWithValue("@modelo", carro.getModelo());
            cmd.Parameters.AddWithValue("@placa", carro.getPlaca());
            cmd.Parameters.AddWithValue("@cor", carro.getCor());
            cmd.Parameters.AddWithValue("@cavalos", carro.getCavalos());
            cmd.Parameters.AddWithValue("@torque_motor", carro.getTorqueMotor());

            bool carroCadastrado = false;
            try
            {
                cmd.Connection = ConnBD.Conectar();     //Abre Conexão com o BD
                dr = cmd.ExecuteReader();                  //Armazena Informações do BD
                ConnBD.Desconectar();
                carroCadastrado = true;
            }
            catch (Exception ex)
            {
                ConnBD.Desconectar();
                Console.WriteLine(ex.Message);
                carroCadastrado = false;
            }

            return carroCadastrado;
        }

    }
}
