using MediatR;
using Services.Order.Core.Application.Dtos.AddressDtos;

namespace Services.Order.Core.Application.Features.CQRS.Commands
{
	public class UpdateAddressCommandRequest : IRequest<UpdateAddressDto>
	{
		public int AddressId { get; set; }
		public string UserId { get; set; }
		public string District { get; set; }
		public string City { get; set; }
		public string Detail { get; set; }
	}
}
