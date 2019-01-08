using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplicationInterfaceXPTO
{
    public partial class Pessoas : System.Web.UI.Page
    {
        private static Stream arquivo;
        
        private static List<Entidade.Pessoa> ListaPessoas = new List<Entidade.Pessoa>();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (fileUploadPessoas.FileName != "")
            {
                arquivo = fileUploadPessoas.FileContent;
                Business.Pessoas PessoasBusiness = new Business.Pessoas();
                ListaPessoas = PessoasBusiness.LerArquivoPessoas(arquivo);
                Session.Add("listaPessoas",ListaPessoas);
                if (ListaPessoas == null)
                {
                    Response.Write("<script>alert('Ocorreu um erro ao ler arquivo de pessoas, verifique se o arquivo está correto');</script>");
                }
                else
                {
                    gvPessoas.DataSource = ListaPessoas;
                    gvPessoas.DataBind();
                }

                


            }
        }

        protected void btnSalvarArquivoPessoas_Click(object sender, EventArgs e)
        {
            ListaPessoas = (List<Entidade.Pessoa>)this.Session["listaPessoas"];
            if (ListaPessoas.Count <= 0)
            {
                Response.Write("<script>alert('Favor inserir arquivo de Pessoas');</script>");
            }
            else
            {
                Business.Pessoas pessoaBusiness = new Business.Pessoas();

                if (pessoaBusiness.ManterPessoas(ListaPessoas) == true)
                {
                    Response.Write("<script>alert('Lista de pessoas cadastrada com sucesso');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Ocorreu um erro ao cadastrar lista de pessoas');</script>");
                }
                arquivo = null;
                gvPessoas.DataSource = null;
                gvPessoas.DataBind();
                ListaPessoas = new List<Entidade.Pessoa>();

            }
        }
    }
}