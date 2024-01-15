using App.DAO;
using System.Data;

namespace App.GUI
{
	public partial class NhaSiGUI : Form
	{
		public string MaNhaSi { get; set; }
		private DataGridViewRow selectedRow;

		public DataTable DSLichHen { get; set; }

		[Obsolete]
		public NhaSiGUI(string maNhaSi)
		{
			InitializeComponent();
			MaNhaSi = maNhaSi;

			string[] columns = { "ID", "Họ tên", "Số điện thoại", "Ngày khám", "Giờ khám" };

			// Load danh sách lịch hẹn của nha sĩ
			DSLichHen = NhanVienDAO.Instance.LayDSLichHenCuaNhaSi(MaNhaSi);

			// Đặt tên cột cho DSLichHen
			for (int i = 0; i < columns.Length; i++)
			{
				DSLichHen.Columns[i].ColumnName = columns[i];
			}

			LichHenDataList.DataSource = DSLichHen;
			// make LichHenDataList scrollable
			LichHenDataList.ScrollBars = ScrollBars.Vertical;
		}

		private void LichHenDataList_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
			}
		}

		private void LichHenDataList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				try
				{
					LichHenDataList.CurrentCell = LichHenDataList.Rows[e.RowIndex].Cells[e.ColumnIndex];
					LichHenDataList.Rows[e.RowIndex].Selected = true;
					LichHenDataList.Focus();

					selectedRow = LichHenDataList.Rows[e.RowIndex];
				}
				catch (Exception)
				{
					//
				}
			}
		}

		private void NhaSiGUI_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		[Obsolete]
		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Get data from selected row
			var ngayKham = DateTime.Parse(selectedRow.Cells[3].Value.ToString()).ToString("dd/MM/yyyy");
			var gioKham = DateTime.Parse(selectedRow.Cells[4].Value.ToString()).ToString("HH:mm");

			// Show edit form
			using var form = new ChinhSuaLichHenForm(selectedRow.Cells[1].Value.ToString()!, ngayKham!, gioKham!);
			var result = form.ShowDialog();
			if (result == DialogResult.OK)
			{
				// Merge date and time
				DateTime datetime = DateTime.Parse(DateTime.Parse(form.Date).ToString("yyyy-MM-dd") + " "
					+ DateTime.Parse(form.Time).ToString("HH:mm"));

				MessageForm messageForm = new MessageForm("Đã cập nhật");
				messageForm.Show();
				if (!NhanVienDAO.Instance.CapNhatLichHen(selectedRow.Cells[0].Value.ToString()!, MaNhaSi, datetime, form.XuLyTranhChap))
				{
					messageForm.Close();
					MessageBox.Show("Cập nhật thất bại");
				}

				// Load danh sách lịch hẹn của nha sĩ
				DSLichHen = NhanVienDAO.Instance.LayDSLichHenCuaNhaSi(MaNhaSi);

				string[] columns = { "ID", "Họ tên", "Số điện thoại", "Ngày khám", "Giờ khám" };

				// Đặt tên cột cho DSLichHen
				for (int i = 0; i < columns.Length; i++)
				{
					DSLichHen.Columns[i].ColumnName = columns[i];
				}

				LichHenDataList.DataSource = DSLichHen;
				// make LichHenDataList scrollable
				LichHenDataList.ScrollBars = ScrollBars.Vertical;
			}
		}
	}
}