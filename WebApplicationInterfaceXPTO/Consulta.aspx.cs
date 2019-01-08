using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationInterfaceXPTO
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Business.Pessoas businessPessoas = new Business.Pessoas();
            IEnumerable<Entidade.PessoaProduto> pessoaProduto = businessPessoas.ConsultaPessoasProdutos();

            gvConsulta.DataSource = pessoaProduto.ToList<Entidade.PessoaProduto>();
            gvConsulta.DataBind();
        }
    }
}