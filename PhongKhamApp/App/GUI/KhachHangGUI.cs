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
            var bindingSource1 = new BindingSource { DataSource = KhachHangDAO.Instance.LayDSNhaSi() };
            dataGridView1.DataSource = bindingSource1;
            var bindingSource2 = new BindingSource { DataSource = KhachHangDAO.Instance.LayDSLichHen(user_id) };
            dataGridView2.DataSource = bindingSource2;
            textBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "HOTEN", true, DataSourceUpdateMode.OnValidation));
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SDT", true, DataSourceUpdateMode.OnValidation));
            textBox3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "EMAIL", true, DataSourceUpdateMode.OnValidation));
            textBox4.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MANV", true, DataSourceUpdateMode.OnValidation));
        }

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
            refresh();
        }

        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }

        [Obsolete]
        private void button3_Click(object sender, EventArgs e)
        {
            var bindingSource2 = new BindingSource { DataSource = KhachHangDAO.Instance.LayDSLichHen(user_id) };
            dataGridView2.DataSource = bindingSource2;
        }

        [Obsolete]
        private void refresh()
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
    }
}
