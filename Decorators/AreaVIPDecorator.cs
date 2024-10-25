namespace SistemaReservas.Decorators
{
    public class AreaVIPDecorator : ReservaDecorator
    {
        private const double TaxaVIP = 0.40;

        public AreaVIPDecorator(Reserva reserva) : base(reserva) { }

        public override double CalcularTotal()
        {
            double valorBase = base.CalcularTotal();
            return valorBase + (valorBase * TaxaVIP);
        }

        public override void ConfirmarReserva()
        {
            base.ConfirmarReserva();
            Console.WriteLine("Serviço adicional: Área VIP adicionada.");
        }
    }
}
