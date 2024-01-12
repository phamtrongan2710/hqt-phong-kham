using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DataTable LayDSNhaSi()
        {
            string query = string.Format("SELECT MANV, HOTEN, SDT, EMAIL FROM NHAN_VIEN WHERE VAITRO = N'Nha sĩ' AND IS_ACTIVE = 1");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public int DatLichHen(string procedure, string ngayKham, string gioKham, string maNS, string maKH)
        {
            string query = string.Format($"EXEC {procedure} '{ngayKham}', '{gioKham}', 'KH', '{maNS}', '{maKH}'");
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public DataTable LayDSLichHen(string maKH)
        {
            string query = string.Format($"SELECT * FROM LICH_HEN WHERE MAKH = '{maKH}'");
            return DataProvider.Instance.ExecuteQuery(query);    
        }
    }
}
