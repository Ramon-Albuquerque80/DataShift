using System;
using MySql.Data.MySqlClient;

namespace DataShift.Producao
{
    public class ProducaoDAO
    {
        // Use a mesma string de conexão que você já definiu nos outros DAOs
        private string stringConexao = "server=localhost;database=DataShiftDB;uid=root;pwd=senha1234321";

        public void RegistrarProducao(Producao p)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringConexao))
            {
                try
                {
                    conexao.Open();
                    string query = "INSERT INTO producao (PRODUTO_ID, TURNO_ID, QUANTIDADE, INICIO, FIM, TEMPO_TOTAL, DATA_REGISTRO) " +
                                   "VALUES (@prodId, @turnoId, @qtd, @inicio, @fim, @tempototal, @data)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@prodId", p.ProdutoId);
                        cmd.Parameters.AddWithValue("@turnoId", p.TurnoId);
                        cmd.Parameters.AddWithValue("@qtd", p.Quantidade);
                        cmd.Parameters.AddWithValue("@inicio", p.HoraInicio);
                        cmd.Parameters.AddWithValue("@fim", p.HoraFim);
                        cmd.Parameters.AddWithValue("@tempoTotal", p.TempoTotal);
                        // Usamos p.DataRegistro que foi definida na tela
                        cmd.Parameters.AddWithValue("@data", p.DataRegistro);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao salvar produção: " + ex.Message);
                }
            }
        }
    }
}