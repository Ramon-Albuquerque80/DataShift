using System;

namespace DataShift.Producao
{
    public class Producao
    {
        public int ID_Registro { get; set; }
        public DateTime DataRegistro { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public TimeSpan TempoTotal { get; set; }
        public int QtdProduzido { get; set; }

        public int IdProdutoRegistro { get; set; }
        public int IdUsuarioRegistro { get; set; }
        public int IdTurnoRegistro { get; set; }
    }
}