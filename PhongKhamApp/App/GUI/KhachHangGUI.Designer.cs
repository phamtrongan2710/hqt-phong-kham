namespace App.GUI
{
	partial class KhachHangGUI
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
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			checkBox1 = new CheckBox();
			button2 = new Button();
			button1 = new Button();
			label5 = new Label();
			panel1 = new Panel();
			textBox4 = new TextBox();
			label6 = new Label();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			dateTimePicker1 = new DateTimePicker();
			dataGridView1 = new DataGridView();
			tabPage2 = new TabPage();
			button3 = new Button();
			dataGridView2 = new DataGridView();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new Point(14, 16);
			tabControl1.Margin = new Padding(3, 4, 3, 4);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1189, 568);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(checkBox1);
			tabPage1.Controls.Add(button2);
			tabPage1.Controls.Add(button1);
			tabPage1.Controls.Add(label5);
			tabPage1.Controls.Add(panel1);
			tabPage1.Controls.Add(dateTimePicker1);
			tabPage1.Controls.Add(dataGridView1);
			tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			tabPage1.Location = new Point(4, 29);
			tabPage1.Margin = new Padding(3, 4, 3, 4);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3, 4, 3, 4);
			tabPage1.Size = new Size(1181, 535);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Đặt lịch hẹn";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(7, 493);
			checkBox1.Margin = new Padding(3, 4, 3, 4);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(176, 32);
			checkBox1.TabIndex = 7;
			checkBox1.Text = "Xử lý tranh chấp";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.AutoSize = true;
			button2.Location = new Point(289, 481);
			button2.Margin = new Padding(3, 4, 3, 4);
			button2.Name = "button2";
			button2.Size = new Size(97, 51);
			button2.TabIndex = 6;
			button2.Text = "Refresh";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.AutoSize = true;
			button1.Location = new Point(382, 481);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(101, 51);
			button1.TabIndex = 5;
			button1.Text = "Đặt lịch";
			button1.UseVisualStyleBackColor = true;
			button1.Click += DatLichButton_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(11, 304);
			label5.Name = "label5";
			label5.Size = new Size(63, 28);
			label5.TabIndex = 3;
			label5.Text = "Ngày:";
			// 
			// panel1
			// 
			panel1.Controls.Add(textBox4);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(textBox3);
			panel1.Controls.Add(textBox2);
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(7, 8);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(464, 280);
			panel1.TabIndex = 2;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(78, 216);
			textBox4.Margin = new Padding(3, 4, 3, 4);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(382, 34);
			textBox4.TabIndex = 8;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(3, 216);
			label6.Name = "label6";
			label6.Size = new Size(35, 28);
			label6.TabIndex = 7;
			label6.Text = "ID:";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(78, 159);
			textBox3.Margin = new Padding(3, 4, 3, 4);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(382, 34);
			textBox3.TabIndex = 6;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(78, 105);
			textBox2.Margin = new Padding(3, 4, 3, 4);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(382, 34);
			textBox2.TabIndex = 5;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(78, 52);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(382, 34);
			textBox1.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(3, 163);
			label4.Name = "label4";
			label4.Size = new Size(63, 28);
			label4.TabIndex = 3;
			label4.Text = "Email:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 109);
			label3.Name = "label3";
			label3.Size = new Size(50, 28);
			label3.TabIndex = 2;
			label3.Text = "SDT:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 56);
			label2.Name = "label2";
			label2.Size = new Size(75, 28);
			label2.TabIndex = 1;
			label2.Text = "Họ tên:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(151, 28);
			label1.TabIndex = 0;
			label1.Text = "Thông tin nha sĩ";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.CustomFormat = "dd/MM/yyyy  HH:mm";
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.Location = new Point(85, 296);
			dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(247, 34);
			dateTimePicker1.TabIndex = 1;
			dateTimePicker1.Value = new DateTime(2024, 1, 3, 0, 0, 0, 0);
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(478, 8);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(695, 515);
			dataGridView1.TabIndex = 0;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(button3);
			tabPage2.Controls.Add(dataGridView2);
			tabPage2.Location = new Point(4, 29);
			tabPage2.Margin = new Padding(3, 4, 3, 4);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3, 4, 3, 4);
			tabPage2.Size = new Size(1181, 535);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Lịch đã đặt";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.AutoSize = true;
			button3.Location = new Point(1087, 487);
			button3.Margin = new Padding(3, 4, 3, 4);
			button3.Name = "button3";
			button3.Size = new Size(86, 41);
			button3.TabIndex = 7;
			button3.Text = "Refresh";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// dataGridView2
			// 
			dataGridView2.AllowUserToAddRows = false;
			dataGridView2.AllowUserToDeleteRows = false;
			dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(7, 8);
			dataGridView2.Margin = new Padding(3, 4, 3, 4);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.RowHeadersWidth = 51;
			dataGridView2.RowTemplate.Height = 25;
			dataGridView2.Size = new Size(1166, 471);
			dataGridView2.TabIndex = 0;
			// 
			// KhachHangGUI
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1216, 600);
			Controls.Add(tabControl1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "KhachHangGUI";
			Text = "KhachHangGUI";
			FormClosing += KhachHangGUI_FormClosing;
			Load += KhachHangGUI_Load;
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private DataGridView dataGridView1;
		private TabPage tabPage2;
		private Panel panel1;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private DateTimePicker dateTimePicker1;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label5;
		private Button button1;
		private TextBox textBox4;
		private Label label6;
		private Button button2;
		private Button button3;
		private DataGridView dataGridView2;
		private CheckBox checkBox1;
	}
}