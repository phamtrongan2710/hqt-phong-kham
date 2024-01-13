using App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public NhanVienDAO() { }

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


		public Dictionary<string, List<DichVu>> ThanhToan(string SDT)
		{
			Dictionary<string, List<DichVu>> result = new Dictionary<string, List<DichVu>>();
			object[] parameter = new object[] { "@SDT", SDT, "@NgayXuat", DateTime.Now };
			SqlDataReader reader = DataProvider.Instance.ExecuteProcedure("TinhTienDichVu", parameter);

			var tongTienDV = "";
			while (reader.Read())
			{
				tongTienDV = reader["TongTienDV"].ToString();
				result.Add(tongTienDV, new List<DichVu>());
			}

			if (reader.NextResult())
			{
				while (reader.Read())
				{
					var maDichVu = reader["MADV"].ToString();
					var dichVu = reader["TENDICHVU"].ToString();
					var giaDichVu = reader["GIADICHVU"].ToString();

					result[tongTienDV].Add(new DichVu(maDichVu, dichVu, giaDichVu));
				}
			}

			reader.Close();
			return result;
		}

		public Dictionary<string, List<DichVu>> ThanhToan_Fix(string SDT)
		{
			Dictionary<string, List<DichVu>> result = new Dictionary<string, List<DichVu>>();
			object[] parameter = new object[] { "@SDT", SDT, "@NgayXuat", DateTime.Now };
			SqlDataReader reader = DataProvider.Instance.ExecuteProcedure("TinhTienDichVu_Fix", parameter);

			var tongTienDV = "";
			while (reader.Read())
			{
				tongTienDV = reader["TongTienDV"].ToString();
				result.Add(tongTienDV, new List<DichVu>());
			}

			if (reader.NextResult())
			{
				while (reader.Read())
				{
					var maDichVu = reader["MADV"].ToString();
					var dichVu = reader["TENDICHVU"].ToString();
					var giaDichVu = reader["GIADICHVU"].ToString();

					result[tongTienDV].Add(new DichVu(maDichVu, dichVu, giaDichVu));
				}
			}

			reader.Close();
			return result;
		}




	}
}
