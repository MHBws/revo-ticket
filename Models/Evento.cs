using System;

namespace revo_ticket.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public DateTime Data { get; set; }
        public required string Local { get; set; }
        public int Disponibilidade { get; set; }
    }
}
