namespace App.GUI
{
	partial class QuanTriVienGUI
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			label1 = new Label();
			panel1 = new Panel();
			button_sua = new Button();
			button_xoa = new Button();
			button_them = new Button();
			textBox_gia_dv = new TextBox();
			textBox_ten_dv = new TextBox();
			label4 = new Label();
			label3 = new Label();
			textBox_ma_dv = new TextBox();
			label2 = new Label();
			dataGridView_dich_vu = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_dich_vu).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.HotTrack;
			label1.Location = new Point(333, 29);
			label1.Name = "label1";
			label1.Size = new Size(236, 41);
			label1.TabIndex = 0;
			label1.Text = "Quản lý dịch vụ";
			// 
			// panel1
			// 
			panel1.Controls.Add(button_sua);
			panel1.Controls.Add(button_xoa);
			panel1.Controls.Add(button_them);
			panel1.Controls.Add(textBox_gia_dv);
			panel1.Controls.Add(textBox_ten_dv);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(textBox_ma_dv);
			panel1.Controls.Add(label2);
			panel1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			panel1.Location = new Point(15, 119);
			panel1.Name = "panel1";
			panel1.Size = new Size(335, 322);
			panel1.TabIndex = 2;
			// 
			// button_sua
			// 
			button_sua.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			button_sua.Location = new Point(237, 247);
			button_sua.Name = "button_sua";
			button_sua.Size = new Size(94, 37);
			button_sua.TabIndex = 4;
			button_sua.Text = "Sửa";
			button_sua.UseVisualStyleBackColor = true;
			button_sua.Click += button_sua_Click;
			// 
			// button_xoa
			// 
			button_xoa.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			button_xoa.Location = new Point(120, 247);
			button_xoa.Name = "button_xoa";
			button_xoa.Size = new Size(94, 37);
			button_xoa.TabIndex = 5;
			button_xoa.Text = "Xóa";
			button_xoa.UseVisualStyleBackColor = true;
			// 
			// button_them
			// 
			button_them.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			button_them.Location = new Point(3, 247);
			button_them.Name = "button_them";
			button_them.Size = new Size(94, 37);
			button_them.TabIndex = 6;
			button_them.Text = "Thêm";
			button_them.UseVisualStyleBackColor = true;
			// 
			// textBox_gia_dv
			// 
			textBox_gia_dv.Location = new Point(125, 142);
			textBox_gia_dv.Name = "textBox_gia_dv";
			textBox_gia_dv.Size = new Size(192, 30);
			textBox_gia_dv.TabIndex = 6;
			// 
			// textBox_ten_dv
			// 
			textBox_ten_dv.Location = new Point(125, 89);
			textBox_ten_dv.Name = "textBox_ten_dv";
			textBox_ten_dv.Size = new Size(192, 30);
			textBox_ten_dv.TabIndex = 5;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ControlText;
			label4.Location = new Point(10, 149);
			label4.Name = "label4";
			label4.Size = new Size(112, 23);
			label4.TabIndex = 4;
			label4.Text = "*Giá dịch vụ:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ControlText;
			label3.Location = new Point(9, 96);
			label3.Name = "label3";
			label3.Size = new Size(113, 23);
			label3.TabIndex = 2;
			label3.Text = "*Tên dịch vụ:";
			// 
			// textBox_ma_dv
			// 
			textBox_ma_dv.Location = new Point(125, 36);
			textBox_ma_dv.Name = "textBox_ma_dv";
			textBox_ma_dv.Size = new Size(192, 30);
			textBox_ma_dv.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ControlText;
			label2.Location = new Point(8, 43);
			label2.Name = "label2";
			label2.Size = new Size(111, 23);
			label2.TabIndex = 0;
			label2.Text = "*Mã dịch vụ:";
			// 
			// dataGridView_dich_vu
			// 
			dataGridView_dich_vu.BackgroundColor = SystemColors.Control;
			dataGridView_dich_vu.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.InactiveBorder;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView_dich_vu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView_dich_vu.ColumnHeadersHeight = 30;
			dataGridView_dich_vu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridView_dich_vu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dataGridView_dich_vu.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridView_dich_vu.EnableHeadersVisualStyles = false;
			dataGridView_dich_vu.Location = new Point(352, 119);
			dataGridView_dich_vu.Name = "dataGridView_dich_vu";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dataGridView_dich_vu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridView_dich_vu.RowHeadersWidth = 51;
			dataGridView_dich_vu.RowTemplate.Height = 29;
			dataGridView_dich_vu.Size = new Size(546, 322);
			dataGridView_dich_vu.TabIndex = 3;
			dataGridView_dich_vu.CellContentClick += dataGridView_dich_vu_CellContentClick_1;
			// 
			// Column1
			// 
			Column1.HeaderText = "Mã dịch vụ";
			Column1.MinimumWidth = 6;
			Column1.Name = "Column1";
			Column1.Width = 120;
			// 
			// Column2
			// 
			Column2.HeaderText = "Tên dịch vụ";
			Column2.MinimumWidth = 6;
			Column2.Name = "Column2";
			Column2.Width = 160;
			// 
			// Column3
			// 
			Column3.HeaderText = "Giá dịch vụ";
			Column3.MinimumWidth = 6;
			Column3.Name = "Column3";
			Column3.Width = 120;
			// 
			// QuanTriVienGUI
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
			Controls.Add(dataGridView_dich_vu);
			Controls.Add(panel1);
			Controls.Add(label1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "QuanTriVienGUI";
			Text = "QuanTriVienGUI";
			Load += QuanTriVienGUI_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_dich_vu).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Panel panel1;
		private Label label4;
		private Label label3;
		private TextBox textBox_ma_dv;
		private Label label2;
		private DataGridView dataGridView_dich_vu;
		private TextBox textBox_gia_dv;
		private TextBox textBox_ten_dv;
		private Button button_sua;
		private Button button_xoa;
		private Button button_them;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
	}
}