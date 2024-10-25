using SistemaReservas.Builder;
using SistemaReservas.Decorators;
using SistemaReservas.Facade;
using SistemaReservas.Models;
using SistemaReservas.Services;
using System;
using System.Collections.Generic;

namespace SistemaReservas
{
    class TesteReserva
    {
        static void Main(string[] args)
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
                Cpf = 123456789,
                Email = "joao.silva@email.com"
            };

            // Criando um assento
            Assento assento1 = new Assento { Numero = 1, Tipo = "VIP" };
            Assento assento2 = new Assento { Numero = 2, Tipo = "Comum" };

            // Definindo o pagamento (via cartão de crédito)
            IPagamento pagamento = new CartaoCredito
            {
                NomeTitular = "João Silva",
                Numero = "1234-5678-9012-3456",
                CpfTitular = 123456789,
                CVV = "123",
                Validade = DateTime.Now.AddYears(1)
            };

            // Usando o Builder para criar a reserva
            ReservaBuilder builder = new ReservaBuilder();
            Reserva reserva = builder
                .IniciarReserva(evento, usuario)
                .AdicionarAssento(assento1)
                .AdicionarAssento(assento2)
                .DefinirPagamento(pagamento)
                .Construir();

            // Adicionando serviços extras usando Decorators
            reserva = new EstacionamentoDecorator(reserva);
            reserva = new AreaVIPDecorator(reserva);

            // Usando a Facade para confirmar a reserva
            ReservaFacade reservaFacade = new ReservaFacade();
            reservaFacade.ConfirmarReserva(reserva);

            // Exibindo o total da reserva
            Console.WriteLine($"Total da reserva: {reserva.CalcularTotal():C2}");
        }
    }
}
