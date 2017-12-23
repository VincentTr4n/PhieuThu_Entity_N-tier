using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using TMS_Objects;
using TMS_Services;

namespace MyProject01
{
	public partial class frmCustomers : Form
	{
		private Customer cust;
		public frmCustomers()
		{
			InitializeComponent();
		}

		private void frmCustomers_Load(object sender, EventArgs e)
		{
			this.customerBindingSource.DataSource = CustomerService.GetAll();
			setCombox();
		}

		private void btBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void setCombox()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("val", typeof(string));
			dt.Columns.Add("dis", typeof(string));
			dt.Rows.Add(new object[] { "0", "Hết hiệu lực" });
			dt.Rows.Add(new object[] { "1", "Còn hiệu lực" });
			comboBox1.DataSource = dt;
		}

		private void btGetAll_Click(object sender, EventArgs e)
		{
			this.customerBindingSource.DataSource = CustomerService.GetAll();
		}

		private void btSearch_Click(object sender, EventArgs e)
		{
			this.customerBindingSource.DataSource = CustomerService.FindByID(txID.Text);
		}
		public Customer getCustomer() => cust;
		private void btChose_Click(object sender, EventArgs e)
		{
			cust = this.customerBindingSource.Current as Customer;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			CustomerService.Save();
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			cust = this.customerBindingSource.Current as Customer;
			DialogResult = DialogResult.OK;
		}

		private void button4_Click(object sender, EventArgs e)
		{

		}
	}
}
