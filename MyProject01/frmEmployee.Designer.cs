namespace MyProject01
{
	partial class frmEmployee
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
			this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btBack = new System.Windows.Forms.Button();
			this.btDelete = new System.Windows.Forms.Button();
			this.btChose = new System.Windows.Forms.Button();
			this.btSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(512, 149);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesPersonBindingSource, "Status", true));
			this.comboBox1.DisplayMember = "dis";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(333, 13);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(173, 21);
			this.comboBox1.TabIndex = 13;
			this.comboBox1.ValueMember = "val";
			// 
			// salesPersonBindingSource
			// 
			this.salesPersonBindingSource.DataSource = typeof(TMS_Objects.SalesPerson);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(272, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Trạng thái";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(223, 94);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Phone";
			// 
			// textBox6
			// 
			this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesPersonBindingSource, "Phone", true));
			this.textBox6.Location = new System.Drawing.Point(285, 91);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(132, 20);
			this.textBox6.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Diễn giải";
			// 
			// textBox5
			// 
			this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesPersonBindingSource, "SlsPerDescr", true));
			this.textBox5.Location = new System.Drawing.Point(96, 117);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(410, 20);
			this.textBox5.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "CMT";
			// 
			// textBox4
			// 
			this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesPersonBindingSource, "CMT", true));
			this.textBox4.Location = new System.Drawing.Point(96, 91);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(96, 20);
			this.textBox4.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Địa chỉ";
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesPersonBindingSource, "Address", true));
			this.textBox3.Location = new System.Drawing.Point(96, 65);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(410, 20);
			this.textBox3.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tên NV";
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesPersonBindingSource, "SlsPerName", true));
			this.textBox2.Location = new System.Drawing.Point(96, 39);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(321, 20);
			this.textBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã NV";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesPersonBindingSource, "SlsPerID", true));
			this.textBox1.Location = new System.Drawing.Point(96, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(146, 20);
			this.textBox1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeight = 30;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.dataGridView1.DataSource = this.salesPersonBindingSource;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.Location = new System.Drawing.Point(12, 167);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(604, 309);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "SlsPerID";
			this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhân viên";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "SlsPerName";
			this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhân viên";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 180;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
			this.dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 240;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "CMT";
			this.dataGridViewTextBoxColumn4.HeaderText = "CMT";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 80;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
			this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 120;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "SlsPerDescr";
			this.dataGridViewTextBoxColumn6.HeaderText = "Diễn giải";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Width = 250;
			// 
			// btBack
			// 
			this.btBack.Location = new System.Drawing.Point(530, 137);
			this.btBack.Name = "btBack";
			this.btBack.Size = new System.Drawing.Size(86, 23);
			this.btBack.TabIndex = 2;
			this.btBack.Text = "Trở về";
			this.btBack.UseVisualStyleBackColor = true;
			this.btBack.Click += new System.EventHandler(this.btBack_Click);
			// 
			// btDelete
			// 
			this.btDelete.Location = new System.Drawing.Point(530, 108);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(86, 23);
			this.btDelete.TabIndex = 3;
			this.btDelete.Text = "Xóa";
			this.btDelete.UseVisualStyleBackColor = true;
			// 
			// btChose
			// 
			this.btChose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btChose.Location = new System.Drawing.Point(530, 83);
			this.btChose.Name = "btChose";
			this.btChose.Size = new System.Drawing.Size(86, 23);
			this.btChose.TabIndex = 4;
			this.btChose.Text = "Chọn";
			this.btChose.UseVisualStyleBackColor = true;
			this.btChose.Click += new System.EventHandler(this.btChose_Click);
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(530, 57);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(86, 23);
			this.btSave.TabIndex = 5;
			this.btSave.Text = "Lưu";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// frmEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 488);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.btChose);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.btBack);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmEmployee";
			this.Text = "frmEmployee";
			this.Load += new System.EventHandler(this.frmEmployee_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btBack;
		private System.Windows.Forms.Button btDelete;
		private System.Windows.Forms.Button btChose;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.DataGridViewTextBoxColumn slsPerIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slsPerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cMTDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slsPerDescrDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource salesPersonBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
	}
}