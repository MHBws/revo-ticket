namespace SistemaReservas.Models
{
    public interface IPagamento
    {
        void ProcessarPagamento(double valor);
    }
}
