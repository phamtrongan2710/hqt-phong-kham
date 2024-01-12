using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace App.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value;
        }
        private DataProvider() { }

        string connStr = "Server=localhost; Database=phongkham; Integrated Security=True;";

        [Obsolete]
        // Dùng cho SELECT (trả về dạng bảng)
        public DataTable ExecuteQuery(string query, object[]? parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
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
                SqlDataAdapter adapter = new SqlDataAdapter(command);
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
        // Dùng cho INSERT, UPDATE, DELETE (trả về số dòng thực thi thành công) 
        public int ExecuteNonQuery(string query, object[]? parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
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
    }
}
