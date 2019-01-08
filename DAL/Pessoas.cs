using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Pessoas
    {
        public int manterPessoas(Entidade.Pessoa pessoa)
        {
            try
            {
                Conexao con = new Conexao();

                SqlCommand sqlComando = new SqlCommand("sp_Pessoas_InsertUpdate");
                sqlComando.Parameters.AddWithValue("@id", pessoa.Id);
                sqlComando.Parameters.AddWithValue("@nome", pessoa.Nome);
                sqlComando.Parameters.AddWithValue("@sobreNome", pessoa.Sobrenome);
                sqlComando.Parameters.AddWithValue("@nascimento", pessoa.Nascimento);
                sqlComando.Parameters.AddWithValue("@sexo", pessoa.Sexo);
                sqlComando.Parameters.AddWithValue("@email", pessoa.Email);
                sqlComando.Parameters.AddWithValue("@ativo", pessoa.Ativo);

                sqlComando.CommandType = CommandType.StoredProcedure;

                return con.ExecutaAtualizacao(sqlComando);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Entidade.Pessoa> ConsultaPessoas()
        {
            try
            {
                List<Entidade.Pessoa> listaPessoas = new List<Entidade.Pessoa>();

                Conexao con = new Conexao();

                SqlCommand sqlComando = new SqlCommand("select * from pessoa");

                sqlComando.CommandType = CommandType.Text;

                DataTable dtTable = con.ExecutaConsulta(sqlComando);

                foreach (DataRow row in dtTable.Rows)
                {
                    Entidade.Pessoa pessoa = new Entidade.Pessoa();
                    pessoa.Id = Int32.Parse(row[0].ToString());
                    pessoa.Nome = row[1].ToString();
                    pessoa.Sobrenome = row[2].ToString();
                    pessoa.Nascimento = DateTime.Parse(row[3].ToString());
                    pessoa.Sexo = row[4].ToString();
                    pessoa.Email = row[5].ToString();
                    pessoa.Ativo = bool.Parse(row[6].ToString());

                    listaPessoas.Add(pessoa);
                }

                return listaPessoas;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

            
        


    }
}
