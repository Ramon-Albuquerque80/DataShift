namespace DataShift.Login_Cadastro
{
    partial class TelaCadastro
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
            this.LinkLogin = new System.Windows.Forms.LinkLabel();
            this.LabelPergunta = new System.Windows.Forms.Label();
            this.TxtBoxSenha = new System.Windows.Forms.TextBox();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.BotaoCadastrar = new System.Windows.Forms.Button();
            this.LabelCadastro = new System.Windows.Forms.Label();
            this.TxtBoxConfirma = new System.Windows.Forms.TextBox();
            this.LabelConfirma = new System.Windows.Forms.Label();
            this.TxtBoxNome = new System.Windows.Forms.TextBox();
            this.LabelNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LinkLogin
            // 
            this.LinkLogin.AutoSize = true;
            this.LinkLogin.Location = new System.Drawing.Point(325, 580);
            this.LinkLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LinkLogin.Name = "LinkLogin";
            this.LinkLogin.Size = new System.Drawing.Size(50, 20);
            this.LinkLogin.TabIndex = 15;
            this.LinkLogin.TabStop = true;
            this.LinkLogin.Text = "Login";
            this.LinkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLogin_LinkClicked_1);
            // 
            // LabelPergunta
            // 
            this.LabelPergunta.AutoSize = true;
            this.LabelPergunta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPergunta.Location = new System.Drawing.Point(222, 584);
            this.LabelPergunta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelPergunta.Name = "LabelPergunta";
            this.LabelPergunta.Size = new System.Drawing.Size(105, 16);
            this.LabelPergunta.TabIndex = 14;
            this.LabelPergunta.Text = "Já tem conta?";
            this.LabelPergunta.Click += new System.EventHandler(this.LabelPergunta_Click);
            // 
            // TxtBoxSenha
            // 
            this.TxtBoxSenha.Location = new System.Drawing.Point(209, 345);
            this.TxtBoxSenha.Margin = new System.Windows.Forms.Padding(5);
            this.TxtBoxSenha.Name = "TxtBoxSenha";
            this.TxtBoxSenha.Size = new System.Drawing.Size(296, 26);
            this.TxtBoxSenha.TabIndex = 13;
            this.TxtBoxSenha.Enter += new System.EventHandler(this.TxtBoxSenha_Enter);
            this.TxtBoxSenha.Leave += new System.EventHandler(this.TxtBoxSenha_Leave);
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Location = new System.Drawing.Point(209, 286);
            this.TxtBoxEmail.Margin = new System.Windows.Forms.Padding(5);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(296, 26);
            this.TxtBoxEmail.TabIndex = 12;
            this.TxtBoxEmail.Enter += new System.EventHandler(this.TxtBoxEmail_Enter);
            this.TxtBoxEmail.Leave += new System.EventHandler(this.TxtBoxEmail_Leave);
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSenha.Location = new System.Drawing.Point(129, 345);
            this.LabelSenha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(76, 25);
            this.LabelSenha.TabIndex = 11;
            this.LabelSenha.Text = "Senha:";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(139, 287);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(66, 25);
            this.LabelEmail.TabIndex = 10;
            this.LabelEmail.Text = "Email:";
            // 
            // BotaoCadastrar
            // 
            this.BotaoCadastrar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCadastrar.Location = new System.Drawing.Point(198, 471);
            this.BotaoCadastrar.Margin = new System.Windows.Forms.Padding(5);
            this.BotaoCadastrar.Name = "BotaoCadastrar";
            this.BotaoCadastrar.Size = new System.Drawing.Size(199, 55);
            this.BotaoCadastrar.TabIndex = 8;
            this.BotaoCadastrar.Text = "Cadastrar";
            this.BotaoCadastrar.UseVisualStyleBackColor = true;
            this.BotaoCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // LabelCadastro
            // 
            this.LabelCadastro.AutoSize = true;
            this.LabelCadastro.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCadastro.Location = new System.Drawing.Point(20, 84);
            this.LabelCadastro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCadastro.Name = "LabelCadastro";
            this.LabelCadastro.Size = new System.Drawing.Size(544, 59);
            this.LabelCadastro.TabIndex = 17;
            this.LabelCadastro.Text = "Cadastro de Usuários";
            // 
            // TxtBoxConfirma
            // 
            this.TxtBoxConfirma.Location = new System.Drawing.Point(209, 407);
            this.TxtBoxConfirma.Margin = new System.Windows.Forms.Padding(5);
            this.TxtBoxConfirma.Name = "TxtBoxConfirma";
            this.TxtBoxConfirma.Size = new System.Drawing.Size(296, 26);
            this.TxtBoxConfirma.TabIndex = 24;
            this.TxtBoxConfirma.Enter += new System.EventHandler(this.TxtBoxConfirma_Enter);
            this.TxtBoxConfirma.Leave += new System.EventHandler(this.TxtBoxConfirma_Leave);
            // 
            // LabelConfirma
            // 
            this.LabelConfirma.AutoSize = true;
            this.LabelConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConfirma.Location = new System.Drawing.Point(43, 406);
            this.LabelConfirma.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelConfirma.Name = "LabelConfirma";
            this.LabelConfirma.Size = new System.Drawing.Size(166, 25);
            this.LabelConfirma.TabIndex = 23;
            this.LabelConfirma.Text = "Confirmar Senha:";
            // 
            // TxtBoxNome
            // 
            this.TxtBoxNome.Location = new System.Drawing.Point(209, 230);
            this.TxtBoxNome.Margin = new System.Windows.Forms.Padding(5);
            this.TxtBoxNome.Name = "TxtBoxNome";
            this.TxtBoxNome.Size = new System.Drawing.Size(296, 26);
            this.TxtBoxNome.TabIndex = 27;
            this.TxtBoxNome.Enter += new System.EventHandler(this.TxtBoxNome_Enter);
            this.TxtBoxNome.Leave += new System.EventHandler(this.TxtBoxNome_Leave);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNome.Location = new System.Drawing.Point(46, 231);
            this.LabelNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(159, 25);
            this.LabelNome.TabIndex = 25;
            this.LabelNome.Text = "Nome Completo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 180);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 26);
            this.textBox1.TabIndex = 29;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(135, 181);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(70, 25);
            this.lblTurno.TabIndex = 28;
            this.lblTurno.Text = "Turno:";
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 693);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.TxtBoxNome);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.TxtBoxConfirma);
            this.Controls.Add(this.LabelConfirma);
            this.Controls.Add(this.LabelCadastro);
            this.Controls.Add(this.LinkLogin);
            this.Controls.Add(this.LabelPergunta);
            this.Controls.Add(this.TxtBoxSenha);
            this.Controls.Add(this.TxtBoxEmail);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.BotaoCadastrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkLogin;
        private System.Windows.Forms.Label LabelPergunta;
        private System.Windows.Forms.TextBox TxtBoxSenha;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Button BotaoCadastrar;
        private System.Windows.Forms.Label LabelCadastro;
        private System.Windows.Forms.TextBox TxtBoxConfirma;
        private System.Windows.Forms.Label LabelConfirma;
        private System.Windows.Forms.TextBox TxtBoxNome;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTurno;
    }
}