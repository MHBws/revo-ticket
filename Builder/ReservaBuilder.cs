namespace SistemaReservas.Builder
{
    public class ReservaBuilder
    {
        private Reserva _reserva;

        public ReservaBuilder IniciarReserva(Evento evento, Usuario usuario)
        {
            _reserva = new Reserva
            {
                Evento = evento,
                Usuario = usuario,
                Assentos = new List<Assento>(),
                Servicos = new List<ServicoAdicional>()
            };
            return this;
        }

        public ReservaBuilder AdicionarAssento(Assento assento)
        {
            _reserva.Assentos.Add(assento);
            return this;
        }

        public ReservaBuilder AdicionarServico(ServicoAdicional servico)
        {
            _reserva.Servicos.Add(servico);
            return this;
        }

        public ReservaBuilder DefinirPagamento(IPagamento pagamento)
        {
            _reserva.Pagamento = pagamento;
            return this;
        }

        public Reserva Construir()
        {
            return _reserva;
        }
    }
}
