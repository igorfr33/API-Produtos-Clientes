using API_REST.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Validator
{
    public class ClientesValidator : AbstractValidator<Cliente>
    {
        public ClientesValidator()
    {
            RuleFor(cliente => cliente.CPF).NotEmpty();
            RuleFor(cliente => cliente.Nome).NotEmpty();
    }
}
    }
