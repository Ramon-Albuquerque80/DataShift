using System;

namespace DataShift.Login_Cadastro
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; } 
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int IdTurnoUsuario { get; set; }

        public Usuario() { }

        public Usuario(string Nome, string Email, string Senha, string Endereco, string Cidade, string IdTurnoUsuario)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Senha = Senha;
            this.Endereco = Endereco;
            this.Cidade = Cidade;
            this.Estado = Estado;
            this.IdTurnoUsuario = int.Parse(IdTurnoUsuario);
        }
    }
}