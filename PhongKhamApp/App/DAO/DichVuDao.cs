using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAO
{
	public class DichVuDao
	{
		private static DichVuDao instance;
		public static DichVuDao Instance
		{
			get { if (instance == null) instance = new DichVuDao(); return instance; }
			set => instance = value;
		}
		public DichVuDao() { }

		[Obsolete]
		public List<DichVu> LayDanhSachDichVu()
		{
			string query = string.Format($"SELECT * FROM DICH_VU");
			var table = DataProvider.Instance.ExecuteQuery(query);
			List<DichVu> result = new List<DichVu>();

			foreach (System.Data.DataRow row in table.Rows)
			{
				result.Add(new DichVu(row["MADV"].ToString(), row["TENDICHVU"].ToString(), row["GIADICHVU"].ToString()));
			}
			return result;
		}

		[Obsolete]
		public bool SuaDichVu(string maDV, string tenDV, int giaDV)
		{
			string query = string.Format($"UPDATE DICH_VU SET TENDICHVU = N'{tenDV}', GIADICHVU = {giaDV} WHERE MADV = '{maDV}'");
			int result = DataProvider.Instance.ExecuteNonQuery(query);
			return result > 0;
		}
	}
}
