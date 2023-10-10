﻿using AkademiPlusMicroservice.Bussiness.Abstract;
using AkademiPlusMicroservice.DataAccessLayer.Abstract;
using AkademiPlusMicroservice.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Bussiness.Concrete
{
	public class CargoStateManager : ICargoStateService
	{
		private readonly ICargoStateDal _cargoStateDal;

		public CargoStateManager(ICargoStateDal cargoStateDal)
		{
			_cargoStateDal = cargoStateDal;
		}

		public async Task TCreateAsync(CargoState entity)
		{
			await _cargoStateDal.CreateAsync(entity);
		}

		public async Task TDeleteAsync(CargoState entity)
		{
			await _cargoStateDal.DeleteAsync(entity);
		}

		public async Task<List<CargoState>> TGetAllAsync()
		{
			return await _cargoStateDal.GetAllAsync();
		}

		public async Task<CargoState> TGetAsync(int id)
		{
			return await _cargoStateDal.GetAsync(id);
		}

		public async Task TUpdateAsync(CargoState entity)
		{
			await _cargoStateDal.UpdateAsync(entity);
		}
	}
}
