using MediatR;
using Services.Order.Core.Application.Dtos.AddressDtos;

namespace Services.Order.Core.Application.Features.CQRS.Queries
{
	public class GetAddressQueryRequest : IRequest<ResultAddressDto>
	{
		public GetAddressQueryRequest(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}
