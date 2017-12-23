using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DataAccess;
using TMS_Objects;

namespace TMS_Services
{
	public class ReceiptVoucherService
	{
		static IReceiptVoucherDAO recDao = new ReceiptVoucherDAO();
		public static List<ReceiptVoucher> GetAll() => recDao.GetAll();     // Lấy ra danh sách các phiếu thu
		public static ReceiptVoucher FindOne(int id) => recDao.FindOne(id);     // Láy ra 1 phiếu thu theo mã
		public static List<ShowReceipt_SlsPer_Result> FindBySaleser(string id) => recDao.FindBySaleser(id);     // Tìm phiếu thu theo mã người nộp
		public static List<ShowReceipt_Time_Result> FindByTime(DateTime date) => recDao.FindByTime(date);       // Tìm phiếu thu theo thời gian
		public static List<ShowReceipt> ShowOnGrid() => recDao.ShowOnGrid();        // Hiển thị thông tin phiếu thu trên gridview
		public static List<RVoucherDet> GetRVoucherDet(int id) => recDao.GetRVoucherDet(id);        // Lấy ra chi tiết phiếu thu ứng với 1 mã phiếu thu
		public static bool Update(ReceiptVoucher receipt) => recDao.Update(receipt);        // Attach 1 đối tượng phiếu thu để update
		public static void Save()       // Lưu tất cả thay đổi
		{
			recDao.Save();
			Reset();
		}
		public static void Reset()		// Reset liên kết
		{
			recDao = new ReceiptVoucherDAO();
		}
	}
}
