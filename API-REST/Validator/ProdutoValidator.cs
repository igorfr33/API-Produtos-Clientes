using API_REST.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Validator
{
    public class ProdutoValidator : AbstractValidator<ProdutoModel>
    {
        public ProdutoValidator()
        {
            RuleFor(produto => produto.id).NotEmpty();
            RuleFor(produto => produto.categoria).NotEmpty();
            RuleFor(produto => produto.Nome).NotEmpty();
            RuleFor(produto => produto.Valor).NotEmpty();
        }
    }
}
