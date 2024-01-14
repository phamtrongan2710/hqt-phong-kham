namespace App.GUI
{
    partial class NhaSiGUI
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
            dataGridView2 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            checkBox2 = new CheckBox();
            panel2 = new Panel();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1040, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(panel2);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1032, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lịch đã đặt";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(378, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(648, 386);
            dataGridView2.TabIndex = 13;
            // 
            // button4
            // 
            button4.Location = new Point(292, 361);
            button4.Name = "button4";
            button4.Size = new Size(80, 31);
            button4.TabIndex = 12;
            button4.Text = "Cập nhật";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(211, 361);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 11;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 370);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(141, 25);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Xử lý tranh chấp";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 156);
            panel2.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(102, 119);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(260, 29);
            textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(102, 79);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(260, 29);
            textBox7.TabIndex = 5;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(102, 39);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(260, 29);
            textBox8.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 122);
            label8.Name = "label8";
            label8.Size = new Size(68, 21);
            label8.TabIndex = 3;
            label8.Text = "Giờ hẹn:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 82);
            label9.Name = "label9";
            label9.Size = new Size(80, 21);
            label9.TabIndex = 2;
            label9.Text = "Ngày hẹn:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 42);
            label10.Name = "label10";
            label10.Size = new Size(93, 21);
            label10.TabIndex = 1;
            label10.Text = "Mã lịch hẹn:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(134, 21);
            label11.TabIndex = 0;
            label11.Text = "Thông tin lịch hẹn";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1032, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // NhaSiGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 450);
            Controls.Add(tabControl1);
            Name = "NhaSiGUI";
            Text = "NhaSiGUI";
            FormClosing += NhaSiGUI_FormClosing;
            Load += NhaSiGUI_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private CheckBox checkBox2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView2;
    }
}