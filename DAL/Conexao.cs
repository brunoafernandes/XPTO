using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Conexao
    {
        public static SqlConnection sqlconnection = new SqlConnection();
        //public static SqlCommand comando = new SqlCommand();
        public static SqlParameter parametro = new SqlParameter();

        public SqlConnection conexao()
        {
            try
            {
                string dadosConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=XPTO;Integrated Security=TRUE";

                sqlconnection = new SqlConnection(dadosConexao);
                
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                
                return sqlconnection;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Open()
        {
            sqlconnection.Open();
        }

        public void Close()
        {
            sqlconnection.Close();
        }

        public DataTable ExecutaConsulta(SqlCommand comando )
        {
            try
            {
                comando.Connection = conexao();
           
                //comando.CommandText = sql;
                comando.ExecuteScalar();

                IDataReader dtreader = comando.ExecuteReader();
                DataTable dtresult = new DataTable();
                dtresult.Load(dtreader);

                sqlconnection.Close();

                return dtresult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecutaAtualizacao(SqlCommand comando)
        {
            try
            {
                comando.Connection = conexao();
                //comando.CommandText = sql;
    
                int result = comando.ExecuteNonQuery();
                sqlconnection.Close();
    
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
