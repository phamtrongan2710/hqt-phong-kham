using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAO
{
    internal class QuanTriVienDAO
    {
        private static QuanTriVienDAO instance;
        public static QuanTriVienDAO Instance
        {
            get { if (instance == null) instance = new QuanTriVienDAO(); return instance; }
            set => instance = value;
        }
        public QuanTriVienDAO() { }

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
        public DataTable LayDSNhanVien(string vaiTro)
        {
            string query = "";
            if (vaiTro == "")
            {
                query = string.Format($"SELECT * FROM NHAN_VIEN");
            }
            else
            {
                query = string.Format($"SELECT * FROM NHAN_VIEN WHERE VAITRO = N'{vaiTro}'");
            }
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public int KhoaTaiKhoan(string maNV)
        {
            string query = string.Format($"EXEC qtv_khoaTaiKhoan '{maNV}'");
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public int MoKhoaTaiKhoan(string maNV)
        {
            string query = string.Format($"UPDATE NHAN_VIEN SET IS_ACTIVE = 1 WHERE MANV = '{maNV}'");
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
