using System;
using System.Windows.Forms;

namespace DataShift.Producao
{
    public partial class CadastroProducao : Form
    {
        private int _produtoId;
        private string _nomeProduto;

        public CadastroProducao(int produtoId, string nomeProduto)
        {
            InitializeComponent();
            _produtoId = produtoId;
            _nomeProduto = nomeProduto;

            textBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy");

            this.Text = $"Registrar Produção - {_nomeProduto}";
            textBoxProdutoSelecionado.Text = _nomeProduto;

            textBoxQuantidade.KeyPress += ApenasNumeros_KeyPress;

            textBoxInicio.MaxLength = 5;
            textBoxInicio.KeyPress += ApenasHorario_KeyPress;
            textBoxInicio.TextChanged += AutoFormataHora_TextChanged;

            textBoxTermino.MaxLength = 5;
            textBoxTermino.KeyPress += ApenasHorario_KeyPress;
            textBoxTermino.TextChanged += AutoFormataHora_TextChanged;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBoxInicio.Text = "";
            textBoxTermino.Text = "";
            textBoxQuantidade.Text = "";
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
            
                if (string.IsNullOrWhiteSpace(textBoxQuantidade.Text) ||
                    string.IsNullOrWhiteSpace(textBoxInicio.Text) ||
                    string.IsNullOrWhiteSpace(textBoxTermino.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    return;
                }

                
                Producao p = new Producao();
                p.ProdutoId = _produtoId;
                p.TurnoId = Sessao.TurnoId;

                if (!int.TryParse(textBoxQuantidade.Text, out int qtd))
                {
                    MessageBox.Show("Quantidade deve ser um número inteiro!");
                    return;
                }
                p.Quantidade = qtd;

                
                try
                {
                    p.HoraInicio = TimeSpan.Parse(textBoxInicio.Text);
                    p.HoraFim = TimeSpan.Parse(textBoxTermino.Text);
                    p.DataRegistro = DateTime.Parse(textBoxData.Text);

                  
                    p.TempoTotal = p.HoraFim - p.HoraInicio;

                    if (p.TempoTotal < TimeSpan.Zero)
                    {
                        p.TempoTotal = p.TempoTotal.Add(TimeSpan.FromDays(1));
                    }
                }
                catch
                {
                    MessageBox.Show("Formato de data ou hora inválido! Use dd/mm/aaaa e hh:mm");
                    return;
                }

                ProducaoDAO dao = new ProducaoDAO();
                dao.RegistrarProducao(p);

                MessageBox.Show("Produção registrada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void ApenasNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ApenasHorario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }

        private void AutoFormataHora_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length == 2 && !txt.Text.Contains(":"))
            {
                txt.Text += ":";
                txt.SelectionStart = txt.Text.Length;
            }
        }
    }
}