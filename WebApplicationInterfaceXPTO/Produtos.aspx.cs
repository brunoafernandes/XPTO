using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplicationInterfaceXPTO
{
    public partial class Produtos : System.Web.UI.Page
    {

        private static Stream arquivo;
                
        private static List<Entidade.Produto> ListaProdutos = new List<Entidade.Produto>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (fileUploadProdutos.FileName != "")
            {
                arquivo = fileUploadProdutos.FileContent;
                Business.Produtos ProdutosBusiness = new Business.Produtos();
                ListaProdutos = ProdutosBusiness.LerArquivoProdutos(arquivo);
                Session.Add("listaProdutos", ListaProdutos);
                if (ListaProdutos == null)
                {
                    Response.Write("<script>alert('Ocorreu um erro ao ler arquivo de produtos, verifique se o arquivo está correto');</script>");
                }
                else
                {
                    gvProdutos.DataSource = ListaProdutos;
                    gvProdutos.DataBind();
                }


            }
        }

        protected void btnSalvarProdutos_Click(object sender, EventArgs e)
        {
            ListaProdutos = (List<Entidade.Produto>)this.Session["listaProdutos"];
            if (ListaProdutos.Count <= 0)
            {
                Response.Write("<script>alert('Favor inserir arquivo de Produtos');</script>");
            }
            else
            {
                Business.Produtos produtosBusiness = new Business.Produtos();

                if (produtosBusiness.ManterProdutos(ListaProdutos) == true)
                {
                    Response.Write("<script>alert('Lista de produtos cadastrada com sucesso');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Ocorreu um erro ao cadastrar lista de produtos');</script>");
                }
                arquivo = null;
                gvProdutos.DataSource = null;
                gvProdutos.DataBind();
                ListaProdutos = new List<Entidade.Produto>();

            }
        }
    }
}