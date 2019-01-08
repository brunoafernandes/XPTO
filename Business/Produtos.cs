using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Business
{
    public class Produtos
    {
        public List<Entidade.Produto> LerArquivoProdutos(string nomeArquivo)
        {
            try
            {
                List<Entidade.Produto> listaProdutos = new List<Entidade.Produto>();
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
                            Entidade.Produto entidadeProduto = new Entidade.Produto();

                            listaColunas = valorLinha.Split(',').ToList<string>();
                            if (listaColunas.Count < 3 || listaColunas.Count > 3)
                            {
                                return null;
                            }
                            else
                            {
                                entidadeProduto.Id = Int32.Parse(listaColunas[0].ToString());
                                entidadeProduto.IdPessoa = Int32.Parse(listaColunas[1].ToString());
                                entidadeProduto.Nome = listaColunas[2].ToString();
                                listaProdutos.Add(entidadeProduto);
                            }

                        }

                    }
                }
                return listaProdutos;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Entidade.Produto> LerArquivoProdutos(Stream arquivo)
        {
            try
            {
                List<Entidade.Produto> listaProdutos = new List<Entidade.Produto>();
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
                            Entidade.Produto entidadeProduto = new Entidade.Produto();

                            listaColunas = valorLinha.Split(',').ToList<string>();
                            if (listaColunas.Count < 3 || listaColunas.Count > 3)
                            {
                                return null;
                            }
                            else
                            {
                                entidadeProduto.Id = Int32.Parse(listaColunas[0].ToString());
                                entidadeProduto.IdPessoa = Int32.Parse(listaColunas[1].ToString());
                                entidadeProduto.Nome = listaColunas[2].ToString();
                                listaProdutos.Add(entidadeProduto);
                            }

                        }

                    }
                }
                return listaProdutos;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public bool ManterProdutos(List<Entidade.Produto> listaProdutos)
        {
            try
            {
                foreach (Entidade.Produto produto in listaProdutos)
                {
                    DAL.Produtos produtosDAL = new DAL.Produtos();
                    if (produtosDAL.manterProdutos(produto) == 0)
                    {
                        return false;
                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
