namespace App.GUI
{
	partial class HoaDonGui
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
			label1 = new Label();
			TongTienLabel = new Label();
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			groupBoxHoaDon = new GroupBox();
			label8 = new Label();
			button2 = new Button();
			button1 = new Button();
			label_ngay_thanh_toan = new Label();
			label7 = new Label();
			label_diachi = new Label();
			label_sdt = new Label();
			label_ngay_sinh = new Label();
			label_ho_va_ten = new Label();
			label6 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label5 = new Label();
			groupBoxHoaDon.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(585, 395);
			label1.Name = "label1";
			label1.Size = new Size(96, 25);
			label1.TabIndex = 0;
			label1.Text = "Tổng tiền:";
			// 
			// TongTienLabel
			// 
			TongTienLabel.AutoSize = true;
			TongTienLabel.Location = new Point(678, 395);
			TongTienLabel.Name = "TongTienLabel";
			TongTienLabel.Size = new Size(72, 25);
			TongTienLabel.TabIndex = 1;
			TongTienLabel.Text = "100000";
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
			listView1.GridLines = true;
			listView1.Location = new Point(22, 210);
			listView1.Name = "listView1";
			listView1.Size = new Size(533, 210);
			listView1.TabIndex = 2;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Mã dịch vụ";
			columnHeader1.Width = 120;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Tên dịch vụ";
			columnHeader2.Width = 220;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Giá dịch vụ";
			columnHeader3.Width = 100;
			// 
			// groupBoxHoaDon
			// 
			groupBoxHoaDon.Controls.Add(label8);
			groupBoxHoaDon.Controls.Add(button2);
			groupBoxHoaDon.Controls.Add(button1);
			groupBoxHoaDon.Controls.Add(label_ngay_thanh_toan);
			groupBoxHoaDon.Controls.Add(label7);
			groupBoxHoaDon.Controls.Add(label_diachi);
			groupBoxHoaDon.Controls.Add(label_sdt);
			groupBoxHoaDon.Controls.Add(label_ngay_sinh);
			groupBoxHoaDon.Controls.Add(label_ho_va_ten);
			groupBoxHoaDon.Controls.Add(label6);
			groupBoxHoaDon.Controls.Add(label4);
			groupBoxHoaDon.Controls.Add(label3);
			groupBoxHoaDon.Controls.Add(label2);
			groupBoxHoaDon.Controls.Add(listView1);
			groupBoxHoaDon.Controls.Add(TongTienLabel);
			groupBoxHoaDon.Controls.Add(label1);
			groupBoxHoaDon.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			groupBoxHoaDon.Location = new Point(30, 69);
			groupBoxHoaDon.Name = "groupBoxHoaDon";
			groupBoxHoaDon.Size = new Size(839, 498);
			groupBoxHoaDon.TabIndex = 3;
			groupBoxHoaDon.TabStop = false;
			groupBoxHoaDon.Text = "Thông tin hóa đơn";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(756, 395);
			label8.Name = "label8";
			label8.Size = new Size(51, 25);
			label8.TabIndex = 30;
			label8.Text = "VND";
			// 
			// button2
			// 
			button2.Location = new Point(22, 442);
			button2.Name = "button2";
			button2.Size = new Size(120, 35);
			button2.TabIndex = 4;
			button2.Text = "Trở về";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(685, 442);
			button1.Name = "button1";
			button1.Size = new Size(122, 35);
			button1.TabIndex = 29;
			button1.Text = "In hóa đơn";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label_ngay_thanh_toan
			// 
			label_ngay_thanh_toan.AutoSize = true;
			label_ngay_thanh_toan.Location = new Point(479, 39);
			label_ngay_thanh_toan.Name = "label_ngay_thanh_toan";
			label_ngay_thanh_toan.Size = new Size(106, 25);
			label_ngay_thanh_toan.TabIndex = 28;
			label_ngay_thanh_toan.Text = "22/12/2023";
			label_ngay_thanh_toan.Click += label5_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(331, 39);
			label7.Name = "label7";
			label7.Size = new Size(157, 25);
			label7.TabIndex = 27;
			label7.Text = "Ngày thanh toán:";
			// 
			// label_diachi
			// 
			label_diachi.AutoSize = true;
			label_diachi.Location = new Point(93, 162);
			label_diachi.Name = "label_diachi";
			label_diachi.Size = new Size(73, 25);
			label_diachi.TabIndex = 26;
			label_diachi.Text = "Quận 2";
			// 
			// label_sdt
			// 
			label_sdt.AutoSize = true;
			label_sdt.Location = new Point(144, 121);
			label_sdt.Name = "label_sdt";
			label_sdt.Size = new Size(132, 25);
			label_sdt.TabIndex = 25;
			label_sdt.Text = "Nguyễn Văn A";
			// 
			// label_ngay_sinh
			// 
			label_ngay_sinh.AutoSize = true;
			label_ngay_sinh.Location = new Point(113, 80);
			label_ngay_sinh.Name = "label_ngay_sinh";
			label_ngay_sinh.Size = new Size(132, 25);
			label_ngay_sinh.TabIndex = 24;
			label_ngay_sinh.Text = "Nguyễn Văn A";
			// 
			// label_ho_va_ten
			// 
			label_ho_va_ten.AutoSize = true;
			label_ho_va_ten.Location = new Point(113, 39);
			label_ho_va_ten.Name = "label_ho_va_ten";
			label_ho_va_ten.Size = new Size(132, 25);
			label_ho_va_ten.TabIndex = 23;
			label_ho_va_ten.Text = "Nguyễn Văn A";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(22, 162);
			label6.Name = "label6";
			label6.Size = new Size(74, 25);
			label6.TabIndex = 22;
			label6.Text = "Địa chỉ:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(22, 121);
			label4.Name = "label4";
			label4.Size = new Size(127, 25);
			label4.TabIndex = 21;
			label4.Text = "Số điện thoại:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(22, 80);
			label3.Name = "label3";
			label3.Size = new Size(100, 25);
			label3.TabIndex = 20;
			label3.Text = "Ngày sinh:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(22, 39);
			label2.Name = "label2";
			label2.Size = new Size(96, 25);
			label2.TabIndex = 19;
			label2.Text = "Họ và tên:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = SystemColors.HotTrack;
			label5.Location = new Point(341, 20);
			label5.Name = "label5";
			label5.Size = new Size(274, 37);
			label5.TabIndex = 4;
			label5.Text = "Hóa đơn thanh toán";
			// 
			// HoaDonGui
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
			Controls.Add(label5);
			Controls.Add(groupBoxHoaDon);
			Name = "HoaDonGui";
			Text = "HoaDonGui";
			Load += HoaDonGui_Load_1;
			groupBoxHoaDon.ResumeLayout(false);
			groupBoxHoaDon.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label TongTienLabel;
		private ListView listView1;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private GroupBox groupBoxHoaDon;
		private Label label_ngay_thanh_toan;
		private Label label7;
		private Label label_diachi;
		private Label label_sdt;
		private Label label_ngay_sinh;
		private Label label_ho_va_ten;
		private Label label6;
		private Label label4;
		private Label label3;
		private Label label2;
		private Button button1;
		private Label label8;
		private Button button2;
		private Label label5;
	}
}