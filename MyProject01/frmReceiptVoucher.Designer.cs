namespace MyProject01
{
	partial class frmMain
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Người nộp");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Thời gian");
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabSlsPer = new System.Windows.Forms.TabControl();
			this.tab = new System.Windows.Forms.TabPage();
			this.treeSlsPer = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.tabTime = new System.Windows.Forms.TabPage();
			this.treeTime = new System.Windows.Forms.TreeView();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.voucherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.voucherDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.slsPerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.payerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mVoucherDescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.showReceiptBS = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabSlsPer.SuspendLayout();
			this.tab.SuspendLayout();
			this.tabTime.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.showReceiptBS)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tabSlsPer);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
			this.splitContainer1.Size = new System.Drawing.Size(1317, 601);
			this.splitContainer1.SplitterDistance = 284;
			this.splitContainer1.TabIndex = 0;
			// 
			// tabSlsPer
			// 
			this.tabSlsPer.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabSlsPer.Controls.Add(this.tab);
			this.tabSlsPer.Controls.Add(this.tabTime);
			this.tabSlsPer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabSlsPer.Location = new System.Drawing.Point(0, 0);
			this.tabSlsPer.Name = "tabSlsPer";
			this.tabSlsPer.SelectedIndex = 0;
			this.tabSlsPer.Size = new System.Drawing.Size(284, 601);
			this.tabSlsPer.TabIndex = 0;
			// 
			// tab
			// 
			this.tab.Controls.Add(this.treeSlsPer);
			this.tab.Location = new System.Drawing.Point(4, 4);
			this.tab.Name = "tab";
			this.tab.Padding = new System.Windows.Forms.Padding(3);
			this.tab.Size = new System.Drawing.Size(276, 575);
			this.tab.TabIndex = 0;
			this.tab.Text = "Người nộp";
			this.tab.UseVisualStyleBackColor = true;
			// 
			// treeSlsPer
			// 
			this.treeSlsPer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeSlsPer.ImageIndex = 0;
			this.treeSlsPer.ImageList = this.imageList1;
			this.treeSlsPer.Location = new System.Drawing.Point(3, 3);
			this.treeSlsPer.Name = "treeSlsPer";
			treeNode1.Name = "rSlsPer";
			treeNode1.Text = "Người nộp";
			this.treeSlsPer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.treeSlsPer.SelectedImageIndex = 0;
			this.treeSlsPer.Size = new System.Drawing.Size(270, 569);
			this.treeSlsPer.TabIndex = 0;
			this.treeSlsPer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeSlsPer_AfterSelect);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Open.gif");
			// 
			// tabTime
			// 
			this.tabTime.Controls.Add(this.treeTime);
			this.tabTime.Location = new System.Drawing.Point(4, 4);
			this.tabTime.Name = "tabTime";
			this.tabTime.Padding = new System.Windows.Forms.Padding(3);
			this.tabTime.Size = new System.Drawing.Size(276, 575);
			this.tabTime.TabIndex = 1;
			this.tabTime.Text = "Thời gian";
			this.tabTime.UseVisualStyleBackColor = true;
			// 
			// treeTime
			// 
			this.treeTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeTime.ImageIndex = 0;
			this.treeTime.ImageList = this.imageList1;
			this.treeTime.Location = new System.Drawing.Point(3, 3);
			this.treeTime.Name = "treeTime";
			treeNode2.Name = "rTime";
			treeNode2.Text = "Thời gian";
			this.treeTime.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
			this.treeTime.SelectedImageIndex = 0;
			this.treeTime.Size = new System.Drawing.Size(270, 569);
			this.treeTime.TabIndex = 0;
			this.treeTime.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeTime_AfterSelect);
			// 
			// tabControl2
			// 
			this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl2.Location = new System.Drawing.Point(0, 0);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(1029, 601);
			this.tabControl2.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dataGridView1);
			this.tabPage3.Location = new System.Drawing.Point(4, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1021, 575);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Phiếu thu";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.STT,
            this.voucherIDDataGridViewTextBoxColumn,
            this.voucherDateDataGridViewTextBoxColumn,
            this.slsPerNameDataGridViewTextBoxColumn,
            this.payerDataGridViewTextBoxColumn,
            this.pAddressDataGridViewTextBoxColumn,
            this.totalAmtDataGridViewTextBoxColumn,
            this.mVoucherDescrDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.showReceiptBS;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1015, 569);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
			// 
			// colCheck
			// 
			this.colCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.colCheck.HeaderText = "";
			this.colCheck.Name = "colCheck";
			this.colCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colCheck.Width = 5;
			// 
			// STT
			// 
			this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.STT.DefaultCellStyle = dataGridViewCellStyle2;
			this.STT.HeaderText = "Số TT";
			this.STT.Name = "STT";
			this.STT.ReadOnly = true;
			this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.STT.Width = 43;
			// 
			// voucherIDDataGridViewTextBoxColumn
			// 
			this.voucherIDDataGridViewTextBoxColumn.DataPropertyName = "VoucherID";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.voucherIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.voucherIDDataGridViewTextBoxColumn.HeaderText = "Số phiếu thu";
			this.voucherIDDataGridViewTextBoxColumn.Name = "voucherIDDataGridViewTextBoxColumn";
			// 
			// voucherDateDataGridViewTextBoxColumn
			// 
			this.voucherDateDataGridViewTextBoxColumn.DataPropertyName = "VoucherDate";
			this.voucherDateDataGridViewTextBoxColumn.HeaderText = "Ngày thu";
			this.voucherDateDataGridViewTextBoxColumn.Name = "voucherDateDataGridViewTextBoxColumn";
			// 
			// slsPerNameDataGridViewTextBoxColumn
			// 
			this.slsPerNameDataGridViewTextBoxColumn.DataPropertyName = "SlsPerName";
			this.slsPerNameDataGridViewTextBoxColumn.HeaderText = "Nhân viên";
			this.slsPerNameDataGridViewTextBoxColumn.Name = "slsPerNameDataGridViewTextBoxColumn";
			this.slsPerNameDataGridViewTextBoxColumn.Width = 160;
			// 
			// payerDataGridViewTextBoxColumn
			// 
			this.payerDataGridViewTextBoxColumn.DataPropertyName = "Payer";
			this.payerDataGridViewTextBoxColumn.HeaderText = " Người nộp";
			this.payerDataGridViewTextBoxColumn.Name = "payerDataGridViewTextBoxColumn";
			this.payerDataGridViewTextBoxColumn.Width = 120;
			// 
			// pAddressDataGridViewTextBoxColumn
			// 
			this.pAddressDataGridViewTextBoxColumn.DataPropertyName = "PAddress";
			this.pAddressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
			this.pAddressDataGridViewTextBoxColumn.Name = "pAddressDataGridViewTextBoxColumn";
			this.pAddressDataGridViewTextBoxColumn.Width = 160;
			// 
			// totalAmtDataGridViewTextBoxColumn
			// 
			this.totalAmtDataGridViewTextBoxColumn.DataPropertyName = "TotalAmt";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "#,##0";
			this.totalAmtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
			this.totalAmtDataGridViewTextBoxColumn.HeaderText = "Số tiền";
			this.totalAmtDataGridViewTextBoxColumn.Name = "totalAmtDataGridViewTextBoxColumn";
			this.totalAmtDataGridViewTextBoxColumn.Width = 120;
			// 
			// mVoucherDescrDataGridViewTextBoxColumn
			// 
			this.mVoucherDescrDataGridViewTextBoxColumn.DataPropertyName = "MVoucherDescr";
			this.mVoucherDescrDataGridViewTextBoxColumn.HeaderText = "Diễn giải";
			this.mVoucherDescrDataGridViewTextBoxColumn.Name = "mVoucherDescrDataGridViewTextBoxColumn";
			this.mVoucherDescrDataGridViewTextBoxColumn.Width = 160;
			// 
			// showReceiptBS
			// 
			this.showReceiptBS.DataSource = typeof(TMS_Objects.ShowReceipt);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1317, 601);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Phiếu Thu";
			this.Load += new System.EventHandler(this.frmPhieuThu_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabSlsPer.ResumeLayout(false);
			this.tab.ResumeLayout(false);
			this.tabTime.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.showReceiptBS)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabControl tabSlsPer;
		private System.Windows.Forms.TabPage tab;
		private System.Windows.Forms.TabPage tabTime;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TreeView treeSlsPer;
		private System.Windows.Forms.TreeView treeTime;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn voucherIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn voucherDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slsPerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn payerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalAmtDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mVoucherDescrDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource showReceiptBS;
	}
}

