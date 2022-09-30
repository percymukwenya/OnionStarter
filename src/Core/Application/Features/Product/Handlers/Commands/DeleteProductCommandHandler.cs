using Application.Contracts.Persistence;
using Application.Exceptions;
using Application.Features.Product.Requests.Commands;
using AutoMapper;
using MediatR;

namespace Application.Features.Product.Handlers.Commands
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.ProductRepository.Get(request.Id);

            if (product == null)
                throw new NotFoundException(nameof(Domain.Entities.Product), request.Id);

            await _unitOfWork.ProductRepository.Delete(product);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
