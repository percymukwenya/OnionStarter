using Application.Contracts.Persistence;
using Application.DTOs.Product;
using Application.Features.Product.Requests.Queries;
using AutoMapper;
using MediatR;

namespace Application.Features.Product.Handlers.Queries
{
    public class GetProductDetailRequestHandler : IRequestHandler<GetProductDetailRequest, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductDetailRequestHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(GetProductDetailRequest request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.Get(request.Id);

            return _mapper.Map<ProductDto>(product);
        }
    }
}
