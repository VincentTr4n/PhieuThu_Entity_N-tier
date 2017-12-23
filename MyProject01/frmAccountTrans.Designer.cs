namespace MyProject01
{
	partial class frmAccountTrans
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cbCell = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.showAccTransBS = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbTranTypes = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.toDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.btSearch = new System.Windows.Forms.Button();
			this.fromDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.btChose = new System.Windows.Forms.Button();
			this.btBack = new System.Windows.Forms.Button();
			this.tranTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.showAccTransBS)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tranTypeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.ColumnHeadersHeight = 34;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbCell,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4});
			this.dataGridView1.DataSource = this.showAccTransBS;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.Location = new System.Drawing.Point(12, 102);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(653, 273);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// cbCell
			// 
			this.cbCell.HeaderText = "";
			this.cbCell.Name = "cbCell";
			this.cbCell.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.cbCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.cbCell.Width = 20;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "RefNo";
			this.dataGridViewTextBoxColumn2.HeaderText = "Số chứng từ";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "RefDate";
			this.dataGridViewTextBoxColumn3.HeaderText = "Ngày chứng từ";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "TranTypeName";
			this.dataGridViewTextBoxColumn1.HeaderText = "Loại";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 160;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "D_CustID";
			this.dataGridViewTextBoxColumn5.HeaderText = "Mã khách hàng";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "CustName";
			this.dataGridViewTextBoxColumn6.HeaderText = "Tên khách hàng";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Width = 240;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "OrigAmt";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "#,##0";
			this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewTextBoxColumn4.HeaderText = "Số tiền";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// showAccTransBS
			// 
			this.showAccTransBS.DataSource = typeof(TMS_Objects.ShowAccountTrans_Result);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbTranTypes);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.toDate);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btSearch);
			this.groupBox1.Controls.Add(this.fromDate);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(458, 84);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin tìm kiếm";
			// 
			// cbTranTypes
			// 
			this.cbTranTypes.DataSource = this.tranTypeBindingSource;
			this.cbTranTypes.DisplayMember = "TranTypeName";
			this.cbTranTypes.FormattingEnabled = true;
			this.cbTranTypes.Location = new System.Drawing.Point(96, 52);
			this.cbTranTypes.Name = "cbTranTypes";
			this.cbTranTypes.Size = new System.Drawing.Size(271, 21);
			this.cbTranTypes.TabIndex = 6;
			this.cbTranTypes.ValueMember = "TranType1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Loại chứng từ";
			// 
			// toDate
			// 
			this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.toDate.Location = new System.Drawing.Point(264, 23);
			this.toDate.Name = "toDate";
			this.toDate.Size = new System.Drawing.Size(103, 20);
			this.toDate.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(205, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Đến ngày";
			// 
			// btSearch
			// 
			this.btSearch.Location = new System.Drawing.Point(377, 50);
			this.btSearch.Name = "btSearch";
			this.btSearch.Size = new System.Drawing.Size(75, 23);
			this.btSearch.TabIndex = 4;
			this.btSearch.Text = "Tìm kiếm";
			this.btSearch.UseVisualStyleBackColor = true;
			this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
			// 
			// fromDate
			// 
			this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.fromDate.Location = new System.Drawing.Point(96, 23);
			this.fromDate.Name = "fromDate";
			this.fromDate.Size = new System.Drawing.Size(103, 20);
			this.fromDate.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ ngày";
			// 
			// btChose
			// 
			this.btChose.Location = new System.Drawing.Point(494, 62);
			this.btChose.Name = "btChose";
			this.btChose.Size = new System.Drawing.Size(75, 23);
			this.btChose.TabIndex = 5;
			this.btChose.Text = "Chọn";
			this.btChose.UseVisualStyleBackColor = true;
			// 
			// btBack
			// 
			this.btBack.Location = new System.Drawing.Point(575, 62);
			this.btBack.Name = "btBack";
			this.btBack.Size = new System.Drawing.Size(75, 23);
			this.btBack.TabIndex = 6;
			this.btBack.Text = "Trở về";
			this.btBack.UseVisualStyleBackColor = true;
			this.btBack.Click += new System.EventHandler(this.btBack_Click);
			// 
			// tranTypeBindingSource
			// 
			this.tranTypeBindingSource.DataSource = typeof(TMS_Objects.TranType);
			// 
			// frmAccountTrans
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 383);
			this.Controls.Add(this.btBack);
			this.Controls.Add(this.btChose);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MinimizeBox = false;
			this.Name = "frmAccountTrans";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Danh sách các khoản phải thu của khách hàng";
			this.Load += new System.EventHandler(this.frmAccountTrans_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.showAccTransBS)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tranTypeBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker fromDate;
		private System.Windows.Forms.DateTimePicker toDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbTranTypes;
		private System.Windows.Forms.Button btChose;
		private System.Windows.Forms.Button btBack;
		private System.Windows.Forms.DataGridViewTextBoxColumn refNoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn refDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tranTypeNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dCustIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn origAmtDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource showAccTransBS;
		private System.Windows.Forms.DataGridViewCheckBoxColumn cbCell;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.BindingSource tranTypeBindingSource;
	}
}