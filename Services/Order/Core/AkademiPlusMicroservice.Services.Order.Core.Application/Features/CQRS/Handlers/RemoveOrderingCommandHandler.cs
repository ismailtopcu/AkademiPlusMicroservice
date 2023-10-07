using MediatR;
using Services.Order.Core.Application.Features.CQRS.Commands;
using Services.Order.Core.Application.Interfaces;
using Services.Order.Core.Domain.Entities;

namespace Services.Order.Core.Application.Features.CQRS.Handlers
{
	public class RemoveOrderingCommandHandler : IRequestHandler<RemoveOrderingCommandRequest>
	{
		private readonly IRepository<Ordering> _repository;

		public RemoveOrderingCommandHandler(IRepository<Ordering> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveOrderingCommandRequest request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);
			_repository.DeleteAsync(value);
		}
	}

}
