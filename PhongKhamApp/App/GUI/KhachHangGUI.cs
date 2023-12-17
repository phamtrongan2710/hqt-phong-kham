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
        public KhachHangGUI(string id)
        {
            InitializeComponent();
        }

        private void KhachHangGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        [Obsolete]
        private void KhachHangGUI_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NhanVienDAO.Instance.LayDSNhaSi();
            textBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "EMAIL", true, DataSourceUpdateMode.Never));
        }

        //[Obsolete]

    }
}
