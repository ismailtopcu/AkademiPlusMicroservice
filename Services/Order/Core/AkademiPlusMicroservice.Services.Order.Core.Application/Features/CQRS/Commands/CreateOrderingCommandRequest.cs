using MediatR;
using Services.Order.Core.Application.Dtos.OrderingDtos;

namespace Services.Order.Core.Application.Features.CQRS.Commands
{
	public class CreateOrderingCommandRequest : IRequest<CreateOrderingDto>
	{
		public string UserId { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime OrderDate { get; set; }
	}
}
