using MediatR;
using Services.Order.Core.Application.Dtos.OrderingDtos;

namespace Services.Order.Core.Application.Features.CQRS.Commands
{
	public class UpdateOrderingCommandRequest : IRequest<UpdateOrderingDto>
	{
		public int OrderingId { get; set; }
		public string UserId { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime OrderDate { get; set; }
	}
}
