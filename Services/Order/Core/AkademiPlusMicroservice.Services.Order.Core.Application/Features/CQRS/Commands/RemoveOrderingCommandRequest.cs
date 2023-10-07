using MediatR;

namespace Services.Order.Core.Application.Features.CQRS.Commands
{
	public class RemoveOrderingCommandRequest : IRequest
	{
		public RemoveOrderingCommandRequest(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
