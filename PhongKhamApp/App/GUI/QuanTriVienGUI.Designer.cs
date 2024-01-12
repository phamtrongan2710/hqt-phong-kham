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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            dataGridView1 = new DataGridView();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1040, 426);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1032, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý nhân viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton4);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(6, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 55);
            panel2.TabIndex = 8;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(238, 14);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(118, 25);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "Quản trị viên";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(160, 14);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(72, 25);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Nha sĩ";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(55, 14);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(99, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nhân viên";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 14);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(46, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "All";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(158, 361);
            button3.Name = "button3";
            button3.Size = new Size(82, 31);
            button3.TabIndex = 7;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(334, 361);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 6;
            button2.Text = "Khóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(246, 361);
            button1.Name = "button1";
            button1.Size = new Size(82, 31);
            button1.TabIndex = 5;
            button1.Text = "Mở khóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 210);
            panel1.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(68, 162);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(335, 29);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 162);
            label6.Name = "label6";
            label6.Size = new Size(28, 21);
            label6.TabIndex = 7;
            label6.Text = "ID:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(68, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(335, 29);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 29);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 29);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 122);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 82);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 2;
            label3.Text = "SDT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Họ tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 21);
            label1.TabIndex = 0;
            label1.Text = "Thông tin nhân viên";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(418, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(608, 386);
            dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 230);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 10;
            label5.Text = "Vai trò:";
            // 
            // QuanTriVienGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 450);
            Controls.Add(tabControl1);
            Name = "QuanTriVienGUI";
            Text = "QuanTriVienGUI";
            FormClosing += QuanTriVienGUI_FormClosing;
            Load += QuanTriVienGUI_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button3;
        private Label label5;
    }
}