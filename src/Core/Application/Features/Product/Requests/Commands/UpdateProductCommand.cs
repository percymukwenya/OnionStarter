using Application.DTOs.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Requests.Commands
{
    public class UpdateProductCommand : IRequest<Unit>
    {
        public ProductDto ProductDto { get; set; }
    }
}
