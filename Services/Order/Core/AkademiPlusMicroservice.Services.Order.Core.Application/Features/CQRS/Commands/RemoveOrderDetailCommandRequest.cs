using MediatR;

namespace Services.Order.Core.Application.Features.CQRS.Commands
{
	public class RemoveOrderDetailCommandRequest : IRequest
	{
		public RemoveOrderDetailCommandRequest(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
