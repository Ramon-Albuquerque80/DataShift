using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataShift.Turnos;
using DataShift.Produtos;
using DataShift.Producao;

namespace DataShift.Menu_Principal
{
    public partial class MainMenu : Form
    {
        private string contextoAtual = "";
        private int IdSelecionada = 0;

        // MOCK: Dados temporários para teste offline
        private List<object> produtosMock = new List<object>
        {
            new { ID = 1, NOME = "Esfiha de Carne", PRECO = 5.50, CATEGORIA = "Salgados", PESO = 0.100 },
            new { ID = 2, NOME = "Bolo de Chocolate", PRECO = 35.00, CATEGORIA = "Doces", PESO = 1.200 },
            new { ID = 3, NOME = "Cookie", PRECO = 4.00, CATEGORIA = "Biscoitos", PESO = 0.050 }
        };

        public MainMenu()
        {
            InitializeComponent();
            ConfigurarJanela();
        }

        public void ConfigurarJanela()
        {
            this.Text = "DataShift - Menu Principal";
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            buttonProducao.Visible = false;
        }

        // --- NAVEGAÇÃO DO MENU LATERAL ---

        public void BtnProdutos_Click(object sender, EventArgs e)
        {
            contextoAtual = "Produtos";

            // Limpa o Grid e reseta seleção
            GridDados.DataSource = null;
            IdSelecionada = 0;

            // Configura o botão
            buttonProducao.Text = "Registrar Produção";
            buttonProducao.Visible = true;

            // Carrega os dados mockados
            GridDados.DataSource = produtosMock;

            if (GridDados.Columns["ID"] != null) GridDados.Columns["ID"].Visible = false;

            // Mostra botões de gerenciamento
            buttonNovo.Visible = true;
            buttonEditar.Visible = true;
            buttonExcluir.Visible = true;
        }

        public void btnRegistros_Click(object sender, EventArgs e)
        {
            contextoAtual = "Registros";

            // Limpa tudo do contexto anterior
            GridDados.DataSource = null;
            IdSelecionada = 0;

            // Muda o botão
            buttonProducao.Text = "Gerar Relatório";
            buttonProducao.Visible = true;

            // Esconde botões de produto
            buttonNovo.Visible = false;
            buttonEditar.Visible = false;
            buttonExcluir.Visible = false;
        }

        public void btnRelatorios_Click(object sender, EventArgs e)
        {
            contextoAtual = "Relatorios";

            // Limpa tudo
            GridDados.DataSource = null;
            IdSelecionada = 0;

            // Muda o botão
            buttonProducao.Text = "Baixar Arquivo";
            buttonProducao.Visible = true;

            buttonNovo.Visible = false;
            buttonEditar.Visible = false;
            buttonExcluir.Visible = false;
        }

        public void btnPerfil_Click(object sender, EventArgs e)
        {
            DataShift.Perfil.Tela_Perfil tela = new DataShift.Perfil.Tela_Perfil();
            tela.ShowDialog();
        }

        // --- AÇÃO DO BOTÃO DINÂMICO ---

        private void buttonProducao_Click(object sender, EventArgs e)
        {
            switch (contextoAtual)
            {
                case "Produtos":
                    if (IdSelecionada == 0 || GridDados.CurrentRow == null)
                    {
                        MessageBox.Show("Selecione um produto na tabela!");
                        return;
                    }
                    CadastroProducao telaProd = new CadastroProducao(IdSelecionada, GridDados.CurrentRow.Cells["NOME"].Value.ToString());
                    telaProd.ShowDialog();
                    break;
                case "Registros":
                    Form fCal = new Form { Text = "Período", Size = new Size(250, 250), StartPosition = FormStartPosition.CenterParent };
                    MonthCalendar cal = new MonthCalendar { Dock = DockStyle.Fill };
                    fCal.Controls.Add(cal);
                    fCal.ShowDialog();
                    break;
                case "Relatorios":
                    MessageBox.Show("Iniciando download...");
                    break;
            }
        }

        private void GridDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdSelecionada = Convert.ToInt32(GridDados.Rows[e.RowIndex].Cells["ID"].Value);
            }
        }

        // Métodos de botões de topo (Editar/Excluir/Novo)
        private void buttonEditar_Click(object sender, EventArgs e) { MessageBox.Show("Editar: " + IdSelecionada); }
        private void buttonExcluir_Click(object sender, EventArgs e) { MessageBox.Show("Excluir: " + IdSelecionada); }
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            if (contextoAtual == "Produtos")
            {
                new CadastroProduto().ShowDialog();
                BtnProdutos_Click(null, null);
            }
        }

        private void MainMenu_Load(object sender, EventArgs e) { }
        private void GridDados_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}