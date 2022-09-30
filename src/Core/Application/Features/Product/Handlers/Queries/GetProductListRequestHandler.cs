using Application.Contracts.Persistence;
using Application.DTOs.Product;
using Application.Features.Product.Requests.Queries;
using AutoMapper;
using MediatR;

namespace Application.Features.Product.Handlers.Queries
{
    public class GetProductListRequestHandler : IRequestHandler<GetProductListRequest, IReadOnlyList<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductListRequestHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<ProductDto>> Handle(GetProductListRequest request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAll();

            return _mapper.Map<IReadOnlyList<ProductDto>>(products);
        }
    }
}
