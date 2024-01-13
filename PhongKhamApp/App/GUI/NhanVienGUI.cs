using App.DAO;
using App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.GUI
{
	public partial class NhanVienGUI : Form
	{
		KhachHang khachHang;
		public NhanVienGUI()
		{
			InitializeComponent();
		}

		private void NhanVienGUI_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			groupBox1.Visible = false;

			string sdt = textBox_sdt.Text;
			khachHang = KhachHangDAO.Instance.LayKhachHang(sdt);
			if (khachHang == null)
			{
				MessageBox.Show("Không tìm thấy khách hàng");
				return;
			}
			label_ho_va_ten.Text = khachHang.HoTen;
			label_ngay_sinh.Text = khachHang.NgaySinh;
			label_diachi.Text = khachHang.DiaChi;
			label_sdt.Text = khachHang.Sdt;
			groupBox1.Visible = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string sdt = textBox_sdt.Text;
			Dictionary<string, List<DichVu>> result;
			if (checkBox_fix.Checked)
			{
				result = NhanVienDAO.Instance.ThanhToan_Fix(sdt);
			}
			else
			{
				result = NhanVienDAO.Instance.ThanhToan(sdt);
			}
			 
			HoaDonGui hoaDon = new HoaDonGui(result, khachHang);
			this.Hide();
			hoaDon.ShowDialog();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
