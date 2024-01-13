using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
	public class DichVu
	{
		public DichVu(string? maDichVu, string? dichVu, string? giaDichVu)
		{
			MaDV = maDichVu;
			TenDV = dichVu;
			DonGia = FormatGiaDichVu(giaDichVu);
		}

		public string? MaDV { get; set; }
		public string? TenDV { get; set; }
		public string? DonGia { get; set; }

		private string? FormatGiaDichVu(string? giaDichVu)
		{
			if (giaDichVu != null)
			{
				int gia = int.Parse(giaDichVu);
				return gia.ToString("N0").Replace(",", ".");
			}
			return null;
		}
	}
}
