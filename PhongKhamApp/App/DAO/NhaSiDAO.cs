using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAO
{
    public class NhaSiDAO
    {
        private static NhaSiDAO instance;
        public static NhaSiDAO Instance
        {
            get { if (instance == null) instance = new NhaSiDAO(); return instance; }
            set => instance = value;
        }
        public NhaSiDAO() { }

        [Obsolete]
        public string KiemTraTonTai(string username, string password)
        {
            string query = string.Format("SELECT COUNT(*) " +
                                        "FROM KHACH_HANG " +
                                        $"WHERE MAKH = '{username}' AND MATKHAU = '{password}'");
            return DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
        }

        [Obsolete]
        public string LayVaiTro(string id)
        {
            string query = string.Format($"SELECT VAITRO FROM NHAN_VIEN WHERE MANV = '{id}' AND IS_ACTIVE = 1");
            return DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
        }

        [Obsolete]
        public DataTable LayDSLichHen(string maNS)
        {
            string query = string.Format($"SELECT * FROM LICH_HEN WHERE MANHASI = '{maNS}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public int CapNhatLichHen(string procedure, string maLH, string ngayKham, string gioKham, string maNS)
        {
            string query = string.Format($"EXEC {procedure} '{maLH}', '{ngayKham}', '{gioKham}', '{maNS}'");
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
