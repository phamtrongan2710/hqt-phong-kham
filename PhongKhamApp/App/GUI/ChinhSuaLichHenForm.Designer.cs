namespace App.GUI
{
	partial class ChinhSuaLichHenForm
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
			label2 = new Label();
			label3 = new Label();
			DateTextBox = new TextBox();
			TimeTextBox = new TextBox();
			label4 = new Label();
			nameLabel = new Label();
			ConfirmButton = new Button();
			xuLyCheckbox = new CheckBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(33, 61);
			label1.Name = "label1";
			label1.Size = new Size(57, 20);
			label1.TabIndex = 0;
			label1.Text = "Họ tên:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(33, 124);
			label2.Name = "label2";
			label2.Size = new Size(87, 20);
			label2.TabIndex = 1;
			label2.Text = "Ngày khám:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(355, 124);
			label3.Name = "label3";
			label3.Size = new Size(75, 20);
			label3.TabIndex = 2;
			label3.Text = "Giờ khám:";
			// 
			// DateTextBox
			// 
			DateTextBox.Location = new Point(33, 157);
			DateTextBox.Name = "DateTextBox";
			DateTextBox.Size = new Size(198, 27);
			DateTextBox.TabIndex = 3;
			DateTextBox.TextChanged += DateTextBox_TextChanged;
			// 
			// TimeTextBox
			// 
			TimeTextBox.Location = new Point(355, 157);
			TimeTextBox.Name = "TimeTextBox";
			TimeTextBox.Size = new Size(198, 27);
			TimeTextBox.TabIndex = 4;
			TimeTextBox.TextChanged += TimeTextBox_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(185, 9);
			label4.Name = "label4";
			label4.Size = new Size(245, 38);
			label4.TabIndex = 5;
			label4.Text = "Chỉnh sửa lịch hẹn";
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new Point(107, 61);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(49, 20);
			nameLabel.TabIndex = 6;
			nameLabel.Text = "Name";
			// 
			// ConfirmButton
			// 
			ConfirmButton.Location = new Point(459, 244);
			ConfirmButton.Name = "ConfirmButton";
			ConfirmButton.Size = new Size(94, 29);
			ConfirmButton.TabIndex = 7;
			ConfirmButton.Text = "Hoàn tất";
			ConfirmButton.UseVisualStyleBackColor = true;
			ConfirmButton.Click += ConfirmButton_Click;
			// 
			// xuLyCheckbox
			// 
			xuLyCheckbox.AutoSize = true;
			xuLyCheckbox.Location = new Point(33, 249);
			xuLyCheckbox.Name = "xuLyCheckbox";
			xuLyCheckbox.Size = new Size(138, 24);
			xuLyCheckbox.TabIndex = 8;
			xuLyCheckbox.Text = "Xử lý tranh chấp";
			xuLyCheckbox.UseVisualStyleBackColor = true;
			xuLyCheckbox.CheckedChanged += xuLyCheckbox_CheckedChanged;
			// 
			// ChinhSuaLichHenForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(568, 295);
			Controls.Add(xuLyCheckbox);
			Controls.Add(ConfirmButton);
			Controls.Add(nameLabel);
			Controls.Add(label4);
			Controls.Add(TimeTextBox);
			Controls.Add(DateTextBox);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ChinhSuaLichHenForm";
			Text = "ChinhSuaLichHenForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox DateTextBox;
		private TextBox TimeTextBox;
		private Label label4;
		private Label nameLabel;
		private Button ConfirmButton;
		private CheckBox xuLyCheckbox;
	}
}