using AutoMapper;
using Services.Order.Core.Application.Dtos.OrderingDtos;
using Services.Order.Core.Domain.Entities;

namespace Services.Order.Core.Application.Mapping
{
	public class OrderingProfile : Profile
	{
		public OrderingProfile()
		{
			CreateMap<ResultOrderingDto, Ordering>().ReverseMap();
			CreateMap<CreateOrderingDto, Ordering>().ReverseMap();
			CreateMap<UpdateOrderingDto, Ordering>().ReverseMap();
		}
	}

}
