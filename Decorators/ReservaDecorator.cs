namespace SistemaReservas.Decorators
{
    public abstract class ReservaDecorator : Reserva
    {
        protected Reserva _reserva;

        public ReservaDecorator(Reserva reserva)
        {
            _reserva = reserva;
        }

        public override double CalcularTotal()
        {
            return _reserva.CalcularTotal();
        }

        public override void ConfirmarReserva()
        {
            _reserva.ConfirmarReserva();
        }
    }
}
