using MediatR;
using Services.Order.Core.Application.Features.CQRS.Commands;
using Services.Order.Core.Application.Interfaces;
using Services.Order.Core.Domain.Entities;

namespace Services.Order.Core.Application.Features.CQRS.Handlers
{
	public class RemoveAddressCommandHandler : IRequestHandler<RemoveAddressCommandRequest>
	{
		private readonly IRepository<Address> _repository;

		public RemoveAddressCommandHandler(IRepository<Address> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveAddressCommandRequest request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);
			_repository.DeleteAsync(value);
		}
	}

}
