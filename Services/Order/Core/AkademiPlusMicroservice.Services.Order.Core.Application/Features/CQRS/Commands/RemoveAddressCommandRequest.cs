using MediatR;

namespace Services.Order.Core.Application.Features.CQRS.Commands
{
	public class RemoveAddressCommandRequest : IRequest
	{
		public RemoveAddressCommandRequest(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
