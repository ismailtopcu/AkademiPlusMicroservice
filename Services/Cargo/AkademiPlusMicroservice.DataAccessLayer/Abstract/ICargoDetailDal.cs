using AkademiPlusMicroservice.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.DataAccessLayer.Abstract
{
	public interface ICargoDetailDal:IGenericDal<CargoDetail>
	{
		int TotalCargoCount();
	}
}
