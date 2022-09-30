using Application.Contracts.Persistence;
using Application.DTOs.Product.Validators;
using Application.Exceptions;
using Application.Features.Product.Requests.Commands;
using AutoMapper;
using MediatR;

namespace Application.Features.Product.Handlers.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateProductDtoValidator();
            var validationResult = await validator.ValidateAsync(request.ProductDto);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            var product = await _unitOfWork.ProductRepository.Get(request.ProductDto.Id);

            if (product == null)
                throw new NotFoundException(nameof(product), request.ProductDto.Id);

            _mapper.Map(request.ProductDto, product);

            await _unitOfWork.ProductRepository.Update(product);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
