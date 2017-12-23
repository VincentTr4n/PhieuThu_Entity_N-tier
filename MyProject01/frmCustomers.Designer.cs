namespace MyProject01
{
	partial class frmCustomers
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label9 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btBack = new System.Windows.Forms.Button();
			this.btChose = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btSearch = new System.Windows.Forms.Button();
			this.btGetAll = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.textBox8);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.textBox7);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(674, 178);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "Status", true));
			this.comboBox1.DisplayMember = "dis";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(441, 142);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(217, 21);
			this.comboBox1.TabIndex = 18;
			this.comboBox1.ValueMember = "val";
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataSource = typeof(TMS_Objects.Customer);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(438, 126);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "Trạng thái";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(500, 47);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 17);
			this.checkBox1.TabIndex = 16;
			this.checkBox1.Text = "Khách hàng VIP";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox8
			// 
			this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "VATCode", true));
			this.textBox8.Location = new System.Drawing.Point(303, 71);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(201, 20);
			this.textBox8.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(267, 74);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "MST";
			// 
			// textBox7
			// 
			this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CMT", true));
			this.textBox7.Location = new System.Drawing.Point(303, 45);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(150, 20);
			this.textBox7.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(267, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "CMT";
			// 
			// textBox6
			// 
			this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustName", true));
			this.textBox6.Location = new System.Drawing.Point(303, 19);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(355, 20);
			this.textBox6.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(253, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Tên KH";
			// 
			// textBox5
			// 
			this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustDescr", true));
			this.textBox5.Location = new System.Drawing.Point(82, 123);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(350, 41);
			this.textBox5.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 126);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Diễn giải";
			// 
			// textBox4
			// 
			this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
			this.textBox4.Location = new System.Drawing.Point(82, 97);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(576, 20);
			this.textBox4.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Địa chỉ";
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Fax", true));
			this.textBox3.Location = new System.Drawing.Point(82, 71);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(150, 20);
			this.textBox3.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(52, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Fax";
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone", true));
			this.textBox2.Location = new System.Drawing.Point(82, 45);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(150, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Điện thoại";
			// 
			// txID
			// 
			this.txID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustID", true));
			this.txID.Location = new System.Drawing.Point(82, 19);
			this.txID.Name = "txID";
			this.txID.Size = new System.Drawing.Size(150, 20);
			this.txID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã KH";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.cMTDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.dataGridView1.DataSource = this.customerBindingSource;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.Location = new System.Drawing.Point(12, 196);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(749, 321);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "CustID";
			this.dataGridViewTextBoxColumn1.HeaderText = "Mã KH";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "CustName";
			this.dataGridViewTextBoxColumn2.HeaderText = "Tên KH";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 200;
			// 
			// cMTDataGridViewTextBoxColumn
			// 
			this.cMTDataGridViewTextBoxColumn.DataPropertyName = "CustType";
			this.cMTDataGridViewTextBoxColumn.HeaderText = "Loại KH";
			this.cMTDataGridViewTextBoxColumn.Name = "cMTDataGridViewTextBoxColumn";
			this.cMTDataGridViewTextBoxColumn.Width = 160;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
			this.dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 300;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Fax";
			this.dataGridViewTextBoxColumn4.HeaderText = "Fax";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "VATCode";
			this.dataGridViewTextBoxColumn5.HeaderText = "MST";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// btBack
			// 
			this.btBack.Location = new System.Drawing.Point(692, 167);
			this.btBack.Name = "btBack";
			this.btBack.Size = new System.Drawing.Size(75, 23);
			this.btBack.TabIndex = 2;
			this.btBack.Text = "Trở về";
			this.btBack.UseVisualStyleBackColor = true;
			this.btBack.Click += new System.EventHandler(this.btBack_Click);
			// 
			// btChose
			// 
			this.btChose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btChose.Location = new System.Drawing.Point(692, 138);
			this.btChose.Name = "btChose";
			this.btChose.Size = new System.Drawing.Size(75, 23);
			this.btChose.TabIndex = 3;
			this.btChose.Text = "Chọn";
			this.btChose.UseVisualStyleBackColor = true;
			this.btChose.Click += new System.EventHandler(this.btChose_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(692, 18);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Lưu";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(692, 47);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Xóa";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// btSearch
			// 
			this.btSearch.Location = new System.Drawing.Point(692, 73);
			this.btSearch.Name = "btSearch";
			this.btSearch.Size = new System.Drawing.Size(75, 23);
			this.btSearch.TabIndex = 6;
			this.btSearch.Text = "Tìm kiếm";
			this.btSearch.UseVisualStyleBackColor = true;
			this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
			// 
			// btGetAll
			// 
			this.btGetAll.Location = new System.Drawing.Point(692, 102);
			this.btGetAll.Name = "btGetAll";
			this.btGetAll.Size = new System.Drawing.Size(75, 23);
			this.btGetAll.TabIndex = 7;
			this.btGetAll.Text = "Xem tất";
			this.btGetAll.UseVisualStyleBackColor = true;
			this.btGetAll.Click += new System.EventHandler(this.btGetAll_Click);
			// 
			// frmCustomers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 529);
			this.Controls.Add(this.btGetAll);
			this.Controls.Add(this.btSearch);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btChose);
			this.Controls.Add(this.btBack);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmCustomers";
			this.Text = "Danh mục khách hàng";
			this.Load += new System.EventHandler(this.frmCustomers_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txID;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btBack;
		private System.Windows.Forms.Button btChose;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btSearch;
		private System.Windows.Forms.Button btGetAll;
		//private MyProject01.AppDatas.dsCustomersTableAdapters.CustomerTableAdapter customerTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn custTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn vATCodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn cMTDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.BindingSource customerBindingSource;
	}
}