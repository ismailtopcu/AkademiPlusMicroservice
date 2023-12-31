﻿using AutoMapper;
using MediatR;
using Services.Order.Core.Application.Dtos.OrderDetailDtos;
using Services.Order.Core.Application.Features.CQRS.Queries;
using Services.Order.Core.Application.Interfaces;
using Services.Order.Core.Domain.Entities;

namespace Services.Order.Core.Application.Features.CQRS.Handlers
{
	public class GetAllOrderDetailQueryHandler : IRequestHandler<GetAllOrderDetailQueryRequest, List<ResultOrderDetailDto>>
	{
		private readonly IRepository<OrderDetail> _repository;
		private readonly IMapper _mapper;

		public GetAllOrderDetailQueryHandler(IRepository<OrderDetail> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<List<ResultOrderDetailDto>> Handle(GetAllOrderDetailQueryRequest request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return _mapper.Map<List<ResultOrderDetailDto>>(values);
		}
	}

}
