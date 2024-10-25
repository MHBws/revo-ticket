namespace SistemaReservas.Models
{
    public class Paypal : IPagamento
    {
        public string Email { get; set; }

        public void ProcessarPagamento(double valor)
        {
            // Implementação da lógica de pagamento com PayPal
            Console.WriteLine($"Pagamento de R${valor} processado via PayPal.");
        }
    }
}
