using DataShift.Login_Cadastro;
using Npgsql;
using System;
using System.Collections.Generic;

namespace DataShift.Usuarios
{
    public class UsuarioDAO
    {
        private string stringConexao = "Server=localhost;Port=5432;Database=DataShift;User Id=postgres;Password=12345678;";

        public void CadastrarUsuario(Usuario u)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(stringConexao))
            {
                conexao.Open();
                string query = @"INSERT INTO usuario (nome, email, senha, endereco, cidade, estado, id_turno_usuario) 
                                VALUES (@nome, @email, @senha, @end, @cid, @est, @idTurno)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", u.Nome);
                    cmd.Parameters.AddWithValue("@email", u.Email);
                    cmd.Parameters.AddWithValue("@senha", u.Senha);

                    cmd.Parameters.AddWithValue("@end", string.IsNullOrEmpty(u.Endereco) ? (object)DBNull.Value : u.Endereco);
                    cmd.Parameters.AddWithValue("@cid", string.IsNullOrEmpty(u.Cidade) ? (object)DBNull.Value : u.Cidade);
                    cmd.Parameters.AddWithValue("@est", string.IsNullOrEmpty(u.Estado) ? (object)DBNull.Value : u.Estado);

                    cmd.Parameters.AddWithValue("@idTurno", u.IdTurnoUsuario == 0 ? (object)DBNull.Value : u.IdTurnoUsuario);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool ValidarLogin(string email, string senha)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(stringConexao))
            {
                conexao.Open();
                string query = "SELECT id_usuario, id_turno_usuario FROM usuario WHERE email = @email AND senha = @senha";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    using (NpgsqlDataReader leitor = cmd.ExecuteReader())
                    {
                        if (leitor.Read())
                        {
                            Sessao.UsuarioId = leitor.GetInt32(0);
                            Sessao.TurnoId = leitor.GetInt32(1);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}