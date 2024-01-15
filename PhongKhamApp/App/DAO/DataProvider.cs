// Ignore Spelling: DAO

using System.Data;
using System.Data.SqlClient;

namespace App.DAO
{
	public class DataProvider
	{
		private static DataProvider instance;

		public static DataProvider Instance
		{
			get { instance ??= new DataProvider(); return DataProvider.instance; }
			private set => instance = value;
		}

		private DataProvider()
		{ }

		private string connStr = "Server=LAPTOP-8U6V04UM\\SQLEXPRESS; Database=phongkham; Integrated Security=True;";

		[Obsolete]
		public DataTable ExecuteQuery(string query, object[]? parameter = null)
		{
			DataTable data = new();
			using (SqlConnection connection = new(connStr))
			{
				connection.Open();
				SqlCommand command = new(query, connection);
				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							command.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}
				SqlDataAdapter adapter = new(command);
				try
				{
					adapter.Fill(data);
				}
				catch (Exception)
				{
					connection.Close();
					return new DataTable();
				}
				connection.Close();
			}
			return data;
		}

		[Obsolete]
		public int ExecuteNonQuery(string query, object[]? parameter = null)
		{
			int data = 0;
			using (SqlConnection connection = new(connStr))
			{
				connection.Open();
				SqlCommand command = new(query, connection);
				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							command.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}
				// setting to don't break when get user_unhandled
				try
				{
					data = command.ExecuteNonQuery();
				}
				catch (SqlException ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					connection.Close();
				}
			}
			return data;
		}

		public SqlDataReader ExecuteProcedure(string procedureName, object[] parameter = null)
		{
			SqlConnection connection = new SqlConnection(connStr);
			connection.Open();
			SqlCommand command = new SqlCommand(procedureName, connection);
			command.CommandType = CommandType.StoredProcedure;
			if (parameter != null)
			{
				int i = 0;
				foreach (object item in parameter)
				{
					if (item.ToString().Contains('@'))
					{
						command.Parameters.AddWithValue(item.ToString(), parameter[i + 1]);
						i += 2;
					}
				}
			}
			SqlDataReader reader = command.ExecuteReader();
			return reader;
		}
	}
}