using System;
using revo_ticket.Interfaces;

namespace revo_ticket.Services
{
    public class CartaoCredito : IPagamento
    {
        public required string NomeCompleto { get; set; }
        public required string Numero { get; set; }
        public required string CpfTitular { get; set; }
        public DateTime Validade { get; set; }
        public required string CVV { get; set; }

        public void RealizarPagamento(decimal valor)
        {
            // Implementação da lógica de pagamento com cartão de crédito
            Console.WriteLine($"Pagamento de R${valor} processado com Cartão de Crédito.");
        }
    }
}
