namespace WindowsFormsInterface
{
    partial class XPTO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLerArquivoPessoa = new System.Windows.Forms.Button();
            this.btnSelecionarArquivoPessoa = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.lblArquivoPessoas = new System.Windows.Forms.Label();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.btnSalvarPessoas = new System.Windows.Forms.Button();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.txtArquivoProduto = new System.Windows.Forms.TextBox();
            this.btnSelecionarArquivoProduto = new System.Windows.Forms.Button();
            this.btnLerArquivoProduto = new System.Windows.Forms.Button();
            this.btnSalvarProdutos = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.bntConsulta = new System.Windows.Forms.Button();
            this.dgvConsultaClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLerArquivoPessoa
            // 
            this.btnLerArquivoPessoa.Location = new System.Drawing.Point(566, 12);
            this.btnLerArquivoPessoa.Name = "btnLerArquivoPessoa";
            this.btnLerArquivoPessoa.Size = new System.Drawing.Size(124, 23);
            this.btnLerArquivoPessoa.TabIndex = 0;
            this.btnLerArquivoPessoa.Text = "Ler Arquivo Pessoa";
            this.btnLerArquivoPessoa.UseVisualStyleBackColor = true;
            this.btnLerArquivoPessoa.Click += new System.EventHandler(this.btnLerArquivo_Click);
            // 
            // btnSelecionarArquivoPessoa
            // 
            this.btnSelecionarArquivoPessoa.Location = new System.Drawing.Point(529, 13);
            this.btnSelecionarArquivoPessoa.Name = "btnSelecionarArquivoPessoa";
            this.btnSelecionarArquivoPessoa.Size = new System.Drawing.Size(31, 20);
            this.btnSelecionarArquivoPessoa.TabIndex = 1;
            this.btnSelecionarArquivoPessoa.Text = "...";
            this.btnSelecionarArquivoPessoa.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivoPessoa.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(151, 13);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(372, 20);
            this.txtArquivo.TabIndex = 2;
            // 
            // lblArquivoPessoas
            // 
            this.lblArquivoPessoas.AutoSize = true;
            this.lblArquivoPessoas.Location = new System.Drawing.Point(7, 17);
            this.lblArquivoPessoas.Name = "lblArquivoPessoas";
            this.lblArquivoPessoas.Size = new System.Drawing.Size(138, 13);
            this.lblArquivoPessoas.TabIndex = 3;
            this.lblArquivoPessoas.Text = "Selecionar arquivo Pessoas";
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Location = new System.Drawing.Point(13, 55);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.Size = new System.Drawing.Size(797, 150);
            this.dgvPessoas.TabIndex = 4;
            // 
            // btnSalvarPessoas
            // 
            this.btnSalvarPessoas.Location = new System.Drawing.Point(696, 12);
            this.btnSalvarPessoas.Name = "btnSalvarPessoas";
            this.btnSalvarPessoas.Size = new System.Drawing.Size(114, 23);
            this.btnSalvarPessoas.TabIndex = 5;
            this.btnSalvarPessoas.Text = "Salvar Pessoas";
            this.btnSalvarPessoas.UseVisualStyleBackColor = true;
            this.btnSalvarPessoas.Click += new System.EventHandler(this.btnSalvarPessoas_Click);
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(12, 242);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(135, 13);
            this.lblProdutos.TabIndex = 6;
            this.lblProdutos.Text = "Selecionar arquivo Produto";
            // 
            // txtArquivoProduto
            // 
            this.txtArquivoProduto.Location = new System.Drawing.Point(151, 238);
            this.txtArquivoProduto.Name = "txtArquivoProduto";
            this.txtArquivoProduto.Size = new System.Drawing.Size(372, 20);
            this.txtArquivoProduto.TabIndex = 7;
            // 
            // btnSelecionarArquivoProduto
            // 
            this.btnSelecionarArquivoProduto.Location = new System.Drawing.Point(529, 238);
            this.btnSelecionarArquivoProduto.Name = "btnSelecionarArquivoProduto";
            this.btnSelecionarArquivoProduto.Size = new System.Drawing.Size(31, 20);
            this.btnSelecionarArquivoProduto.TabIndex = 8;
            this.btnSelecionarArquivoProduto.Text = "...";
            this.btnSelecionarArquivoProduto.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivoProduto.Click += new System.EventHandler(this.btnSelecionarArquivoProduto_Click);
            // 
            // btnLerArquivoProduto
            // 
            this.btnLerArquivoProduto.Location = new System.Drawing.Point(566, 237);
            this.btnLerArquivoProduto.Name = "btnLerArquivoProduto";
            this.btnLerArquivoProduto.Size = new System.Drawing.Size(124, 23);
            this.btnLerArquivoProduto.TabIndex = 10;
            this.btnLerArquivoProduto.Text = "Ler Arquivo Produto";
            this.btnLerArquivoProduto.UseVisualStyleBackColor = true;
            this.btnLerArquivoProduto.Click += new System.EventHandler(this.btnLerArquivoProduto_Click);
            // 
            // btnSalvarProdutos
            // 
            this.btnSalvarProdutos.Location = new System.Drawing.Point(696, 237);
            this.btnSalvarProdutos.Name = "btnSalvarProdutos";
            this.btnSalvarProdutos.Size = new System.Drawing.Size(114, 23);
            this.btnSalvarProdutos.TabIndex = 11;
            this.btnSalvarProdutos.Text = "Salvar Produtos";
            this.btnSalvarProdutos.UseVisualStyleBackColor = true;
            this.btnSalvarProdutos.Click += new System.EventHandler(this.btnSalvarProdutos_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(15, 279);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(795, 130);
            this.dgvProdutos.TabIndex = 12;
            // 
            // bntConsulta
            // 
            this.bntConsulta.Location = new System.Drawing.Point(15, 463);
            this.bntConsulta.Name = "bntConsulta";
            this.bntConsulta.Size = new System.Drawing.Size(148, 23);
            this.bntConsulta.TabIndex = 13;
            this.bntConsulta.Text = "Consulta Clientes Ativos";
            this.bntConsulta.UseVisualStyleBackColor = true;
            this.bntConsulta.Click += new System.EventHandler(this.bntConsulta_Click);
            // 
            // dgvConsultaClientes
            // 
            this.dgvConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaClientes.Location = new System.Drawing.Point(15, 517);
            this.dgvConsultaClientes.Name = "dgvConsultaClientes";
            this.dgvConsultaClientes.Size = new System.Drawing.Size(795, 150);
            this.dgvConsultaClientes.TabIndex = 14;
            // 
            // XPTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 695);
            this.Controls.Add(this.dgvConsultaClientes);
            this.Controls.Add(this.bntConsulta);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnSalvarProdutos);
            this.Controls.Add(this.btnLerArquivoProduto);
            this.Controls.Add(this.btnSelecionarArquivoProduto);
            this.Controls.Add(this.txtArquivoProduto);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.btnSalvarPessoas);
            this.Controls.Add(this.dgvPessoas);
            this.Controls.Add(this.lblArquivoPessoas);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btnSelecionarArquivoPessoa);
            this.Controls.Add(this.btnLerArquivoPessoa);
            this.Name = "XPTO";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLerArquivoPessoa;
        private System.Windows.Forms.Button btnSelecionarArquivoPessoa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label lblArquivoPessoas;
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.Button btnSalvarPessoas;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.TextBox txtArquivoProduto;
        private System.Windows.Forms.Button btnSelecionarArquivoProduto;
        private System.Windows.Forms.Button btnLerArquivoProduto;
        private System.Windows.Forms.Button btnSalvarProdutos;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button bntConsulta;
        private System.Windows.Forms.DataGridView dgvConsultaClientes;
    }
}

