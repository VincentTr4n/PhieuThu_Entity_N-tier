using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Objects;

namespace TMS_DataAccess
{
	public class ReceiptVoucherDAO : IReceiptVoucherDAO
	{
		TMSEntities db = new TMSEntities();             // Khai báo đối tượng kết nối với csdl trong entity framework

		//
		// Tìm phiếu thu theo mã người nộp
		public List<ShowReceipt_SlsPer_Result> FindBySaleser(string salerID)
		{
			return db.ShowReceipt_SlsPer(salerID).ToList();
		}

		//
		// Tìm phiếu thu theo thời gian
		public List<ShowReceipt_Time_Result> FindByTime(DateTime date)
		{
			return db.ShowReceipt_Time(date).ToList();
		}

		//
		// Láy ra 1 phiếu thu theo mã
		public ReceiptVoucher FindOne(int id)
		{
			return db.ReceiptVouchers.SingleOrDefault(r => r.VoucherID == id);
		}

		//
		// Lấy ra danh sách các phiếu thu
		public List<ReceiptVoucher> GetAll()
		{
			return db.ReceiptVouchers.ToList();
		}

		//
		// Hiển thị thông tin phiếu thu trên gridview
		public List<ShowReceipt> ShowOnGrid()
		{
			return db.ShowReceipts.ToList();
		}

		//
		// Lấy ra chi tiết phiếu thu ứng với 1 mã phiếu thu
		public List<RVoucherDet> GetRVoucherDet(int id)
		{
			return db.RVoucherDets.Where(r => r.VMainID == id).ToList();
		}

		//
		// Attach 1 đối tượng phiếu thu để update
		public bool Update(ReceiptVoucher receipt)
		{
			try
			{
				db.ReceiptVouchers.Attach(receipt);
			}
			catch
			{
				return false;
			}
			return true;
		}

		//
		// Lưu tất cả thay đổi
		public void Save()
		{
			db.SaveChanges();
		}
	}
}
