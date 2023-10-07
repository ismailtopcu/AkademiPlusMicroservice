using AutoMapper;
using Services.Order.Core.Application.Dtos.OrderDetailDtos;
using Services.Order.Core.Domain.Entities;

namespace Services.Order.Core.Application.Mapping
{
	public class OrderDetailProfile : Profile
	{
		public OrderDetailProfile()
		{
			CreateMap<ResultOrderDetailDto, OrderDetail>().ReverseMap();
			CreateMap<CreateOrderDetailDto, OrderDetail>().ReverseMap();
			CreateMap<UpdateOrderDetailDto, OrderDetail>().ReverseMap();
		}
	}

}
