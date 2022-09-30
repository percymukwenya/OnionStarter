using Application.DTOs.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Requests.Queries
{
    public class GetProductListRequest : IRequest<IReadOnlyList<ProductDto>>
    {
    }
}
