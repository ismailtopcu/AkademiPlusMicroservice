using AutoMapper;
using MediatR;
using Services.Order.Core.Application.Dtos.OrderingDtos;
using Services.Order.Core.Application.Features.CQRS.Commands;
using Services.Order.Core.Application.Interfaces;
using Services.Order.Core.Domain.Entities;

namespace Services.Order.Core.Application.Features.CQRS.Handlers
{
	public class UpdateOrderingCommandHandler : IRequestHandler<UpdateOrderingCommandRequest, UpdateOrderingDto>
	{
		private readonly IRepository<Ordering> _repository;
		private readonly IMapper _mapper;

		public UpdateOrderingCommandHandler(IRepository<Ordering> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<UpdateOrderingDto> Handle(UpdateOrderingCommandRequest request, CancellationToken cancellationToken)
		{
			var values = new Ordering
			{
				OrderDate = request.OrderDate,
				OrderingId = request.OrderingId,
				TotalPrice = request.TotalPrice,
				UserId = request.UserId
			};
			await _repository.UpdateAsync(values);
			return _mapper.Map<UpdateOrderingDto>(values);
		}
	}

}
