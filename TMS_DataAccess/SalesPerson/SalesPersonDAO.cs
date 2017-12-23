using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Objects;

namespace TMS_DataAccess
{
	public class SalesPersonDAO : ISalesPerson
	{
		TMSEntities db = new TMSEntities();
		public SalesPerson FindOne(string id)
		{
			return db.SalesPersons.SingleOrDefault(sl => sl.SlsPerID.ToLower() == id.ToLower());
		}

		public List<SalesPerson> GetAll()
		{
			return db.SalesPersons.ToList();
		}

		public void Save()
		{
			db.SaveChanges();
		}
	}
}
