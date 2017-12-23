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
	public partial class frmEmployee : Form
	{
		private SalesPerson SlsPer;

		public frmEmployee()
		{
			InitializeComponent();
		}
		private void frmEmployee_Load(object sender, EventArgs e)
		{
			this.salesPersonBindingSource.DataSource = SalesPersonService.GetAll();			// Load dữ liệu lên gridview

			DataTable dt = new DataTable();
			dt.Columns.Add("val", typeof(string));
			dt.Columns.Add("dis", typeof(string));
			dt.Rows.Add(new object[] { "0", "Hết hiệu lực" });
			dt.Rows.Add(new object[] { "1", "Còn hiệu lực" });
			comboBox1.DataSource = dt;
		}
		private void btBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public SalesPerson getSalesPerson() => SlsPer;

		private void btChose_Click(object sender, EventArgs e)
		{
			SlsPer = this.salesPersonBindingSource.Current as SalesPerson;
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			SlsPer = this.salesPersonBindingSource.Current as SalesPerson;
			DialogResult = DialogResult.OK;
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			SalesPersonService.Save();
		}
	}
}
