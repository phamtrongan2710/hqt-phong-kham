using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
	public class KhachHang
	{
		public KhachHang(string? maKH, string? hoTen, string? ngaySinh, string? diaChi, string? sdt)
		{
			MaKH = maKH;
			HoTen = hoTen;
			NgaySinh = ngaySinh;
			DiaChi = diaChi;
			Sdt = sdt;
		}

		public string? MaKH { get; set; }
		public string? HoTen { get; set; }
		public string? NgaySinh { get; set; }
		public string? DiaChi { get; set; }
		public string? Sdt { get; set; }
	}
}
