using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Autocenter_v2.DAO
{
    class Connection
    {
        SqlConnection Con = new SqlConnection();

        string DadosConexao = @"Data Source=DESKTOP-E2DHC11\SQLEXPRESS"
                            + ";Initial Catalog=projeto_aed2"
                            + ";Integrated Security=True"
                            + ";";

        //Construtor
        public Connection()
        {
            Con.ConnectionString = DadosConexao;    //@"Data Source=BRLNB35\SQLEXPRESS;Initial Catalog=projeto_ucl;Integrated Security=True";

        }

        //Metodo Conectar
        public SqlConnection Conectar()
        {
            if (Con.State == System.Data.ConnectionState.Closed)     //Verifica se não está fechada
            {
                Con.Open();                                        //Abre Conexão
            }

            return Con;
        }

        //Metodo Desconectar
        public void Desconectar()
        {
            if (Con.State == System.Data.ConnectionState.Open)      //Verifica se a Conexão está aberta
            {
                Con.Close();                                        //Fecha Conexão
            }

        }
    }
}
  