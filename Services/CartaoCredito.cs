using System;

namespace SistemaReservas.Models
{
    public class CartaoCredito : IPagamento
    {
        public string NomeCompleto { get; set; }
        public string Numero { get; set; }
        public string CpfTitular { get; set; }
        public DateTime Validade { get; set; }
        public string CVV { get; set; }

        public void ProcessarPagamento(double valor)
        {
            // Implementação da lógica de pagamento com cartão de crédito
            Console.WriteLine($"Pagamento de R${valor} processado com Cartão de Crédito.");
        }
    }
}
