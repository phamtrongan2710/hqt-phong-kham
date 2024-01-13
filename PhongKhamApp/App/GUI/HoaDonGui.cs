using App.Model;
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
	public partial class HoaDonGui : Form
	{
		Dictionary<string, List<DichVu>> _thanhToan;
		KhachHang khachHang;
		public HoaDonGui(Dictionary<string, List<DichVu>> thanhToan, KhachHang khachHang)
		{
			_thanhToan = thanhToan;
			InitializeComponent();
			this.khachHang = khachHang;
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void HoaDonGui_Load_1(object sender, EventArgs e)
		{
			TongTienLabel.Text = FormatGiaDichVu(_thanhToan.Keys.ElementAt(0));

			foreach (DichVu dv in _thanhToan.Values.ElementAt(0))
			{
				ListViewItem item = new(dv.MaDV);
				item.SubItems.Add(dv.TenDV);
				item.SubItems.Add(dv.DonGia);
				listView1.Items.Add(item);
			}

			label_ho_va_ten.Text = khachHang.HoTen;
			label_ngay_sinh.Text = khachHang.NgaySinh;
			label_diachi.Text = khachHang.DiaChi;
			label_sdt.Text = khachHang.Sdt;
			label_ngay_thanh_toan.Text = DateTime.Now.ToString("dd/MM/yyyy");


		}

		private string? FormatGiaDichVu(string? giaDichVu)
		{
			if (giaDichVu != null)
			{
				int gia = int.Parse(giaDichVu);
				return gia.ToString("N0").Replace(",", ".");
			}
			return null;
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			NhanVienGUI nhanVienGUI = new NhanVienGUI();
			this.Hide();
			nhanVienGUI.ShowDialog();

		}
	}
}
