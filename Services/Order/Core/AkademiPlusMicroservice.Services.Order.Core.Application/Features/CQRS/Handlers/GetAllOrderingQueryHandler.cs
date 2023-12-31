﻿using AutoMapper;
using MediatR;
using Services.Order.Core.Application.Dtos.OrderingDtos;
using Services.Order.Core.Application.Features.CQRS.Queries;
using Services.Order.Core.Application.Interfaces;
using Services.Order.Core.Domain.Entities;

namespace Services.Order.Core.Application.Features.CQRS.Handlers
{
	public class GetAllOrderingQueryHandler : IRequestHandler<GetAllOrderingQueryRequest, List<ResultOrderingDto>>
	{
		private readonly IRepository<Ordering> _repository;
		private readonly IMapper _mapper;

		public GetAllOrderingQueryHandler(IRepository<Ordering> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<List<ResultOrderingDto>> Handle(GetAllOrderingQueryRequest request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return _mapper.Map<List<ResultOrderingDto>>(values);
		}
	}

}
