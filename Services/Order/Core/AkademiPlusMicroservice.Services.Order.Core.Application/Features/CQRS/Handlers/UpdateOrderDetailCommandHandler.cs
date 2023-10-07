using AutoMapper;
using MediatR;
using Services.Order.Core.Application.Dtos.OrderDetailDtos;
using Services.Order.Core.Application.Features.CQRS.Commands;
using Services.Order.Core.Application.Interfaces;
using Services.Order.Core.Domain.Entities;

namespace Services.Order.Core.Application.Features.CQRS.Handlers
{
	public class UpdateOrderDetailCommandHandler : IRequestHandler<UpdateOrderDetailCommandRequest, UpdateOrderDetailDto>
	{
		private readonly IRepository<OrderDetail> _repository;
		private readonly IMapper _mapper;

		public UpdateOrderDetailCommandHandler(IRepository<OrderDetail> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<UpdateOrderDetailDto> Handle(UpdateOrderDetailCommandRequest request, CancellationToken cancellationToken)
		{
			var values = new OrderDetail
			{
				OrderDetailId = request.OrderDetailId,
				OrderingId = request.OrderingId,
				ProductAmount = request.ProductAmount,
				ProductId = request.ProductId,
				ProductName = request.ProductName,
				ProductPrice = request.ProductPrice,
			};
			await _repository.UpdateAsync(values);
			return _mapper.Map<UpdateOrderDetailDto>(values);
		}
	}

}
