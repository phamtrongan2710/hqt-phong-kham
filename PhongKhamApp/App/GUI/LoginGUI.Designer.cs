namespace App.GUI
{
    partial class LoginGUI
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
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            passwordTextBox = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            usernameTextBox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(299, 369);
            label2.Name = "label2";
            label2.Size = new Size(202, 17);
            label2.TabIndex = 12;
            label2.Text = "Chưa có tài khoản? Đăng ký ngay";
            label2.Click += RegisterLabel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(188, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 176);
            panel1.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(passwordTextBox);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(50, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 40);
            panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(83, 5);
            passwordTextBox.Name = "textBox2";
            passwordTextBox.Size = new Size(239, 29);
            passwordTextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 7);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(usernameTextBox);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(50, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 40);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            usernameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(83, 5);
            usernameTextBox.Name = "textBox1";
            usernameTextBox.Size = new Size(239, 29);
            usernameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 7);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 0;
            label3.Text = "Tài khoản:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(321, 326);
            button1.Name = "button1";
            button1.Size = new Size(160, 40);
            button1.TabIndex = 13;
            button1.Text = "Đăng nhập";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 64);
            label1.Name = "label1";
            label1.Size = new Size(425, 50);
            label1.TabIndex = 10;
            label1.Text = "Phòng Khám Nha Khoa";
            // 
            // LoginGUI
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "LoginGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginGUI";
            FormClosing += LoginGUI_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private TextBox passwordTextBox;
        private Label label4;
        private Panel panel2;
        private TextBox usernameTextBox;
        private Label label3;
        private Button button1;
        private Label label1;
    }
}