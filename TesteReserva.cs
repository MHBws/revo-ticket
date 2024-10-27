using System;
using revo_ticket.Models;
using revo_ticket.Interfaces;
using revo_ticket.Services;
using revo_ticket.Decorators;
using revo_ticket.Facade;
using revo_ticket.Builder;

namespace revo_ticket
{
    class TesteReserva
    {
        public void ExecutarTesteReserva()
        {
            // Criando um evento de exemplo
            Evento evento = new Evento
            {
                Id = 1,
                Nome = "Concerto de Rock",
                Data = DateTime.Now.AddDays(10),
                Local = "Arena de Shows",
                Disponibilidade = 100
            };

            // Criando um usuário
            Usuario usuario = new Usuario
            {
                Nome = "João Silva",
                CPF = "12345678900",
                Email = "joao.silva@email.com"
            };

            // Criando um assento
            Assento assento1 = new Assento { Numero = 1, Tipo = "VIP" };
            Assento assento2 = new Assento { Numero = 2, Tipo = "Comum" };

            // Definindo o pagamento (via cartão de crédito)
            IPagamento pagamento = new CartaoCredito
            {
                NomeCompleto = "João Silva",
                Numero = "1234-5678-9012-3456",
                CpfTitular = "12345678900",
                CVV = "123",
                Validade = DateTime.Now.AddYears(1)
            };

            // Usando o Builder para criar a reserva
            ReservaBuilder builder = new ReservaBuilder();
            Reserva reserva = builder?
                .IniciarReserva(evento, usuario)?
                .AdicionarAssento(assento1)?
                .AdicionarAssento(assento2)?
                .DefinirPagamento(pagamento)?
                .Construir();

            // Adicionando serviços extras usando Decorators
            reserva = new EstacionamentoDecorator(reserva);
            reserva = new AreaVIPDecorator(reserva);

            // Usando a Facade para confirmar a reserva
            ReservaFacade reservaFacade = new ReservaFacade();
            reservaFacade?.ConfirmarReserva(reserva);

            // Exibindo o total da reserva
            Console.WriteLine($"Total da reserva: {reserva?.CalcularTotal():C2}");
        }
    }
}
