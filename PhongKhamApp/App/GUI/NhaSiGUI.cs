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

namespace App.GUI
{
    public partial class NhaSiGUI : Form
    {
        private string user_id = "";
        public NhaSiGUI(string id)
        {
            InitializeComponent();
            this.user_id = id;
        }

        private void NhaSiGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        [Obsolete]
        private void NhaSiGUI_Load(object sender, EventArgs e)
        {
            var bindingSource2 = new BindingSource { DataSource = NhaSiDAO.Instance.LayDSLichHen(user_id) };
            dataGridView2.DataSource = bindingSource2;
            textBox8.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "MALICHHEN", true, DataSourceUpdateMode.OnValidation));
            textBox7.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "NGAYKHAM", true, DataSourceUpdateMode.OnValidation));
            textBox6.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "GIOKHAM", true, DataSourceUpdateMode.OnValidation));
        }

        [Obsolete]
        private void button3_Click(object sender, EventArgs e)
        {
            refresh_tab2();
        }

        [Obsolete]
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang xử lý...");
            string procedure = "ns_capNhatLichHen";
            if (checkBox2.Checked)
            {
                procedure = "ns_capNhatLichHen_fix";
            }
            string maLH = textBox8.Text;
            string ngayKham = textBox7.Text;
            string gioKham = textBox6.Text;
            string maNS = this.user_id;
            int result = KhachHangDAO.Instance.CapNhatLichHen(procedure, maLH, ngayKham, gioKham, maNS);
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
            var bindingSource2 = new BindingSource { DataSource = NhaSiDAO.Instance.LayDSLichHen(user_id) };
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
