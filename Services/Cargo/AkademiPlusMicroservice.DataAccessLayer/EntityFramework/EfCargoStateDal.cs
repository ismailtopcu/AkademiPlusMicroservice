using AkademiPlusMicroservice.DataAccessLayer.Abstract;
using AkademiPlusMicroservice.DataAccessLayer.Context;
using AkademiPlusMicroservice.DataAccessLayer.Repository;
using AkademiPlusMicroservice.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.DataAccessLayer.EntityFramework
{
	public class EfCargoStateDal : GenericRepository<CargoState>, ICargoStateDal
	{
		private readonly CargoContext _context;
		public EfCargoStateDal(CargoContext cargoContext) : base(cargoContext)
		{
			_context = cargoContext;
		}


	}
}
