using System.Collections.Generic;

namespace SistemaReservas.Models
{
    public class Reserva
    {
        public Evento Evento { get; set; }
        public Usuario Usuario { get; set; }
        public IPagamento Pagamento { get; set; }
        public List<Assento> Assentos { get; set; }
        public List<ServicoAdicional> Servicos { get; set; }

        public double CalcularTotal()
        {
            double total = 0;

            // Somar o valor dos serviços adicionais
            foreach (var servico in Servicos)
            {
                total += servico.Custo;
            }

            return total;
        }

        public void ConfirmarReserva()
        {
            // Lógica para processar o pagamento
            double total = CalcularTotal();
            Pagamento.ProcessarPagamento(total);

            // Enviar confirmação de reserva
            Console.WriteLine("Reserva confirmada para o evento " + Evento.Nome);
        }
    }
}
