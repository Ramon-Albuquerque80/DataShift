using System;
using System.Windows.Forms;
using DataShift.Turnos;
using DataShift;

namespace DataShift.Produtos
{
    public partial class CadastroProduto : Form
    {
        private int idEdicao = 0;

        public CadastroProduto()
        {
            InitializeComponent();
        }

        public void CarregarDadosParaEdicao(Produtos p)
        {
            idEdicao = p.ID_PRODUTO;

            textBoxNome.Text = p.NOME;
            textBoxPreco.Text = p.PRECO.ToString();
            textBoxCategoria.Text = p.CATEGORIA;

            this.Text = "Editando Produto";
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPerecivel.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, informe se é perecível.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxNome.Text) || string.IsNullOrWhiteSpace(textBoxPreco.Text))
                {
                    MessageBox.Show("Preencha o Nome e o Preço!");
                    return;
                }

                Produtos p = new Produtos();

                p.NOME = textBoxNome.Text;
                p.CATEGORIA = textBoxCategoria.Text;

                if (decimal.TryParse(textBoxPreco.Text, out decimal preco))
                {
                    p.PRECO = preco;
                }
                else
                {
                    MessageBox.Show("Preço inválido! Digite apenas números.");
                    return;
                }

                ProdutoDAO dao = new ProdutoDAO();

                if (idEdicao == 0)
                {
                    dao.Inserir(p);
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
                else
                {
                    p.ID_PRODUTO = idEdicao; 
                    dao.AtualizarProduto(p);
                    MessageBox.Show("Produto atualizado com sucesso!");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            textBoxPreco.Text = "";
            textBoxCategoria.Text = "";
            comboBoxPerecivel.SelectedIndex = -1;
            idEdicao = 0;
            textBoxNome.Focus();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}