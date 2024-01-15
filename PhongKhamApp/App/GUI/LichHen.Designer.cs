namespace App.GUI
{
    partial class LichHen
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
            bnTextBox = new TextBox();
            label3 = new Label();
            tgTextBox = new TextBox();
            label4 = new Label();
            dTextBox = new TextBox();
            label5 = new Label();
            ndTextBox = new TextBox();
            button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 25);
            label1.TabIndex = 0;
            label1.Text = "Thêm lịch hẹn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 52);
            label2.Name = "label2";
            label2.Size = new Size(300, 24);
            label2.TabIndex = 1;
            label2.Text = "Bệnh nhân";
            // 
            // bnTextBox
            // 
            bnTextBox.Location = new Point(29, 80);
            bnTextBox.Name = "bnTextBox";
            bnTextBox.Size = new Size(300, 23);
            bnTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 106);
            label3.Name = "label3";
            label3.Size = new Size(300, 24);
            label3.TabIndex = 3;
            label3.Text = "Giờ khám";
            // 
            // tgTextBox
            // 
            tgTextBox.Location = new Point(29, 133);
            tgTextBox.Name = "tgTextBox";
            tgTextBox.Size = new Size(300, 23);
            tgTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 159);
            label4.Name = "label4";
            label4.Size = new Size(300, 24);
            label4.TabIndex = 5;
            label4.Text = "Ngày khám";
            // 
            // dTextBox
            // 
            dTextBox.Location = new Point(29, 186);
            dTextBox.Name = "dTextBox";
            dTextBox.Size = new Size(300, 23);
            dTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 212);
            label5.Name = "label5";
            label5.Size = new Size(300, 24);
            label5.TabIndex = 7;
            label5.Text = "Nội dung";
            // 
            // ndTextBox
            // 
            ndTextBox.Location = new Point(29, 239);
            ndTextBox.Multiline = true;
            ndTextBox.Name = "ndTextBox";
            ndTextBox.Size = new Size(300, 150);
            ndTextBox.TabIndex = 8;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button.Location = new Point(30, 403);
            button.Name = "button";
            button.Size = new Size(299, 35);
            button.TabIndex = 9;
            button.Text = "Gửi";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // LichHen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button);
            Controls.Add(ndTextBox);
            Controls.Add(label5);
            Controls.Add(dTextBox);
            Controls.Add(label4);
            Controls.Add(tgTextBox);
            Controls.Add(label3);
            Controls.Add(bnTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LichHen";
            Text = "LichHen";
            Load += LichHen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox bnTextBox;
        private Label label3;
        private TextBox tgTextBox;
        private Label label4;
        private TextBox dTextBox;
        private Label label5;
        private TextBox ndTextBox;
        private Button button;
    }
}