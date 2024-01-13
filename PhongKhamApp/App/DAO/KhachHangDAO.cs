using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Model;
using System.Data;

namespace App.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            set => instance = value;
        }
        public KhachHangDAO() { }

        [Obsolete]
        public string KiemTraTonTai(string username, string password)
        {
            string query = string.Format("SELECT COUNT(*) " +
                                        "FROM KHACH_HANG " +
                                        $"WHERE MAKH = '{username}' AND MATKHAU = '{password}'");
            return DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
        }

        [Obsolete]
        public KhachHang LayKhachHang(string sdt)
        {
			string query = string.Format($"SELECT * FROM KHACH_HANG WHERE SDT = '{sdt}'");
			var table = DataProvider.Instance.ExecuteQuery(query);
			if (table.Rows.Count == 0)
            {
				return null;
			}
			var row = table.Rows[0];
			DateTime ngaySinh = DateTime.Parse(row["NGAYSINH"].ToString());
			string ngaySinhString = ngaySinh.ToShortDateString();
			return new KhachHang(row["MAKH"].ToString(), row["HOTEN"].ToString(), ngaySinhString, row["DIACHI"].ToString(), row["SDT"].ToString());
		}

        [Obsolete]
        public DataTable LayDanhSachThongTinKham(string sdt)
        {
            string query = string.Format($"SELECT LH.NGAYKHAM, NV.HOTEN, DV.TENDICHVU, DV.GIADICHVU\r\nFROM KHACH_HANG KH\r\nJOIN LICH_HEN LH ON KH.MAKH = LH.MAKH\r\nJOIN NHAN_VIEN NV ON LH.MANHASI = NV.MANV\r\nJOIN BENH_AN BA ON LH.MALICHHEN = BA.MALICHHEN\r\nJOIN BENHAN_DICHVU BD ON BA.MABA = BD.MABA\r\nJOIN DICH_VU DV ON BD.MADV = DV.MADV\r\nWHERE SDT = '{sdt}'");
			return DataProvider.Instance.ExecuteQuery(query);

        }

	}
}
