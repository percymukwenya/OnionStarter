using Application.DTOs.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Requests.Queries
{
    public class GetProductDetailRequest : IRequest<ProductDto>
    {
        public int Id { get; set; }
    }
}
