using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
	public partial class frmMain : Form
	{
		enum ViewState { ShowAll, ShowBySaler, ShowByTime };  // enum các trạng thái hiển thị thông tin phiếu nhập trên gridview: Tất cả, theo người nộp, theo thời gian
		ViewState state = ViewState.ShowAll;				  // Trạng thái hiển thị dữ liệu

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmPhieuThu_Load(object sender, EventArgs e)
		{
			LoadData();					   // Hiển thị tất cả phiếu thu
			LoadSlsPer();				   // Hiển thị tên người nộp lên treeview
			LoadTime();					   // Hiển thị thời gian lên tree view
		}

		// Load tên người nộp vào tree view 
		void LoadSlsPer()
		{
			int i = 0;
			foreach (SalesPerson slsper in SalesPersonService.GetAll())
			{
				treeSlsPer.Nodes[0].Nodes.Add(slsper.SlsPerName);		 // Add tên người nộp
				treeSlsPer.Nodes[0].Nodes[i++].Tag = slsper.SlsPerID;	 // Tag node với mã người nộp để tìm kiếm theo Tag
			}
			treeSlsPer.ExpandAll();
		}

		// Load thời gian tháng/năm vào tree view
		void LoadTime()
		{
			for (int year = DateTime.Now.Year; year >= 2015; year--)
			{
				for (int month = 12; month > 0; month--)
				{
					TreeNode node = new TreeNode("Tháng " + month + "/" + year);
					node.Tag = new DateTime(year,month,1);                       // Tag node với 1 kiểu DateTime để tìm kiếm theo Tag
					treeTime.Nodes[0].Nodes.Add(node);
				}
			}
			treeTime.ExpandAll();
		}	

		// Sự kiện select tên 1 người nộp
		private void treeSlsPer_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (treeSlsPer.SelectedNode != treeSlsPer.Nodes[0])
			{
				state = ViewState.ShowBySaler;   // Set trạng thái view theo người nộp
			}
			else state = ViewState.ShowAll;    // Nếu chọn node "người nộp" -> Trạng thái là hiển thị tất cả
			LoadData();
		}

		// Sự kiện select thời gian
		private void treeTime_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (treeTime.SelectedNode != treeTime.Nodes[0])
			{
				state = ViewState.ShowByTime;    // Set trạng thái view theo thời gian
			}
			else state = ViewState.ShowAll;    // Nếu chọn node "Thời gian" -> Trạng thái là hiển thị tất cả
			LoadData();
		}

		// Show form chi tiết phiếu thu
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// Lấy ra 1 phiếu thu tương ứng khi double click vào gridview
			var rv = ReceiptVoucherService.FindOne(Convert.ToInt16(dataGridView1.CurrentRow.Cells[2].Value));

			frmDetailReceipt frm = new frmDetailReceipt(rv);    // Chuyền phiếu thu vào Form chi tiết phiếu
			if (frm.ShowDialog(this) == DialogResult.OK)
			{
				LoadData();		// Load lại dữ liệu
			}     
		}

		void LoadData()
		{
			//Load tất cả phiếu thu
			if (state == ViewState.ShowAll) this.showReceiptBS.DataSource = ReceiptVoucherService.ShowOnGrid();

			// Load dữ liệu theo mã người nộp đã Tag ở node
			if (state == ViewState.ShowBySaler) this.showReceiptBS.DataSource = ReceiptVoucherService.FindBySaleser(treeSlsPer.SelectedNode.Tag.ToString());

			// Load dữ liệu theo thời gian đã Tag ở node
			if (state == ViewState.ShowByTime) this.showReceiptBS.DataSource = ReceiptVoucherService.FindByTime((DateTime)treeTime.SelectedNode.Tag);
		}

		// Sinh số thứ tự
		private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;    // Hiển thị số thứ tự
		}
	}
}
