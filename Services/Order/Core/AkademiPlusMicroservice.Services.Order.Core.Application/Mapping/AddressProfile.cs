using AutoMapper;
using Services.Order.Core.Application.Dtos.AddressDtos;
using Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Order.Core.Application.Mapping
{
	public class AddressProfile : Profile
	{
		public AddressProfile()
		{
			CreateMap<ResultAddressDto, Address>().ReverseMap();
			CreateMap<CreateAddressDto, Address>().ReverseMap();
			CreateMap<UpdateAddressDto, Address>().ReverseMap();
		}
	}

}
