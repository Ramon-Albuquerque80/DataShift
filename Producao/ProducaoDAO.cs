using Npgsql;
using System;

namespace DataShift.Producao
{

    public class ProducaoDAO
    {
 
        private string stringConexao = "Server=localhost;Port=5432;Database=DataShift;User Id=postgres;Password=12345678;";

        public void RegistrarProducao(Producao p)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(stringConexao))
            {
                conexao.Open();

                string query = @"INSERT INTO registro_producao 
                            (data_registro, hora_inicio, hora_fim, qtd_produzido, id_produto_registro, id_usuario_registro, id_turno_registro) 
                            VALUES (@data, @inicio, @fim, @qtd, @idProd, @idUser, @idTurno)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@data", p.DataRegistro);
                    cmd.Parameters.AddWithValue("@inicio", p.HoraInicio);
                    cmd.Parameters.AddWithValue("@fim", p.HoraFim);
                    cmd.Parameters.AddWithValue("@qtd", p.QtdProduzido);

                    // Inserindo as Chaves Estrangeiras
                    cmd.Parameters.AddWithValue("@idProd", p.IdProdutoRegistro);
                    cmd.Parameters.AddWithValue("@idUser", p.IdUsuarioRegistro);
                    cmd.Parameters.AddWithValue("@idTurno", p.IdTurnoRegistro);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}