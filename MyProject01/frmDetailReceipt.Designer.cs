namespace MyProject01
{
	partial class frmDetailReceipt
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btAccountTran = new System.Windows.Forms.Button();
			this.cbEFL = new System.Windows.Forms.CheckBox();
			this.txEmpName = new System.Windows.Forms.TextBox();
			this.btChoseEmp = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txMAttachDescr = new System.Windows.Forms.TextBox();
			this.receiptVoucherBS = new System.Windows.Forms.BindingSource(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.txMVoucherDescr = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txAddress = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txPayer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txEmp = new System.Windows.Forms.TextBox();
			this.cbReleased = new System.Windows.Forms.ComboBox();
			this.dtVoucherDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txVoucherID = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AccAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dAccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cAccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.voucherDescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.attachDescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rVoucherDetBS = new System.Windows.Forms.BindingSource(this.components);
			this.label9 = new System.Windows.Forms.Label();
			this.txTotal = new System.Windows.Forms.TextBox();
			this.btBack = new System.Windows.Forms.Button();
			this.btSave = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btCustomers = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.receiptVoucherBS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rVoucherDetBS)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btAccountTran);
			this.groupBox1.Controls.Add(this.cbEFL);
			this.groupBox1.Controls.Add(this.txEmpName);
			this.groupBox1.Controls.Add(this.btChoseEmp);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txMAttachDescr);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txMVoucherDescr);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txAddress);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txPayer);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txEmp);
			this.groupBox1.Controls.Add(this.cbReleased);
			this.groupBox1.Controls.Add(this.dtVoucherDate);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txVoucherID);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(717, 179);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btAccountTran
			// 
			this.btAccountTran.Enabled = false;
			this.btAccountTran.Location = new System.Drawing.Point(530, 95);
			this.btAccountTran.Name = "btAccountTran";
			this.btAccountTran.Size = new System.Drawing.Size(181, 23);
			this.btAccountTran.TabIndex = 19;
			this.btAccountTran.Text = "Lựa chọn chứng từ để đối trừ";
			this.btAccountTran.UseVisualStyleBackColor = true;
			this.btAccountTran.Click += new System.EventHandler(this.btEFL_Click);
			// 
			// cbEFL
			// 
			this.cbEFL.AutoSize = true;
			this.cbEFL.Location = new System.Drawing.Point(530, 73);
			this.cbEFL.Name = "cbEFL";
			this.cbEFL.Size = new System.Drawing.Size(99, 17);
			this.cbEFL.TabIndex = 18;
			this.cbEFL.Text = "Đối trừ công nợ";
			this.cbEFL.UseVisualStyleBackColor = true;
			this.cbEFL.CheckedChanged += new System.EventHandler(this.cbEFL_CheckedChanged);
			// 
			// txEmpName
			// 
			this.txEmpName.Location = new System.Drawing.Point(280, 45);
			this.txEmpName.Name = "txEmpName";
			this.txEmpName.ReadOnly = true;
			this.txEmpName.Size = new System.Drawing.Size(431, 20);
			this.txEmpName.TabIndex = 17;
			// 
			// btChoseEmp
			// 
			this.btChoseEmp.Location = new System.Drawing.Point(244, 43);
			this.btChoseEmp.Name = "btChoseEmp";
			this.btChoseEmp.Size = new System.Drawing.Size(30, 23);
			this.btChoseEmp.TabIndex = 16;
			this.btChoseEmp.Text = "...";
			this.btChoseEmp.UseVisualStyleBackColor = true;
			this.btChoseEmp.Click += new System.EventHandler(this.btChoseEmp_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(21, 152);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Kèm theo";
			// 
			// txMAttachDescr
			// 
			this.txMAttachDescr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptVoucherBS, "MAttachDescr", true));
			this.txMAttachDescr.Location = new System.Drawing.Point(79, 149);
			this.txMAttachDescr.Name = "txMAttachDescr";
			this.txMAttachDescr.Size = new System.Drawing.Size(632, 20);
			this.txMAttachDescr.TabIndex = 5;
			// 
			// receiptVoucherBS
			// 
			this.receiptVoucherBS.DataSource = typeof(TMS_Objects.ReceiptVoucher);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(40, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(33, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Lý do";
			// 
			// txMVoucherDescr
			// 
			this.txMVoucherDescr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptVoucherBS, "MVoucherDescr", true));
			this.txMVoucherDescr.Location = new System.Drawing.Point(79, 123);
			this.txMVoucherDescr.Name = "txMVoucherDescr";
			this.txMVoucherDescr.Size = new System.Drawing.Size(632, 20);
			this.txMVoucherDescr.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(33, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Địa chỉ";
			// 
			// txAddress
			// 
			this.txAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptVoucherBS, "PAddress", true));
			this.txAddress.Location = new System.Drawing.Point(79, 97);
			this.txAddress.Name = "txAddress";
			this.txAddress.Size = new System.Drawing.Size(445, 20);
			this.txAddress.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Người nộp";
			// 
			// txPayer
			// 
			this.txPayer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptVoucherBS, "Payer", true));
			this.txPayer.Location = new System.Drawing.Point(79, 71);
			this.txPayer.Name = "txPayer";
			this.txPayer.Size = new System.Drawing.Size(445, 20);
			this.txPayer.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Nhân viên";
			// 
			// txEmp
			// 
			this.txEmp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptVoucherBS, "SlsPerID", true));
			this.txEmp.Location = new System.Drawing.Point(79, 45);
			this.txEmp.Name = "txEmp";
			this.txEmp.Size = new System.Drawing.Size(159, 20);
			this.txEmp.TabIndex = 1;
			this.txEmp.TextChanged += new System.EventHandler(this.txEmp_TextChanged);
			// 
			// cbReleased
			// 
			this.cbReleased.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.receiptVoucherBS, "Released", true));
			this.cbReleased.DisplayMember = "dis";
			this.cbReleased.FormattingEnabled = true;
			this.cbReleased.Location = new System.Drawing.Point(414, 19);
			this.cbReleased.Name = "cbReleased";
			this.cbReleased.Size = new System.Drawing.Size(297, 21);
			this.cbReleased.TabIndex = 7;
			this.cbReleased.ValueMember = "val";
			// 
			// dtVoucherDate
			// 
			this.dtVoucherDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receiptVoucherBS, "VoucherDate", true));
			this.dtVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtVoucherDate.Location = new System.Drawing.Point(244, 19);
			this.dtVoucherDate.Name = "dtVoucherDate";
			this.dtVoucherDate.Size = new System.Drawing.Size(103, 20);
			this.dtVoucherDate.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(353, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Trạng thái";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(188, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ngày thu";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Số phiếu thu";
			// 
			// txVoucherID
			// 
			this.txVoucherID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptVoucherBS, "VoucherID", true));
			this.txVoucherID.Location = new System.Drawing.Point(79, 19);
			this.txVoucherID.Name = "txVoucherID";
			this.txVoucherID.ReadOnly = true;
			this.txVoucherID.Size = new System.Drawing.Size(103, 20);
			this.txVoucherID.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn,
            this.CustName,
            this.AccAmt,
            this.dAccDataGridViewTextBoxColumn,
            this.cAccDataGridViewTextBoxColumn,
            this.voucherDescrDataGridViewTextBoxColumn,
            this.attachDescrDataGridViewTextBoxColumn,
            this.CustAddress});
			this.dataGridView1.DataSource = this.rVoucherDetBS;
			this.dataGridView1.Location = new System.Drawing.Point(13, 198);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 80;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(801, 150);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
			// 
			// custIDDataGridViewTextBoxColumn
			// 
			this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
			this.custIDDataGridViewTextBoxColumn.HeaderText = "Mã khách";
			this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
			this.custIDDataGridViewTextBoxColumn.Width = 120;
			// 
			// CustName
			// 
			this.CustName.HeaderText = "Tên Khách";
			this.CustName.Name = "CustName";
			this.CustName.Width = 180;
			// 
			// AccAmt
			// 
			this.AccAmt.DataPropertyName = "AccAmt";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "#,##0";
			this.AccAmt.DefaultCellStyle = dataGridViewCellStyle1;
			this.AccAmt.HeaderText = "Số tiền";
			this.AccAmt.Name = "AccAmt";
			this.AccAmt.Width = 120;
			// 
			// dAccDataGridViewTextBoxColumn
			// 
			this.dAccDataGridViewTextBoxColumn.DataPropertyName = "DAcc";
			this.dAccDataGridViewTextBoxColumn.HeaderText = "TK Nợ";
			this.dAccDataGridViewTextBoxColumn.Name = "dAccDataGridViewTextBoxColumn";
			this.dAccDataGridViewTextBoxColumn.ReadOnly = true;
			this.dAccDataGridViewTextBoxColumn.Width = 80;
			// 
			// cAccDataGridViewTextBoxColumn
			// 
			this.cAccDataGridViewTextBoxColumn.DataPropertyName = "CAcc";
			this.cAccDataGridViewTextBoxColumn.HeaderText = "TK Có";
			this.cAccDataGridViewTextBoxColumn.Name = "cAccDataGridViewTextBoxColumn";
			this.cAccDataGridViewTextBoxColumn.Width = 80;
			// 
			// voucherDescrDataGridViewTextBoxColumn
			// 
			this.voucherDescrDataGridViewTextBoxColumn.DataPropertyName = "VoucherDescr";
			this.voucherDescrDataGridViewTextBoxColumn.HeaderText = "Lý do";
			this.voucherDescrDataGridViewTextBoxColumn.Name = "voucherDescrDataGridViewTextBoxColumn";
			// 
			// attachDescrDataGridViewTextBoxColumn
			// 
			this.attachDescrDataGridViewTextBoxColumn.DataPropertyName = "AttachDescr";
			this.attachDescrDataGridViewTextBoxColumn.HeaderText = "Kèm theo";
			this.attachDescrDataGridViewTextBoxColumn.Name = "attachDescrDataGridViewTextBoxColumn";
			// 
			// CustAddress
			// 
			this.CustAddress.HeaderText = "Địa chỉ";
			this.CustAddress.Name = "CustAddress";
			// 
			// rVoucherDetBS
			// 
			this.rVoucherDetBS.DataSource = typeof(TMS_Objects.RVoucherDet);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(595, 357);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Tổng cộng";
			// 
			// txTotal
			// 
			this.txTotal.Location = new System.Drawing.Point(660, 354);
			this.txTotal.Name = "txTotal";
			this.txTotal.ReadOnly = true;
			this.txTotal.Size = new System.Drawing.Size(154, 20);
			this.txTotal.TabIndex = 2;
			this.txTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btBack
			// 
			this.btBack.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btBack.Location = new System.Drawing.Point(735, 168);
			this.btBack.Name = "btBack";
			this.btBack.Size = new System.Drawing.Size(79, 23);
			this.btBack.TabIndex = 1;
			this.btBack.Text = "Trở về";
			this.btBack.UseVisualStyleBackColor = true;
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(735, 139);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(79, 23);
			this.btSave.TabIndex = 0;
			this.btSave.Text = "Lưu";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(735, 79);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(79, 23);
			this.button3.TabIndex = 19;
			this.button3.Text = "In";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(736, 59);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(78, 17);
			this.checkBox1.TabIndex = 20;
			this.checkBox1.Text = "Tự động in";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// btCustomers
			// 
			this.btCustomers.Location = new System.Drawing.Point(106, 219);
			this.btCustomers.Name = "btCustomers";
			this.btCustomers.Size = new System.Drawing.Size(29, 22);
			this.btCustomers.TabIndex = 21;
			this.btCustomers.Text = "...";
			this.btCustomers.UseVisualStyleBackColor = true;
			this.btCustomers.Click += new System.EventHandler(this.btCustomers_Click);
			// 
			// frmDetailReceipt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 382);
			this.Controls.Add(this.btCustomers);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.btBack);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txTotal);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmDetailReceipt";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Phiếu thu";
			this.Load += new System.EventHandler(this.frmDetailReceipt_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.receiptVoucherBS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rVoucherDetBS)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txVoucherID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtVoucherDate;
		private System.Windows.Forms.ComboBox cbReleased;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txMAttachDescr;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txMVoucherDescr;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txPayer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txEmp;
		private System.Windows.Forms.Button btChoseEmp;
		private System.Windows.Forms.TextBox txEmpName;
		private System.Windows.Forms.CheckBox cbEFL;
		private System.Windows.Forms.Button btAccountTran;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txTotal;
		private System.Windows.Forms.Button btBack;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btCustomers;
		private System.Windows.Forms.BindingSource receiptVoucherBS;
		private System.Windows.Forms.BindingSource rVoucherDetBS;
		private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
		private System.Windows.Forms.DataGridViewTextBoxColumn AccAmt;
		private System.Windows.Forms.DataGridViewTextBoxColumn dAccDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cAccDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn voucherDescrDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn attachDescrDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustAddress;
	}
}