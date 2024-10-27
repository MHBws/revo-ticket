using revo_ticket.Models;
using revo_ticket.Interfaces;
using revo_ticket.Services;

namespace revo_ticket.Decorators
{
    public class EstacionamentoDecorator : ReservaDecorator
    {
        private const double CustoEstacionamento = 20.00;

        public EstacionamentoDecorator(Reserva reserva) : base(reserva) { }
 
        public override decimal CalcularTotal()
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
