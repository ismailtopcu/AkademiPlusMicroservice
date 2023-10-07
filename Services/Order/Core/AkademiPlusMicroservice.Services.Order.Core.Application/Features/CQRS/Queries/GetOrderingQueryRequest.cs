using MediatR;
using Services.Order.Core.Application.Dtos.OrderingDtos;

namespace Services.Order.Core.Application.Features.CQRS.Queries
{
	public class GetOrderingQueryRequest : IRequest<ResultOrderingDto>
	{
		public GetOrderingQueryRequest(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
