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
                MessageBox.Show("Selecione um turno!");
                return;
            }

            try
            {
                ProdutoDAO dao = new ProdutoDAO();

                var lista = dao.ListarParaGrid();

                GridDados.DataSource = lista;

                if (GridDados.Columns["ID"] != null) GridDados.Columns["ID"].Visible = false;
                if (GridDados.Columns["Turno_ID"] != null) GridDados.Columns["Turno_ID"].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
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

        private int IdSelecionada = 0;

        private void GridDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
               IdSelecionada = Convert.ToInt32(GridDados.Rows[e.RowIndex].Cells["ID"].Value);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (IdSelecionada == 0)
            {
                MessageBox.Show("Selecione um item na tabela primeiro.");
                return;
            }

            if (contextoAtual == "Produtos")
            {
                if (MessageBox.Show("Deseja excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ProdutoDAO dao = new ProdutoDAO();
                    dao.ExcluirProduto(IdSelecionada);

                    BtnProdutos_Click(null, null);
                    IdSelecionada = 0;
                }
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (IdSelecionada == 0)
            {
                MessageBox.Show("Selecione um produto na tabela para editar.");
                return;
            }

            if (contextoAtual == "Produtos")
            {
                
                if (GridDados.CurrentRow != null)
                {
                    
                    DataShift.Produtos.Produtos produtoEdit = new DataShift.Produtos.Produtos();

                    
                    produtoEdit.ID_PRODUTO = Convert.ToInt32(GridDados.CurrentRow.Cells["ID"].Value);
                    produtoEdit.NOME = GridDados.CurrentRow.Cells["NOME"].Value.ToString();
                    produtoEdit.PRECO = Convert.ToDecimal(GridDados.CurrentRow.Cells["PRECO"].Value);

                    produtoEdit.CATEGORIA = GridDados.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                    produtoEdit.PESO = Convert.ToDecimal(GridDados.CurrentRow.Cells["PESO"].Value);

                   
                    CadastroProduto tela = new CadastroProduto();

                   
                    tela.CarregarDadosParaEdicao(produtoEdit);

                    tela.ShowDialog();

                   
                    BtnProdutos_Click(null, null);
                    IdSelecionada = 0;
                }
            }
        }

        private void buttonProducao_Click(object sender, EventArgs e)
        {
           
            if (IdSelecionada == 0 || GridDados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um produto na tabela primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CadastroProducao TelaRegistro = new CadastroProducao(IdSelecionada, GridDados.CurrentRow.Cells["NOME"].Value.ToString());
            TelaRegistro.ShowDialog();
        }
    }
}