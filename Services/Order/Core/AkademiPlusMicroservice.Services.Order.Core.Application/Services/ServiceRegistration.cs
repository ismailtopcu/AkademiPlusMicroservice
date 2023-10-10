﻿using AutoMapper;
using Services.Order.Core.Application.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MediatR;

namespace Services.Order.Core.Application.Services
{
	public static class ServiceRegistration
	{
		public static void AddApplicationServices(this IServiceCollection services)
		{
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            services.AddAutoMapper(opt =>
			{
				opt.AddProfiles(new List<Profile>
				{
					new AddressProfile(),
					new OrderingProfile(),
					new OrderDetailProfile()
				});
			});
		}
	}
}
