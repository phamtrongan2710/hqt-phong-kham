using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
