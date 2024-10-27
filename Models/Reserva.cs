using System;
using System.Collections.Generic;
using revo_ticket.Interfaces;

namespace revo_ticket.Models
{
    public class Reserva
    {
        public required Evento Evento { get; set; }
        public required Usuario Usuario { get; set; }
        public required IPagamento Pagamento { get; set; }
        public required List<Assento> Assentos { get; set; }
        public required List<ServicoAdicional> Servicos { get; set; }

        public virtual decimal CalcularTotal()
        {
            decimal total = 0;

            // Somar o valor dos serviços adicionais
            foreach (var servico in Servicos)
            {
                total += (decimal)servico.Custo;
            }

            return total;
        }

        public virtual void ConfirmarReserva()
        {
            // Lógica para processar o pagamento
            decimal total = CalcularTotal();
            Pagamento.RealizarPagamento(total);

            // Enviar confirmação de reserva
            Console.WriteLine("Reserva confirmada para o evento " + Evento.Nome);
        }
    }
}
