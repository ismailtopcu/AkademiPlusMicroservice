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
	public class EfCargoDetailDal : GenericRepository<CargoDetail>, ICargoDetailDal
	{
		private readonly CargoContext _context;
		public EfCargoDetailDal(CargoContext cargoContext) : base(cargoContext)
		{
			_context = cargoContext;
		}

		public int TotalCargoCount()
		{
			return _context.CargoDetails.Count();
		}
	}
}
