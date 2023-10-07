using AutoMapper;
using MediatR;
using Services.Order.Core.Application.Dtos.OrderDetailDtos;
using Services.Order.Core.Application.Features.CQRS.Commands;
using Services.Order.Core.Application.Interfaces;
using Services.Order.Core.Domain.Entities;

namespace Services.Order.Core.Application.Features.CQRS.Handlers
{
	public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommandRequest, CreateOrderDetailDto>
	{
		private readonly IRepository<OrderDetail> _repository;
		private readonly IMapper _mapper;

		public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<CreateOrderDetailDto> Handle(CreateOrderDetailCommandRequest request, CancellationToken cancellationToken)
		{
			var values = new OrderDetail
			{
				ProductAmount = request.ProductAmount,
				ProductId = request.ProductId,
				ProductName = request.ProductName,
				ProductPrice = request.ProductPrice,
				OrderingId = request.OrderingId,
			};
			var result = await _repository.CreateAsync(values);
			return _mapper.Map<CreateOrderDetailDto>(result);
		}
	}

}
