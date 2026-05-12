using System;
using Npgsql;
using System.Data;

namespace DataShift.Produtos
{
    public class ProdutoDAO
    {
        private string stringConexao = "Server=localhost;Port=5432;Database=DataShift;User Id=postgres;Password=12345678;";

        public DataTable ListarParaGrid()
        {
            DataTable tabela = new DataTable();
            using (NpgsqlConnection conexao = new NpgsqlConnection(stringConexao))
            {
                conexao.Open();
     
                string query = "SELECT id_produto AS ID, nome AS NOME, categoria AS CATEGORIA, preco_uni AS PRECO FROM produto";

                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conexao))
                {
                    adapter.Fill(tabela);
                }
            }
            return tabela;
        }

        public void Inserir(Produtos p)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(stringConexao))
            {
                conexao.Open();
                string query = @"INSERT INTO produto (nome, categoria, peso, preco_uni, id_usuario_produto) 
                                VALUES (@nome, @cat, @peso, @preco, @idUser)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", p.NOME);
                    cmd.Parameters.AddWithValue("@cat", p.CATEGORIA);
                    cmd.Parameters.AddWithValue("@peso", p.PESO);
                    cmd.Parameters.AddWithValue("@preco", p.PRECO);
                    cmd.Parameters.AddWithValue("@idUser", Sessao.UsuarioId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarProduto(Produtos p)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(stringConexao))
            {
                conexao.Open();
                string query = @"UPDATE produto 
                                 SET nome = @nome, categoria = @cat, peso = @peso, preco_uni = @preco 
                                 WHERE id_produto = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", p.NOME);
                    cmd.Parameters.AddWithValue("@cat", p.CATEGORIA);
                    cmd.Parameters.AddWithValue("@peso", p.PESO);
                    cmd.Parameters.AddWithValue("@preco", p.PRECO);

                    cmd.Parameters.AddWithValue("@id", p.ID_PRODUTO);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ExcluirProduto(int idProduto)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(stringConexao))
            {
                conexao.Open();
                string query = "DELETE FROM produto WHERE id_produto = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", idProduto);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}