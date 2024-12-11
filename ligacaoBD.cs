using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

// namespace Projecto_03__Duas_comboboxes_

public class Conexao
    {//modificada em 2023-02-03: o membro strConnection passa a ser static

        //este membro é acedido diretamente pela classe e não pelo objeto (static)
        public static string strConnection = "data source=62.28.39.135,62444;Initial Catalog=kkAdamastorRicardoLopes;User Id=EFA0124;Password=123.Abc;TrustServerCertificate=True";

        public DataTable BuscarDados(string strSQL)
        {
            //criar uma conexão:
            SqlConnection C = new SqlConnection(strConnection);
            C.Open();

            //criar comando SQL para extrair os dados pretendidos:
            SqlCommand command = C.CreateCommand();
            command.CommandText = strSQL;

            //trazer os dados da tabela especificada para uma "tabela" em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);

            //desligar a conexão:
            C.Close();
            return dt;
        }
    }



