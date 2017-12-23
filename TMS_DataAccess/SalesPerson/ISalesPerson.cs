using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Objects;

namespace TMS_DataAccess
{
	public interface ISalesPerson
	{
		List<SalesPerson> GetAll();
		SalesPerson FindOne(string id);
		void Save();
	}
}
