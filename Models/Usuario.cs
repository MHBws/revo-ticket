using System;
using System.Text.RegularExpressions;

namespace revo_ticket.Models
{
    public class Usuario
    {
        public required string Nome { get; set; }
        public required string Email { get; set; }
        private string _cpf;

        public string CPF
        {
            get { return _cpf; }
            set
            {
                if (ValidarCPF(value))
                {
                    _cpf = value;
                }
                else
                {
                    throw new ArgumentException("CPF inválido");
                }
            }
        }

        private bool ValidarCPF(string cpf)
        {
            // Verificação simples de 11 dígitos
            return Regex.IsMatch(cpf, @"^\d{11}$");
        }
    }
}
