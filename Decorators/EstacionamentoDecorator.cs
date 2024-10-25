namespace SistemaReservas.Decorators
{
    public class EstacionamentoDecorator : ReservaDecorator
    {
        private const double CustoEstacionamento = 20.00;

        public EstacionamentoDecorator(Reserva reserva) : base(reserva) { }

        public override double CalcularTotal()
        {
            return base.CalcularTotal() + CustoEstacionamento;
        }

        public override void ConfirmarReserva()
        {
            base.ConfirmarReserva();
            Console.WriteLine("Serviço adicional: Estacionamento adicionado.");
        }
    }
}
