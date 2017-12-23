using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Objects;

namespace TMS_DataAccess
{
	public interface ICustomerDAO
	{
		List<Customer> GetAll();
		List<Customer> FindByID(string id);
		Customer FindOne(string id);
		bool Update(Customer cust);
		void Save();
		bool Delete(Customer cust);
	}
}
