using MediatR;
using Services.Order.Core.Application.Dtos.OrderDetailDtos;

namespace Services.Order.Core.Application.Features.CQRS.Queries
{
	public class GetOrderDetailQueryRequest : IRequest<ResultOrderDetailDto>
	{
		public GetOrderDetailQueryRequest(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
