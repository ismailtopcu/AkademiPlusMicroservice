﻿using MediatR;
using Services.Order.Core.Application.Dtos.OrderDetailDtos;

namespace Services.Order.Core.Application.Features.CQRS.Commands
{
	public class UpdateOrderDetailCommandRequest : IRequest<UpdateOrderDetailDto>
	{
		public int OrderDetailId { get; set; }
		public string ProductId { get; set; }
		public string ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public int ProductAmount { get; set; }
		public int OrderingId { get; set; }
	}
}
