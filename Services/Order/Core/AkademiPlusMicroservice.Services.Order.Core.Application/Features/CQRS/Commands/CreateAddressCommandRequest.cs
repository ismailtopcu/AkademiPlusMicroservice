﻿using MediatR;
using Services.Order.Core.Application.Dtos.AddressDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Order.Core.Application.Features.CQRS.Commands
{
	public class CreateAddressCommandRequest : IRequest<CreateAddressDto>
	{
		public string UserId { get; set; }
		public string District { get; set; }
		public string City { get; set; }
		public string Detail { get; set; }
	}
}
