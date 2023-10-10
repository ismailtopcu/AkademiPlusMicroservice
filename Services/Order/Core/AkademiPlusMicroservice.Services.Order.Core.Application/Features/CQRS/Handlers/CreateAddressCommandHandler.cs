using AutoMapper;
using MediatR;
using Services.Order.Core.Application.Dtos.AddressDtos;
using Services.Order.Core.Application.Features.CQRS.Commands;
using Services.Order.Core.Application.Interfaces;
using Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Order.Core.Application.Features.CQRS.Handlers
{
	public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest, CreateAddressDto>
	{
		private readonly IRepository<Address> _repository;
		private readonly IMapper _mapper;

		public CreateAddressCommandHandler(IRepository<Address> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<CreateAddressDto> Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
		{
			var values = new Address
			{
				City = request.City,
				Detail = request.Detail,
				District = request.District,
				UserId = request.UserId,
			};
			await _repository.CreateAsync(values);
			var result = _mapper.Map<CreateAddressDto>(values);
			return result;
		}
	}

}
