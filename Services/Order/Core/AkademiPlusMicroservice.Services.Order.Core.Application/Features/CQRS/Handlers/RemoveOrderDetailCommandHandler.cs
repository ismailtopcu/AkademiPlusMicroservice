﻿using MediatR;
using Services.Order.Core.Application.Features.CQRS.Commands;
using Services.Order.Core.Application.Interfaces;
using Services.Order.Core.Domain.Entities;

namespace Services.Order.Core.Application.Features.CQRS.Handlers
{
	public class RemoveOrderDetailCommandHandler : IRequestHandler<RemoveOrderDetailCommandRequest>
	{
		private readonly IRepository<OrderDetail> _repository;

		public RemoveOrderDetailCommandHandler(IRepository<OrderDetail> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveOrderDetailCommandRequest request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);
			_repository.DeleteAsync(value);
		}
	}

}
