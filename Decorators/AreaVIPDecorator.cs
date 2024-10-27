using revo_ticket.Models;
using revo_ticket.Interfaces;
using revo_ticket.Services;
 
namespace revo_ticket.Decorators
{
    public class AreaVIPDecorator : ReservaDecorator
    {
        private const decimal TaxaVIP = 0.40m;

        public AreaVIPDecorator(Reserva reserva) : base(reserva) { }

        public override decimal CalcularTotal()
        {
            decimal valorBase = base.CalcularTotal();
            return valorBase + (valorBase * TaxaVIP);
        }

        public override void ConfirmarReserva()
        {
            base.ConfirmarReserva();
            Console.WriteLine("Serviço adicional: Área VIP adicionada.");
        }
    }
}
