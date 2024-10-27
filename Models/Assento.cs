namespace revo_ticket.Models
{
    public class Assento
    {
        public int Numero { get; set; }
        public required string Tipo { get; set; }  // Ex: VIP, Padrão, etc.
    }
}
