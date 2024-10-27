using revo_ticket.Models;

namespace revo_ticket.Decorators
{
    // Classe abstrata base para os decoradores de Reserva
    public abstract class ReservaDecorator : Reserva
    {
        protected Reserva _reserva;

        protected ReservaDecorator(Reserva reserva)
        {
            _reserva = reserva;
        }

        public override decimal CalcularTotal()
        {
            return _reserva.CalcularTotal();
        }

        public override void ConfirmarReserva()
        {
            _reserva.ConfirmarReserva();
        }
    }
}
