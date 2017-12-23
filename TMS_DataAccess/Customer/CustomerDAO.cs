using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Objects;

namespace TMS_DataAccess
{
	public class CustomerDAO : ICustomerDAO
	{
		TMSEntities db = new TMSEntities();

		public bool Delete(Customer cust)
		{
			throw new NotImplementedException();
		}

		public List<Customer> FindByID(string id)
		{
			return db.Customers.Where(c => c.CustID.Contains(id)).ToList();
		}

		public Customer FindOne(string id)
		{
			return db.Customers.SingleOrDefault(c => c.CustID.ToLower() == id.ToLower());
		}

		public List<Customer> GetAll()
		{
			return db.Customers.ToList();
		}

		public void Save()
		{
			db.SaveChanges();
		}

		public bool Update(Customer cust)
		{
			try
			{
				db.Customers.Attach(cust);
			}
			catch
			{
				return false;
			}
			return true;
		}
	}
}
