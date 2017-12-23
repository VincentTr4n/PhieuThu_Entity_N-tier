using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DataAccess;
using TMS_Objects;

namespace TMS_Services
{
	public class AccountTranService
	{
		static IAccountTrans accTran = new AccountTransDAO();
		public static List<AccountTran> GetAll() => accTran.GetAll();
		public static List<TranType> GetAllType() => accTran.GetAllType();
		public static List<ShowAccountTrans_Result> ShowOnGrid(int id) => accTran.ShowOnGrid(id);
		public static List<ShowAccountTrans_Result> FindByDateAndType(int id, DateTime fDate, DateTime tDate, string type) => accTran.FindByDateAndType(id, fDate, tDate, type);
	}
}
