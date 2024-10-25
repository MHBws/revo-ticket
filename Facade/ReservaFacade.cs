namespace SistemaReservas.Facade
{
    public class ReservaFacade
    {
        public Reserva CriarReserva(Evento evento, Usuario usuario, List<Assento> assentos, IPagamento pagamento)
        {
            // Criação da reserva
            Reserva reserva = new Reserva
            {
                Evento = evento,
                Usuario = usuario,
                Assentos = assentos,
                Pagamento = pagamento,
                Servicos = new List<ServicoAdicional>()
            };

            return reserva;
        }

        public void AdicionarServico(Reserva reserva, ServicoAdicional servico)
        {
            reserva.Servicos.Add(servico);
        }

        public void ConfirmarReserva(Reserva reserva)
        {
            reserva.ConfirmarReserva();
        }
    }
}
