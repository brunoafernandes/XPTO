using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsInterface
{
    public partial class XPTO : Form
    {
        private string nomeArquivo;
        private string nomeArquivoProduto;
        private List<Entidade.Pessoa> ListaPessoas = new List<Entidade.Pessoa>();
        private List<Entidade.Produto> ListaProdutos = new List<Entidade.Produto>();
        public XPTO()
        {
            InitializeComponent();
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                nomeArquivo = openFileDialog1.FileName;
                txtArquivo.Text = nomeArquivo;
                
            }
        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            if (nomeArquivo == null)
            {
                MessageBox.Show("Selecione um arquivo de pessoas");
            }
            else
            {

                Business.Pessoas PessoasBusiness = new Business.Pessoas();
                ListaPessoas = PessoasBusiness.LerArquivoPessoas(nomeArquivo);
                if (ListaPessoas == null)
                {
                    MessageBox.Show("Ocorreu um erro ao ler arquivo de pessoas, verifique se o arquivo está correto");
                }
                else
                {
                    dgvPessoas.DataSource = ListaPessoas;
                }
            }
        }

        private void btnSalvarPessoas_Click(object sender, EventArgs e)
        {
            if (ListaPessoas.Count <= 0)
            {
                MessageBox.Show("Favor inserir arquivo de Pessoas");
            }
            else
            {
                Business.Pessoas pessoaBusiness = new Business.Pessoas();

                if(pessoaBusiness.ManterPessoas(ListaPessoas) == true)
                {
                    MessageBox.Show("Lista de pessoas cadastrada com sucesso");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar lista de pessoas");
                }
                nomeArquivo = "";
                txtArquivo.Text = "";
                dgvPessoas.DataSource = null;
                ListaPessoas = new List<Entidade.Pessoa>();

            }
        }

        private void btnSelecionarArquivoProduto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                nomeArquivoProduto = openFileDialog1.FileName;
                txtArquivoProduto.Text = nomeArquivoProduto;

            }
        }

        private void btnLerArquivoProduto_Click(object sender, EventArgs e)
        {
            if (nomeArquivoProduto == null)
            {
                MessageBox.Show("Selecione um arquivo de produtos");
            }
            else
            {
                Business.Produtos ProdutosBusiness = new Business.Produtos();
                ListaProdutos = ProdutosBusiness.LerArquivoProdutos(nomeArquivoProduto);
                if (ListaProdutos == null)
                {
                    MessageBox.Show("Ocorreu um erro ao ler arquivo de produtos, verifique se o arquivo está correto");
                }
                else
                {
                    dgvProdutos.DataSource = ListaProdutos;
                }
            }
        }

        private void btnSalvarProdutos_Click(object sender, EventArgs e)
        {
            if (ListaProdutos.Count <= 0)
            {
                MessageBox.Show("Favor inserir arquivo de Pessoas");
            }
            else
            {
                Business.Produtos produtosBusiness = new Business.Produtos();

                if (produtosBusiness.ManterProdutos(ListaProdutos) == true)
                {
                    MessageBox.Show("Lista de produtos cadastrada com sucesso");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar lista de produtos");
                }
                nomeArquivoProduto = "";
                txtArquivoProduto.Text = "";
                dgvProdutos.DataSource = null;
                ListaProdutos = new List<Entidade.Produto>();

            }
        }

        private void bntConsulta_Click(object sender, EventArgs e)
        {
            
            Business.Pessoas businessPessoas = new Business.Pessoas();
            IEnumerable<Entidade.PessoaProduto> pessoaProduto = businessPessoas.ConsultaPessoasProdutos();

            dgvConsultaClientes.DataSource = pessoaProduto.ToList<Entidade.PessoaProduto>();

        }
    }
}
