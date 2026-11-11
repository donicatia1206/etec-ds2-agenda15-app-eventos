namespace AppCadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; } = string.Empty;
        public string TipoEvento { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataFim { get; set; } = DateTime.Now.AddDays(1);
        public int NumeroParticipantes { get; set; }
        public decimal CustoPorPessoa { get; set; }

        public int DuracaoDias => (DataFim - DataInicio).Days > 0 ? (DataFim - DataInicio).Days : 1;
        public decimal CustoTotal => NumeroParticipantes * CustoPorPessoa * DuracaoDias;
    }
}
