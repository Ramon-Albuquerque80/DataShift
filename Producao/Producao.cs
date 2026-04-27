using System;

namespace DataShift.Producao
{
    public class Producao
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int TurnoId { get; set; }
        public int Quantidade { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public DateTime DataRegistro { get; set; }
        public TimeSpan TempoTotal { get; set; }

        public Producao() { }
    }
}