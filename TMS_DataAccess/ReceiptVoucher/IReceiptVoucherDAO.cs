using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Objects;

namespace TMS_DataAccess
{
	public interface IReceiptVoucherDAO
	{
		List<ReceiptVoucher> GetAll();
		ReceiptVoucher FindOne(int id);
		List<ShowReceipt_SlsPer_Result> FindBySaleser(string salerID);
		List<ShowReceipt_Time_Result> FindByTime(DateTime date);
		List<ShowReceipt> ShowOnGrid();
		bool Update(ReceiptVoucher receipt);
		List<RVoucherDet> GetRVoucherDet(int id);
		void Save();
	}
}
