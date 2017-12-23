using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_Objects;
using TMS_Services;

namespace MyProject01
{
	public partial class frmDetailReceipt : Form
	{
		private int topBt;
		public frmDetailReceipt(ReceiptVoucher rVoucher)
		{
			InitializeComponent();
			topBt = btCustomers.Top;

			if (rVoucher != null)
			{
				// Ràng buộc với 1 phiếu thu được chuyền vào
				this.receiptVoucherBS.DataSource = rVoucher;

				// Load chi tiết phiếu thu
				this.rVoucherDetBS.DataSource = ReceiptVoucherService.GetRVoucherDet(rVoucher.VoucherID);
				ReceiptVoucherService.Update(this.receiptVoucherBS.Current as ReceiptVoucher);            // Attach phiếu thu hiện tại để update
				
				// Format text -> money
				txTotal.Text = String.Format("{0:#,##0}", getCurrent().TotalAmt);
			}
		}

		private void frmDetailReceipt_Load(object sender, EventArgs e)
		{
			setCombox();   // Combo box trạng thái

			FormClosed += (obj, ev) => { ReceiptVoucherService.Reset(); };		// Reset kết nối
		}

		// Set dữ liệu cho combo box trạng thái
		void setCombox()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("val", typeof(string));
			dt.Columns.Add("dis", typeof(string));
			dt.Rows.Add(new object[] { "0", "Chưa xác nhận" });
			dt.Rows.Add(new object[] { "1", "Đã xác nhận" });
			cbReleased.DataSource = dt;
		}

		private void cbEFL_CheckedChanged(object sender, EventArgs e)
		{
			if (cbEFL.Checked) btAccountTran.Enabled = true;
			else btAccountTran.Enabled = false;
		}
		
		
		// Lấy ra tên nhân viên
		private void txEmp_TextChanged(object sender, EventArgs e)
		{
			SalesPerson sl = SalesPersonService.FindOne(txEmp.Text);
			if (sl != null) txEmpName.Text = sl.SlsPerName;
		}
		
		// Sự kiện show and move nút mở bảng khách hàng
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0 && e.RowIndex!= -1)
			{
				btCustomers.Visible = true;
				var cellRectangle = dataGridView1.GetCellDisplayRectangle(0, e.RowIndex, true);
				btCustomers.Top = topBt + cellRectangle.Top - 21;
			}
			else
			{
				btCustomers.Visible = false;
			}
		}

		// Sự kiện mở danh mục khách hàng
		private void btCustomers_Click(object sender, EventArgs e)
		{
			frmCustomers frm = new frmCustomers();
			if (frm.ShowDialog(this) == DialogResult.OK && CurrRow()!=null)	   //Nếu Result = OK và Row hiện tại khác null
			{
				CurrRow().Cells[0].Value = frm.getCustomer().CustID;		   // Set giá trị mã khách hàng cho row hiện tại
				SetInfoCust(CurrRow().Index, frm.getCustomer());			   // Set thông tin khách hàng đó vào gridview
			}
		}
		
		// Sự kiện mở danh mục người nộp
		private void btChoseEmp_Click(object sender, EventArgs e)
		{
			frmEmployee frm = new frmEmployee();
			if (frm.ShowDialog(this) == DialogResult.OK)
			{
				// Set mã người nộp 
				txEmp.Text = frm.getSalesPerson().SlsPerID;
				getCurrent().SlsPerID = txEmp.Text;
			}
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txPayer.Text))
			{
				ReceiptVoucherService.Save();		 // Lưu tất cả thay đổi vào database
			}
			else MessageBox.Show("Bạn phải nhập thông tin người nộp");
			
		}

		private void btEFL_Click(object sender, EventArgs e)
		{
			frmAccountTrans frm = new frmAccountTrans(getCurrent().VoucherID); 
			frm.ShowDialog(this);
		}

		// Lấy ra phiếu thu hiện tại 
		ReceiptVoucher getCurrent() => this.receiptVoucherBS.Current as ReceiptVoucher;

		// Lấy thông tin khách hàng khi hiển thị chi tiết phiếu thu
		private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			// Lấy ra 1 khách hàng theo mã là ô đầu tiên của gridview
			var cust = CustomerService.FindOne(dataGridView1[0 , e.RowIndex].Value.ToString());

			if (cust != null) SetInfoCust(e.RowIndex, cust);    // nếu tồn tại khách hàng đó -> set thông tin khách hàng đó vào gridview			

		}
		// Set thông tin khách hàng vào các ô tương ứng trong gridview
		void SetInfoCust(int index,Customer cust)
		{
			dataGridView1[1,index].Value = cust.CustName;	// Tên khách hàng
			dataGridView1[7,index].Value = cust.Address;	// Địa chỉ
		}

		//Lấy ra hàng hiện tại
		DataGridViewRow CurrRow() => dataGridView1.CurrentRow;
	}
}
