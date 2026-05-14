namespace DataShift.Produtos
{
    partial class CadastroProduto
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelPerecivel = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.comboBoxPerecivel = new System.Windows.Forms.ComboBox();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(106, 180);
            this.labelNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(75, 238);
            this.labelPreco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(113, 20);
            this.labelPreco.TabIndex = 1;
            this.labelPreco.Text = "Preço unitário";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(91, 292);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(81, 20);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelPerecivel
            // 
            this.labelPerecivel.AutoSize = true;
            this.labelPerecivel.Location = new System.Drawing.Point(90, 366);
            this.labelPerecivel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPerecivel.Name = "labelPerecivel";
            this.labelPerecivel.Size = new System.Drawing.Size(78, 20);
            this.labelPerecivel.TabIndex = 3;
            this.labelPerecivel.Text = "Perecível";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(326, 465);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(125, 35);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(166, 465);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(125, 35);
            this.buttonLimpar.TabIndex = 5;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(71, 51);
            this.buttonVoltar.Margin = new System.Windows.Forms.Padding(5);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(125, 35);
            this.buttonVoltar.TabIndex = 6;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(236, 175);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(164, 26);
            this.textBoxNome.TabIndex = 7;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(236, 232);
            this.textBoxPreco.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(164, 26);
            this.textBoxPreco.TabIndex = 8;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(236, 288);
            this.textBoxCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(164, 26);
            this.textBoxCategoria.TabIndex = 9;
            // 
            // comboBoxPerecivel
            // 
            this.comboBoxPerecivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPerecivel.FormattingEnabled = true;
            this.comboBoxPerecivel.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.comboBoxPerecivel.Location = new System.Drawing.Point(236, 361);
            this.comboBoxPerecivel.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxPerecivel.Name = "comboBoxPerecivel";
            this.comboBoxPerecivel.Size = new System.Drawing.Size(69, 28);
            this.comboBoxPerecivel.TabIndex = 10;
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.Location = new System.Drawing.Point(32, 96);
            this.labelRegistro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(506, 58);
            this.labelRegistro.TabIndex = 12;
            this.labelRegistro.Text = "Cadastro de Produto";
            this.labelRegistro.Click += new System.EventHandler(this.labelRegistro_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 693);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.comboBoxPerecivel);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelPerecivel);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CadastroProduto";
            this.Text = "Cadastro de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelPerecivel;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxPerecivel;
        private System.Windows.Forms.Label labelRegistro;
    }
}