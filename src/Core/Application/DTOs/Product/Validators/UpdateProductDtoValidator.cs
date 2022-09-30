using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Product.Validators
{
    public class UpdateProductDtoValidator : AbstractValidator<ProductDto>
    {
        public UpdateProductDtoValidator()
        {
            Include(new IProductDtoValidator());

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
