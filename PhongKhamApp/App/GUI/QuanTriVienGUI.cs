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
    public partial class QuanTriVienGUI : Form
    {
        private string user_id = "";
        private string vaiTro = "";
        public QuanTriVienGUI(string id)
        {
            InitializeComponent();
            this.user_id = id;
        }

        private void getRadioButtonResult()
        {
            foreach (RadioButton rb in panel2.Controls)
            {
                if (rb.Checked)
                {
                    if (rb.Text == "All")
                    {
                        vaiTro = "";
                    }
                    else if (rb.Text == "Quản trị viên")
                    {
                        this.vaiTro = "QTV";
                    }
                    else
                    {
                        this.vaiTro = rb.Text;
                    }

                }
            }
        }

        [Obsolete]
        private void QuanTriVienGUI_Load(object sender, EventArgs e)
        {
            getRadioButtonResult();
            var bindingSource1 = new BindingSource { DataSource = QuanTriVienDAO.Instance.LayDSNhanVien(this.vaiTro) };
            dataGridView1.DataSource = bindingSource1;
            textBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "HOTEN", true, DataSourceUpdateMode.OnValidation));
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SDT", true, DataSourceUpdateMode.OnValidation));
            textBox3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "EMAIL", true, DataSourceUpdateMode.OnValidation));
            textBox4.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MANV", true, DataSourceUpdateMode.OnValidation));
        }

        private void QuanTriVienGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            QuanTriVienDAO.Instance.KhoaTaiKhoan(textBox4.Text);
            refresh();
        }

        [Obsolete]
        private void refresh()
        {
            getRadioButtonResult();
            var bindingSource1 = new BindingSource { DataSource = QuanTriVienDAO.Instance.LayDSNhanVien(this.vaiTro) };
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

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            QuanTriVienDAO.Instance.MoKhoaTaiKhoan(textBox4.Text);
            refresh();
        }

        [Obsolete]
        private void button3_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
