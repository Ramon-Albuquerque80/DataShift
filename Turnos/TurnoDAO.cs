using System;
using Npgsql;
using System.Collections.Generic;

namespace DataShift.Turnos
{
    public class TurnoDAO
    {
        private string stringConexao = "Server=localhost;Port=5432;Database=DataShift;User Id=postgres;Password=12345678;";

        public List<Turno> ListarTodos()
        {
            List<Turno> lista = new List<Turno>();
            using (NpgsqlConnection conexao = new NpgsqlConnection(stringConexao))
            {
                conexao.Open();
                string query = "SELECT id_turno, periodo, inicio, fim FROM turno ORDER BY periodo";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                using (NpgsqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        Turno t = new Turno();
                        t.Id = leitor.GetInt32(0);
                        t.Periodo = leitor.GetString(1);
                        t.Inicio = leitor.GetTimeSpan(2);
                        t.Fim = leitor.GetTimeSpan(3);
                        lista.Add(t);
                    }
                }
            }
            return lista;
        }

        public void CadastrarTurno(Turno t)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(stringConexao))
            {
                conexao.Open();
                string query = "INSERT INTO turno (periodo, inicio, fim) VALUES (@periodo, @inicio, @fim)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@periodo", t.Periodo);
                    cmd.Parameters.AddWithValue("@inicio", t.Inicio);
                    cmd.Parameters.AddWithValue("@fim", t.Fim);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}