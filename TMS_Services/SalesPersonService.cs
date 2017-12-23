using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DataAccess;
using TMS_Objects;

namespace TMS_Services
{
	public class SalesPersonService
	{
		static ISalesPerson slPer = new SalesPersonDAO();
		public static List<SalesPerson> GetAll() => slPer.GetAll();
		public static SalesPerson FindOne(string id) => slPer.FindOne(id);
		public static void Save()
		{
			slPer.Save();
			slPer = new SalesPersonDAO();
		}
	}
}
