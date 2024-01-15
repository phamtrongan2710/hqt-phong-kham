using System.Data;

namespace App.DAO
{
	public class NhanVienDAO
	{
		private static NhanVienDAO instance;

		public static NhanVienDAO Instance
		{
			get { if (instance == null) instance = new NhanVienDAO(); return instance; }
			set => instance = value;
		}

		public NhanVienDAO()
		{ }

		[Obsolete]
		public string KiemTraTonTai(string username, string password)
		{
			string query = string.Format("SELECT COUNT(*) " +
										"FROM NHAN_VIEN " +
										$"WHERE MANV = '{username}' AND MATKHAU = '{password}' AND IS_ACTIVE = 1");
			return DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
		}

		[Obsolete]
		public string LayVaiTro(string id)
		{
			string query = string.Format($"SELECT VAITRO FROM NHAN_VIEN WHERE MANV = '{id}' AND IS_ACTIVE = 1");
			return DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
		}

		[Obsolete]
		public DataTable LayDSNhaSi()
		{
			string query = string.Format("SELECT HOTEN, SDT, EMAIL FROM NHAN_VIEN WHERE VAITRO = N'Nha sĩ' AND IS_ACTIVE = 1");
			return DataProvider.Instance.ExecuteQuery(query);
		}

		[Obsolete]
		public DataTable LayDSLichHenCuaNhaSi(string maNhaSi)
		{
			string query = string.Format("SELECT LH.MALICHHEN, KH.HOTEN, KH.SDT, LH.NGAYKHAM, LH.GIOKHAM " +
														"FROM KHACH_HANG KH, LICH_HEN LH " +
														$"WHERE KH.MAKH = LH.MAKH AND LH.MANHASI = '{maNhaSi}'");
			return DataProvider.Instance.ExecuteQuery(query);
		}

		public bool CapNhatLichHen(string maLichHen, string maNhaSi, DateTime gioKhamMoi, bool xuLyTranhChap)
		{
			string procedure = xuLyTranhChap ? "USP_CapNhatLichHen_FIX" : "USP_CapNhatLichHen";
			string query = string.Format($"EXEC {procedure} @MaLichHen = '{maLichHen}', @MaNhaSi = '{maNhaSi}', " +
				$"@GioKhamMoi = '{gioKhamMoi}'");
			var result = DataProvider.Instance.ExecuteNonQuery(query);
			if (result > 0)
			{
				return true;
			}
			return false;
		}
	}
}