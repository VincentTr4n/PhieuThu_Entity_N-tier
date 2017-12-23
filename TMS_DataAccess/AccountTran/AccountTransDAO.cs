using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Objects;

namespace TMS_DataAccess
{
	public class AccountTransDAO : IAccountTrans
	{
		TMSEntities db = new TMSEntities();
		public List<ShowAccountTrans_Result> FindByDateAndType(int id,DateTime fDate, DateTime tDate, string type)
		{
			return db.ShowAccountTrans(id).Where(t => t.RefDate >= fDate && t.RefDate <= tDate && t.TranType == type).ToList();
		}

		public List<AccountTran> GetAll()
		{
			return db.AccountTrans.ToList();
		}

		public List<TranType> GetAllType()
		{
			return db.TranTypes.ToList();
		}

		public List<ShowAccountTrans_Result> ShowOnGrid(int id)
		{
			return db.ShowAccountTrans(id).ToList();
		}
	}
}
