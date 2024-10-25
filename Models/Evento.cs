using System;

namespace SistemaReservas.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
        public int Disponibilidade { get; set; }
    }
}
