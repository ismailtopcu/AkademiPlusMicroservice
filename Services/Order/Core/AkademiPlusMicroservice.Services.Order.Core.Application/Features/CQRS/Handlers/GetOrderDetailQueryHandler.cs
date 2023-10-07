using AutoMapper;
using MediatR;
using Services.Order.Core.Application.Dtos.OrderDetailDtos;
using Services.Order.Core.Application.Features.CQRS.Queries;
using Services.Order.Core.Application.Interfaces;
using Services.Order.Core.Domain.Entities;

namespace Services.Order.Core.Application.Features.CQRS.Handlers
{
	public class GetOrderDetailQueryHandler : IRequestHandler<GetOrderDetailQueryRequest, ResultOrderDetailDto>
	{
		private readonly IRepository<OrderDetail> _repository;
		private readonly IMapper _mapper;

		public GetOrderDetailQueryHandler(IRepository<OrderDetail> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<ResultOrderDetailDto> Handle(GetOrderDetailQueryRequest request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);
			return _mapper.Map<ResultOrderDetailDto>(value);
		}
	}

}
