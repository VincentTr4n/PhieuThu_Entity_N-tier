using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS_Services;

namespace MyProject01
{
	public partial class frmAccountTrans : Form
	{
		int _id;
		public frmAccountTrans(int id)
		{
			InitializeComponent();
			_id = id;
		}

		private void frmAccountTrans_Load(object sender, EventArgs e)
		{
			this.showAccTransBS.DataSource = AccountTranService.ShowOnGrid(_id);
			this.tranTypeBindingSource.DataSource = AccountTranService.GetAllType();
		}
		private void btBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1) return;
			var temp = (DataGridViewCheckBoxCell)dataGridView1.CurrentRow.Cells[0];
			temp.Value = temp.Value == null ? true : !(bool)temp.Value;
		}

		private void btSearch_Click(object sender, EventArgs e)
		{
			string typeName = cbTranTypes.SelectedValue.ToString();
			this.showAccTransBS.DataSource = AccountTranService.FindByDateAndType(_id, fromDate.Value, toDate.Value, typeName);
		}
	}
}
