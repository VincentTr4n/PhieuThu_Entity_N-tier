using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DataAccess;
using TMS_Objects;

namespace TMS_Services
{
	public class CustomerService
	{
		static ICustomerDAO cus = new CustomerDAO();
		public static List<Customer> GetAll() => cus.GetAll();
		public static List<Customer> FindByID(string id) => cus.FindByID(id);
		public static Customer FindOne(string id) => cus.FindOne(id);
		public static bool Update(Customer cust) => cus.Update(cust);
		public static void Save()
		{
			cus.Save();
			cus = new CustomerDAO();
		}
	}
}
