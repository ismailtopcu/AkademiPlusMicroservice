using MediatR;
using Services.Order.Core.Application.Dtos.OrderingDtos;

namespace Services.Order.Core.Application.Features.CQRS.Queries
{
	public class GetAllOrderingQueryRequest : IRequest<List<ResultOrderingDto>>
	{
	}
}
