using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Business
{
    public class Pessoas
    {
        public List<Entidade.Pessoa> LerArquivoPessoas(string nomeArquivo)
        {
            try
            {
                List<Entidade.Pessoa> listaPessoas = new List<Entidade.Pessoa>();
                using (StreamReader reader = new StreamReader(nomeArquivo))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        List<string> listaLinhas = new List<string>();
                        listaLinhas = linha.Split(';').ToList<string>();

                        foreach (string valorLinha in listaLinhas)
                        {
                            List<string> listaColunas = new List<string>();
                            Entidade.Pessoa entidadePessoas = new Entidade.Pessoa();

                            listaColunas = valorLinha.Split(',').ToList<string>();
                            if (listaColunas.Count < 7 || listaColunas.Count > 7)
                            {
                                return null;
                            }
                            else
                            {
                                entidadePessoas.Id = Int32.Parse(listaColunas[0].ToString());
                                entidadePessoas.Nome = listaColunas[1].ToString();
                                entidadePessoas.Sobrenome = listaColunas[2].ToString();
                                entidadePessoas.Nascimento = DateTime.Parse(listaColunas[3].ToString());
                                entidadePessoas.Sexo = listaColunas[4].ToString();
                                entidadePessoas.Email = listaColunas[5].ToString();
                                entidadePessoas.Ativo = bool.Parse(listaColunas[6].ToString());
                                listaPessoas.Add(entidadePessoas);
                            }

                        }

                    }
                }
                return listaPessoas;
            }
            catch(Exception ex)
            {
                throw ex;
            }
                
        }

        public List<Entidade.Pessoa> LerArquivoPessoas(Stream arquivo)
        {
            try
            {
                List<Entidade.Pessoa> listaPessoas = new List<Entidade.Pessoa>();
                using (StreamReader reader = new StreamReader(arquivo))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        List<string> listaLinhas = new List<string>();
                        listaLinhas = linha.Split(';').ToList<string>();

                        foreach (string valorLinha in listaLinhas)
                        {
                            List<string> listaColunas = new List<string>();
                            Entidade.Pessoa entidadePessoas = new Entidade.Pessoa();

                            listaColunas = valorLinha.Split(',').ToList<string>();
                            if (listaColunas.Count < 7 || listaColunas.Count > 7)
                            {
                                return null;
                            }
                            else
                            {
                                entidadePessoas.Id = Int32.Parse(listaColunas[0].ToString());
                                entidadePessoas.Nome = listaColunas[1].ToString();
                                entidadePessoas.Sobrenome = listaColunas[2].ToString();
                                entidadePessoas.Nascimento = DateTime.Parse(listaColunas[3].ToString());
                                entidadePessoas.Sexo = listaColunas[4].ToString();
                                entidadePessoas.Email = listaColunas[5].ToString();
                                entidadePessoas.Ativo = bool.Parse(listaColunas[6].ToString());
                                listaPessoas.Add(entidadePessoas);
                            }

                        }

                    }
                }
                return listaPessoas;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool ManterPessoas(List<Entidade.Pessoa> listaPessoas)
        {
            try
            {
                foreach (Entidade.Pessoa pessoa in listaPessoas)
                {
                    DAL.Pessoas pessoasDAL = new DAL.Pessoas();
                    if(pessoasDAL.manterPessoas(pessoa) == 0)
                    {
                        return false;
                    }

                }

                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            

        }

        public IEnumerable<Entidade.PessoaProduto> ConsultaPessoasProdutos()
        {
            try
            {
                DAL.Pessoas PessoasDAL = new DAL.Pessoas();
                DAL.Produtos ProdutosDAL = new DAL.Produtos();

                List<Entidade.Pessoa> listaPessoas = PessoasDAL.ConsultaPessoas();
                List<Entidade.Produto> listaProdutos = ProdutosDAL.ConsultaProdutos();

                var query = from pes in listaPessoas
                            from pro in listaProdutos
                            where pes.Id == pro.IdPessoa && pes.Ativo == true
                            select new Entidade.PessoaProduto
                            {
                                Nome = pes.Nome,
                                SobreNome = pes.Sobrenome,
                                Nascimento = pes.Nascimento,
                                Sexo = pes.Sexo,
                                Email = pes.Email,
                                NomeProduto = pro.Nome,
                                Ativo = pes.Ativo
                            };

                return query;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

    }
}
