using App.DAO;
using App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.GUI
{
	public partial class QuanTriVienGUI : Form
	{
		public QuanTriVienGUI()
		{
			InitializeComponent();
		}

		private void QuanTriVienGUI_Load(object sender, EventArgs e)
		{
			LoadDanhSachDichVu();
		}

		// load danh sách dịch vụ
		private void LoadDanhSachDichVu()
		{
			dataGridView_dich_vu.Rows.Clear();
			List<DichVu> dichVus = DichVuDao.Instance.LayDanhSachDichVu();
			foreach (DichVu dv in dichVus)
			{
				DataGridViewRow row = (DataGridViewRow)dataGridView_dich_vu.Rows[0].Clone();
				row.Cells[0].Value = dv.MaDV;
				row.Cells[1].Value = dv.TenDV;
				row.Cells[2].Value = dv.DonGia;
				dataGridView_dich_vu.Rows.Add(row);
			}
		}

		private void dataGridView_dich_vu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			textBox_ma_dv.Text = dataGridView_dich_vu.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBox_ten_dv.Text = dataGridView_dich_vu.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBox_gia_dv.Text = dataGridView_dich_vu.Rows[e.RowIndex].Cells[2].Value.ToString();
			textBox_gia_dv.Text = textBox_gia_dv.Text.Replace(".", "");
		}

		private void button_sua_Click(object sender, EventArgs e)
		{
			if (textBox_ma_dv.Text == "")
			{
				MessageBox.Show("Vui lòng chọn dịch vụ cần sửa");
				return;
			}

			if (textBox_ten_dv.Text == "")
			{
				MessageBox.Show("Vui lòng nhập tên dịch vụ");
				return;
			}

			if (textBox_gia_dv.Text == "")
			{
				MessageBox.Show("Vui lòng nhập giá dịch vụ");
				return;
			}

			textBox_gia_dv.Text = textBox_gia_dv.Text.Replace(".", "");

			if (!int.TryParse(textBox_gia_dv.Text, out int n))
			{
				MessageBox.Show("Giá dịch vụ phải là số");
				return;
			}

			string maDV = textBox_ma_dv.Text;
			string tenDV = textBox_ten_dv.Text;
			int giaDV = int.Parse(textBox_gia_dv.Text);

			if (DichVuDao.Instance.SuaDichVu(maDV, tenDV, giaDV))
			{
				MessageBox.Show("Sửa dịch vụ thành công");
				LoadDanhSachDichVu();
			}
			else
			{
				MessageBox.Show("Sửa dịch vụ thất bại");
			}
		}
	}
}
