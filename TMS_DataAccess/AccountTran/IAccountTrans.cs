using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Objects;

namespace TMS_DataAccess
{
	public interface IAccountTrans
	{
		List<AccountTran> GetAll();
		List<TranType> GetAllType();
		List<ShowAccountTrans_Result> ShowOnGrid(int id);
		List<ShowAccountTrans_Result> FindByDateAndType(int id,DateTime fDate, DateTime tDate, string type);
	}
}
