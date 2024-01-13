namespace App.GUI
{
	partial class NhanVienGUI
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
			button1 = new Button();
			textBox_sdt = new TextBox();
			labelThanhToan = new Label();
			button2 = new Button();
			groupBox1 = new GroupBox();
			label_diachi = new Label();
			label_sdt = new Label();
			label_ngay_sinh = new Label();
			label_ho_va_ten = new Label();
			label6 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			checkBox_fix = new CheckBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(94, 74);
			label1.Name = "label1";
			label1.Size = new Size(249, 25);
			label1.TabIndex = 0;
			label1.Text = "Số điện thoại đăng ký khám:\r\n";
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(569, 67);
			button1.Name = "button1";
			button1.Size = new Size(110, 36);
			button1.TabIndex = 1;
			button1.Text = "Tìm kiếm";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox_sdt
			// 
			textBox_sdt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			textBox_sdt.Location = new Point(349, 67);
			textBox_sdt.Name = "textBox_sdt";
			textBox_sdt.Size = new Size(192, 32);
			textBox_sdt.TabIndex = 3;
			// 
			// labelThanhToan
			// 
			labelThanhToan.AutoSize = true;
			labelThanhToan.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			labelThanhToan.ForeColor = SystemColors.HotTrack;
			labelThanhToan.Location = new Point(358, 9);
			labelThanhToan.Name = "labelThanhToan";
			labelThanhToan.Size = new Size(178, 41);
			labelThanhToan.TabIndex = 8;
			labelThanhToan.Text = "Thanh toán";
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			button2.Location = new Point(566, 216);
			button2.Name = "button2";
			button2.Size = new Size(135, 33);
			button2.TabIndex = 9;
			button2.Text = "Thanh toán";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label_diachi);
			groupBox1.Controls.Add(label_sdt);
			groupBox1.Controls.Add(label_ngay_sinh);
			groupBox1.Controls.Add(label_ho_va_ten);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(button2);
			groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox1.Location = new Point(94, 140);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(707, 264);
			groupBox1.TabIndex = 10;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin khách hàng";
			groupBox1.Visible = false;
			// 
			// label_diachi
			// 
			label_diachi.AutoSize = true;
			label_diachi.Location = new Point(97, 163);
			label_diachi.Name = "label_diachi";
			label_diachi.Size = new Size(73, 25);
			label_diachi.TabIndex = 18;
			label_diachi.Text = "Quận 2";
			// 
			// label_sdt
			// 
			label_sdt.AutoSize = true;
			label_sdt.Location = new Point(148, 122);
			label_sdt.Name = "label_sdt";
			label_sdt.Size = new Size(132, 25);
			label_sdt.TabIndex = 17;
			label_sdt.Text = "Nguyễn Văn A";
			// 
			// label_ngay_sinh
			// 
			label_ngay_sinh.AutoSize = true;
			label_ngay_sinh.Location = new Point(117, 81);
			label_ngay_sinh.Name = "label_ngay_sinh";
			label_ngay_sinh.Size = new Size(132, 25);
			label_ngay_sinh.TabIndex = 16;
			label_ngay_sinh.Text = "Nguyễn Văn A";
			// 
			// label_ho_va_ten
			// 
			label_ho_va_ten.AutoSize = true;
			label_ho_va_ten.Location = new Point(117, 40);
			label_ho_va_ten.Name = "label_ho_va_ten";
			label_ho_va_ten.Size = new Size(132, 25);
			label_ho_va_ten.TabIndex = 15;
			label_ho_va_ten.Text = "Nguyễn Văn A";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(26, 163);
			label6.Name = "label6";
			label6.Size = new Size(74, 25);
			label6.TabIndex = 14;
			label6.Text = "Địa chỉ:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(26, 122);
			label4.Name = "label4";
			label4.Size = new Size(127, 25);
			label4.TabIndex = 12;
			label4.Text = "Số điện thoại:";
			label4.Click += label4_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(26, 81);
			label3.Name = "label3";
			label3.Size = new Size(100, 25);
			label3.TabIndex = 11;
			label3.Text = "Ngày sinh:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(26, 40);
			label2.Name = "label2";
			label2.Size = new Size(96, 25);
			label2.TabIndex = 10;
			label2.Text = "Họ và tên:";
			// 
			// checkBox_fix
			// 
			checkBox_fix.AutoSize = true;
			checkBox_fix.Location = new Point(851, 12);
			checkBox_fix.Name = "checkBox_fix";
			checkBox_fix.Size = new Size(51, 24);
			checkBox_fix.TabIndex = 11;
			checkBox_fix.Text = "FIX";
			checkBox_fix.UseVisualStyleBackColor = true;
			// 
			// NhanVienGUI
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
			Controls.Add(checkBox_fix);
			Controls.Add(groupBox1);
			Controls.Add(labelThanhToan);
			Controls.Add(textBox_sdt);
			Controls.Add(button1);
			Controls.Add(label1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "NhanVienGUI";
			Text = "Form1";
			FormClosing += NhanVienGUI_FormClosing;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button button1;
		private TextBox textBox_sdt;
		private Label labelThanhToan;
		private Button button2;
		private GroupBox groupBox1;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label6;
		private Label label_diachi;
		private Label label_sdt;
		private Label label_ngay_sinh;
		private Label label_ho_va_ten;
		private CheckBox checkBox_fix;
	}
}