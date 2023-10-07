using MediatR;
using Services.Order.Core.Application.Dtos.OrderDetailDtos;

namespace Services.Order.Core.Application.Features.CQRS.Queries
{
	public class GetAllOrderDetailQueryRequest : IRequest<List<ResultOrderDetailDto>>
	{
	}
}
