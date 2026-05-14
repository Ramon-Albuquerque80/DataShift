namespace DataShift.Menu_Principal
{
    partial class MainMenu
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
            this.panelMenuEsquerdo = new System.Windows.Forms.Panel();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.textBoxProcurar = new System.Windows.Forms.TextBox();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.buttonProducao = new System.Windows.Forms.Button();
            this.GridDados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.panelMenuEsquerdo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuEsquerdo
            // 
            this.panelMenuEsquerdo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenuEsquerdo.Controls.Add(this.BtnRelatorio);
            this.panelMenuEsquerdo.Controls.Add(this.BtnProdutos);
            this.panelMenuEsquerdo.Controls.Add(this.buttonAdicionar);
            this.panelMenuEsquerdo.Controls.Add(this.comboTurnos);
            this.panelMenuEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.panelMenuEsquerdo.Name = "panelMenuEsquerdo";
            this.panelMenuEsquerdo.Size = new System.Drawing.Size(200, 450);
            this.panelMenuEsquerdo.TabIndex = 0;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPerfil.Location = new System.Drawing.Point(0, 680);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(248, 49);
            this.btnPerfil.TabIndex = 5;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 252);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(248, 49);
            this.btnRelatorios.TabIndex = 4;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistros.Location = new System.Drawing.Point(0, 172);
            this.btnRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(248, 49);
            this.btnRegistros.TabIndex = 3;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnProdutos.Location = new System.Drawing.Point(0, 92);
            this.BtnProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(248, 49);
            this.BtnProdutos.TabIndex = 2;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTitleBar.Controls.Add(this.textBoxProcurar);
            this.panelTitleBar.Controls.Add(this.buttonProcurar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(214, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(600, 44);
            this.panelTitleBar.TabIndex = 1;
            // 
            // textBoxProcurar
            // 
            this.textBoxProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcurar.Location = new System.Drawing.Point(20, 12);
            this.textBoxProcurar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProcurar.Name = "textBoxProcurar";
            this.textBoxProcurar.Size = new System.Drawing.Size(973, 22);
            this.textBoxProcurar.TabIndex = 4;
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcurar.Location = new System.Drawing.Point(1020, 8);
            this.buttonProcurar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(100, 32);
            this.buttonProcurar.TabIndex = 3;
            this.buttonProcurar.Text = "Pesquisar";
            this.buttonProcurar.UseVisualStyleBackColor = true;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelDesktop.Controls.Add(this.buttonProducao);
            this.panelDesktop.Controls.Add(this.GridDados);
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 44);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(600, 406);
            this.panelDesktop.TabIndex = 2;
            // 
            // buttonProducao
            // 
            this.buttonProducao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducao.Location = new System.Drawing.Point(900, 624);
            this.buttonProducao.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProducao.Name = "buttonProducao";
            this.buttonProducao.Size = new System.Drawing.Size(232, 58);
            this.buttonProducao.TabIndex = 5;
            this.buttonProducao.Text = "Registrar Produção";
            this.buttonProducao.UseVisualStyleBackColor = true;
            this.buttonProducao.Click += new System.EventHandler(this.buttonProducao_Click);
            // 
            // GridDados
            // 
            this.GridDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDados.Location = new System.Drawing.Point(0, 46);
            this.GridDados.Margin = new System.Windows.Forms.Padding(4);
            this.GridDados.Name = "GridDados";
            this.GridDados.Size = new System.Drawing.Size(600, 376);
            this.GridDados.TabIndex = 4;
            this.GridDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDados_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buttonNovo);
            this.panel1.Controls.Add(this.buttonExcluir);
            this.panel1.Controls.Add(this.buttonEditar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 44);
            this.panel1.TabIndex = 3;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNovo.Location = new System.Drawing.Point(772, 8);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(160, 28);
            this.buttonNovo.TabIndex = 0;
            this.buttonNovo.Text = "Adicionar Produto";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluir.Location = new System.Drawing.Point(1040, 8);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 28);
            this.buttonExcluir.TabIndex = 1;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.Location = new System.Drawing.Point(936, 8);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 28);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRelatorio.Location = new System.Drawing.Point(0, 110);
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Size = new System.Drawing.Size(200, 40);
            this.BtnRelatorio.TabIndex = 3;
            this.BtnRelatorio.Text = "Relatorios";
            this.BtnRelatorio.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 744);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenuEsquerdo);
            this.Name = "MainMenu";
            this.Text = "Data Shift";
            this.panelMenuEsquerdo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuEsquerdo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.TextBox textBoxProcurar;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridDados;
        private System.Windows.Forms.Button buttonProducao;
        private System.Windows.Forms.Button BtnRelatorio;
    }
}