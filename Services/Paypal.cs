using System;
using revo_ticket.Interfaces;

namespace revo_ticket.Services
{
    public class Paypal : IPagamento
    {
        public required string Email { get; set; }

        public void RealizarPagamento(decimal valor)
        {
            // Implementação da lógica de pagamento com PayPal
            Console.WriteLine($"Pagamento de R${valor} processado via PayPal.");
        }
    }
}
