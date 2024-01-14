using App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App.GUI
{
    public partial class KhachHangGUI : Form
    {
        private string user_id = "";
        public KhachHangGUI(string id)
        {
            InitializeComponent();
            this.user_id = id;
        }

        private void KhachHangGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        [Obsolete]
        private void KhachHangGUI_Load(object sender, EventArgs e)
        {
            // tab 1: Dat lich hen
            var bindingSource1 = new BindingSource { DataSource = KhachHangDAO.Instance.LayDSNhaSi() };
            dataGridView1.DataSource = bindingSource1;
            textBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "HOTEN", true, DataSourceUpdateMode.OnValidation));
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SDT", true, DataSourceUpdateMode.OnValidation));
            textBox3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "EMAIL", true, DataSourceUpdateMode.OnValidation));
            textBox4.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MANV", true, DataSourceUpdateMode.OnValidation));
            // tab 2: Cap nhat lich hen
            var bindingSource2 = new BindingSource { DataSource = KhachHangDAO.Instance.LayDSLichHen(user_id) };
            dataGridView2.DataSource = bindingSource2;
            textBox8.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "MALICHHEN", true, DataSourceUpdateMode.OnValidation));
            textBox7.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "NGAYKHAM", true, DataSourceUpdateMode.OnValidation));
            textBox6.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "GIOKHAM", true, DataSourceUpdateMode.OnValidation));
        }

        // tab 1
        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang xử lý...");
            string procedure = "kh_datLichHen";
            if (checkBox1.Checked)
            {
                procedure = "kh_datLichHen_fix";
            }
            string gioKham = dateTimePicker1.Value.ToShortTimeString();
            string ngayKham = dateTimePicker1.Value.ToShortDateString();
            string maNS = textBox4.Text;
            string maKH = this.user_id;
            int result = KhachHangDAO.Instance.DatLichHen(procedure, ngayKham, gioKham, maNS, maKH);
            if (result == 0)
            {
                MessageBox.Show("Đặt lịch thất bại!");
            }
            else if (result == 1)
            {
                MessageBox.Show("Đặt lịch thành công!");
            }
            refresh_tab1();
        }

        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            refresh_tab1();
        }

        [Obsolete]
        private void refresh_tab1()
        {
            var bindingSource1 = new BindingSource { DataSource = KhachHangDAO.Instance.LayDSNhaSi() };
            dataGridView1.DataSource = bindingSource1;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "HOTEN", true, DataSourceUpdateMode.OnValidation));
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SDT", true, DataSourceUpdateMode.OnValidation));
            textBox3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "EMAIL", true, DataSourceUpdateMode.OnValidation));
            textBox4.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MANV", true, DataSourceUpdateMode.OnValidation));
        }

        // tab 2
        [Obsolete]
        private void button3_Click(object sender, EventArgs e)
        {
            refresh_tab2();
        }

        [Obsolete]
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang xử lý...");
            string procedure = "kh_capNhatLichHen";
            if (checkBox2.Checked)
            {
                procedure = "kh_capNhatLichHen_fix";
            }
            string maLH = textBox8.Text;
            string ngayKham = textBox7.Text;
            string gioKham = textBox6.Text;
            string maKH = this.user_id;
            int result = KhachHangDAO.Instance.CapNhatLichHen(procedure, maLH, ngayKham, gioKham, maKH);
            if (result == 0)
            {
                MessageBox.Show("Cập nhật lịch thất bại!");
            }
            else if (result == 1)
            {
                MessageBox.Show("Cập nhật lịch thành công!");
            }
            refresh_tab2();
        }

        [Obsolete]
        private void refresh_tab2()
        {
            var bindingSource2 = new BindingSource { DataSource = KhachHangDAO.Instance.LayDSLichHen(user_id) };
            dataGridView2.DataSource = bindingSource2;
            textBox8.DataBindings.Clear();
            textBox7.DataBindings.Clear();
            textBox6.DataBindings.Clear();
            textBox8.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "MALICHHEN", true, DataSourceUpdateMode.OnValidation));
            textBox7.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "NGAYKHAM", true, DataSourceUpdateMode.OnValidation));
            textBox6.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "GIOKHAM", true, DataSourceUpdateMode.OnValidation));
        }
    }
}
