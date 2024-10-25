using System;
using System.Text.RegularExpressions;

namespace SistemaReservas.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
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
