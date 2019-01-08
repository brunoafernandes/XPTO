using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Produtos
    {
        public int manterProdutos(Entidade.Produto produto)
        {
            try
            {
                Conexao con = new Conexao();

                SqlCommand sqlComando = new SqlCommand("sp_Produtos_InsertUpdate");
                sqlComando.Parameters.AddWithValue("@id", produto.Id);
                sqlComando.Parameters.AddWithValue("@idPessoa", produto.IdPessoa);
                sqlComando.Parameters.AddWithValue("@nome", produto.Nome);

                sqlComando.CommandType = CommandType.StoredProcedure;

                return con.ExecutaAtualizacao(sqlComando);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Entidade.Produto> ConsultaProdutos()
        {
            try
            {
                List<Entidade.Produto> listaProdutos = new List<Entidade.Produto>();

                Conexao con = new Conexao();

                SqlCommand sqlComando = new SqlCommand("select * from produto");

                sqlComando.CommandType = CommandType.Text;

                DataTable dtTable = con.ExecutaConsulta(sqlComando);

                foreach (DataRow row in dtTable.Rows)
                {
                    Entidade.Produto produto = new Entidade.Produto();
                    produto.Id = Int32.Parse(row[0].ToString());
                    produto.IdPessoa = Int32.Parse(row[1].ToString());
                    produto.Nome = row[2].ToString();
                    
                    listaProdutos.Add(produto);
                }

                return listaProdutos;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
