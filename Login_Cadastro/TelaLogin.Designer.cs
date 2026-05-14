namespace DataShift.Login_Cadastro
{
    partial class TelaLogin
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
            this.BotaoConfirmar = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.TxtBoxSenha = new System.Windows.Forms.TextBox();
            this.LabelPergunta = new System.Windows.Forms.Label();
            this.LinkCadastro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BotaoConfirmar
            // 
            this.BotaoConfirmar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoConfirmar.Location = new System.Drawing.Point(198, 472);
            this.BotaoConfirmar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotaoConfirmar.Name = "BotaoConfirmar";
            this.BotaoConfirmar.Size = new System.Drawing.Size(199, 55);
            this.BotaoConfirmar.TabIndex = 0;
            this.BotaoConfirmar.Text = "Confirmar";
            this.BotaoConfirmar.UseVisualStyleBackColor = true;
            this.BotaoConfirmar.Click += new System.EventHandler(this.BotaoConfirmar_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.Location = new System.Drawing.Point(222, 84);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(162, 59);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Login";
            this.LabelLogin.Click += new System.EventHandler(this.LabelLogin_Click);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(112, 273);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(60, 25);
            this.LabelEmail.TabIndex = 2;
            this.LabelEmail.Text = "Email";
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSenha.Location = new System.Drawing.Point(102, 332);
            this.LabelSenha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(70, 25);
            this.LabelSenha.TabIndex = 3;
            this.LabelSenha.Text = "Senha";
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Location = new System.Drawing.Point(175, 273);
            this.TxtBoxEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(295, 26);
            this.TxtBoxEmail.TabIndex = 4;
            this.TxtBoxEmail.Enter += new System.EventHandler(this.TxtBoxEmail_Enter);
            this.TxtBoxEmail.Leave += new System.EventHandler(this.TxtBoxEmail_Leave);
            // 
            // TxtBoxSenha
            // 
            this.TxtBoxSenha.Location = new System.Drawing.Point(175, 332);
            this.TxtBoxSenha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtBoxSenha.Name = "TxtBoxSenha";
            this.TxtBoxSenha.Size = new System.Drawing.Size(295, 26);
            this.TxtBoxSenha.TabIndex = 5;
            this.TxtBoxSenha.Enter += new System.EventHandler(this.TxtBoxSenha_Enter);
            this.TxtBoxSenha.Leave += new System.EventHandler(this.TxtBoxSenha_Leave);
            // 
            // LabelPergunta
            // 
            this.LabelPergunta.AutoSize = true;
            this.LabelPergunta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPergunta.Location = new System.Drawing.Point(160, 584);
            this.LabelPergunta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelPergunta.Name = "LabelPergunta";
            this.LabelPergunta.Size = new System.Drawing.Size(158, 16);
            this.LabelPergunta.TabIndex = 6;
            this.LabelPergunta.Text = "Ainda não tem conta?";
            // 
            // LinkCadastro
            // 
            this.LinkCadastro.AutoSize = true;
            this.LinkCadastro.Location = new System.Drawing.Point(317, 581);
            this.LinkCadastro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LinkCadastro.Name = "LinkCadastro";
            this.LinkCadastro.Size = new System.Drawing.Size(101, 20);
            this.LinkCadastro.TabIndex = 7;
            this.LinkCadastro.TabStop = true;
            this.LinkCadastro.Text = "Cadastre-se";
            this.LinkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCadastro_LinkClicked);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 693);
            this.Controls.Add(this.LinkCadastro);
            this.Controls.Add(this.LabelPergunta);
            this.Controls.Add(this.TxtBoxSenha);
            this.Controls.Add(this.TxtBoxEmail);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.BotaoConfirmar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TelaLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaLogin";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoConfirmar;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.TextBox TxtBoxSenha;
        private System.Windows.Forms.Label LabelPergunta;
        private System.Windows.Forms.LinkLabel LinkCadastro;
    }
}