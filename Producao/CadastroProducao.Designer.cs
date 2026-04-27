namespace DataShift.Producao
{
    partial class CadastroProducao
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
            this.labelData = new System.Windows.Forms.Label();
            this.labelInicio = new System.Windows.Forms.Label();
            this.labelFim = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxInicio = new System.Windows.Forms.TextBox();
            this.textBoxTermino = new System.Windows.Forms.TextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.labelProdutoSelecionado = new System.Windows.Forms.Label();
            this.textBoxProdutoSelecionado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(86, 128);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(44, 20);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data";
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelInicio.Location = new System.Drawing.Point(86, 210);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(122, 20);
            this.labelInicio.TabIndex = 1;
            this.labelInicio.Text = "Horário de inicio";
            // 
            // labelFim
            // 
            this.labelFim.AutoSize = true;
            this.labelFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelFim.Location = new System.Drawing.Point(86, 257);
            this.labelFim.Name = "labelFim";
            this.labelFim.Size = new System.Drawing.Size(140, 20);
            this.labelFim.TabIndex = 2;
            this.labelFim.Text = "Horário do término";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(284, 130);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(185, 20);
            this.textBoxData.TabIndex = 3;
            // 
            // textBoxInicio
            // 
            this.textBoxInicio.Location = new System.Drawing.Point(284, 212);
            this.textBoxInicio.Name = "textBoxInicio";
            this.textBoxInicio.Size = new System.Drawing.Size(185, 20);
            this.textBoxInicio.TabIndex = 4;
            // 
            // textBoxTermino
            // 
            this.textBoxTermino.Location = new System.Drawing.Point(284, 259);
            this.textBoxTermino.Name = "textBoxTermino";
            this.textBoxTermino.Size = new System.Drawing.Size(185, 20);
            this.textBoxTermino.TabIndex = 5;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(284, 336);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 6;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(394, 336);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelQuantidade.Location = new System.Drawing.Point(86, 173);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(167, 20);
            this.labelQuantidade.TabIndex = 8;
            this.labelQuantidade.Text = "Quantidade Produzida";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(284, 173);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(185, 20);
            this.textBoxQuantidade.TabIndex = 9;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(12, 12);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 10;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelRegistro.Location = new System.Drawing.Point(219, 36);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(326, 37);
            this.labelRegistro.TabIndex = 11;
            this.labelRegistro.Text = "Registro de Produção";
            // 
            // labelProdutoSelecionado
            // 
            this.labelProdutoSelecionado.AutoSize = true;
            this.labelProdutoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutoSelecionado.Location = new System.Drawing.Point(9, 78);
            this.labelProdutoSelecionado.Name = "labelProdutoSelecionado";
            this.labelProdutoSelecionado.Size = new System.Drawing.Size(154, 20);
            this.labelProdutoSelecionado.TabIndex = 12;
            this.labelProdutoSelecionado.Text = "Produto selecionado";
            // 
            // textBoxProdutoSelecionado
            // 
            this.textBoxProdutoSelecionado.Enabled = false;
            this.textBoxProdutoSelecionado.Location = new System.Drawing.Point(169, 80);
            this.textBoxProdutoSelecionado.Name = "textBoxProdutoSelecionado";
            this.textBoxProdutoSelecionado.Size = new System.Drawing.Size(100, 20);
            this.textBoxProdutoSelecionado.TabIndex = 13;
            // 
            // CadastroProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxProdutoSelecionado);
            this.Controls.Add(this.labelProdutoSelecionado);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.textBoxTermino);
            this.Controls.Add(this.textBoxInicio);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelFim);
            this.Controls.Add(this.labelInicio);
            this.Controls.Add(this.labelData);
            this.Name = "CadastroProducao";
            this.Text = "lançamento de Produção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Label labelFim;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxInicio;
        private System.Windows.Forms.TextBox textBoxTermino;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.Label labelProdutoSelecionado;
        private System.Windows.Forms.TextBox textBoxProdutoSelecionado;
    }
}