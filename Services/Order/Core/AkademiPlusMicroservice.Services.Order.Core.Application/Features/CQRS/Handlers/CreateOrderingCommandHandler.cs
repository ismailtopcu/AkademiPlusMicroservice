using AutoMapper;
using MediatR;
using Services.Order.Core.Application.Dtos.OrderingDtos;
using Services.Order.Core.Application.Features.CQRS.Commands;
using Services.Order.Core.Application.Interfaces;
using Services.Order.Core.Domain.Entities;

namespace Services.Order.Core.Application.Features.CQRS.Handlers
{
	public class CreateOrderingCommandHandler : IRequestHandler<CreateOrderingCommandRequest, CreateOrderingDto>
	{
		private readonly IRepository<Ordering> _repository;
		private readonly IMapper _mapper;

		public CreateOrderingCommandHandler(IRepository<Ordering> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<CreateOrderingDto> Handle(CreateOrderingCommandRequest request, CancellationToken cancellationToken)
		{
			var values = new Ordering
			{
				OrderDate = request.OrderDate,
				TotalPrice = request.TotalPrice,
				UserId = request.UserId,
			};
			var result = await _repository.CreateAsync(values);
			return _mapper.Map<CreateOrderingDto>(result);
		}
	}

}
