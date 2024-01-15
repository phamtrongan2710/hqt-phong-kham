using App.DAO;

namespace App.GUI
{
	public partial class LoginGUI : Form
	{
		public LoginGUI()
		{
			InitializeComponent();
			passwordTextBox.UseSystemPasswordChar = true;
		}

		[Obsolete]
		private void LoginButton_Click(object sender, EventArgs e)
		{
			// username = id
			string username = this.usernameTextBox.Text;
			string password = this.passwordTextBox.Text;

			if (username == "" || password == "")
			{
				MessageBox.Show("Tài khoản hoặc mật khẩu không thể để trống.");
			}
			else
			{
				if (KhachHangDAO.Instance.KiemTraTonTai(username, password) != "0")
				{
					this.Hide();
					KhachHangGUI fKH = new(username);
					fKH.ShowDialog();
				}
				else if (NhanVienDAO.Instance.KiemTraTonTai(username, password) != "0")
				{
					string role = NhanVienDAO.Instance.LayVaiTro(username);
					this.Hide();

					switch (role)
					{
						case "Nha sĩ":
							NhaSiGUI fNS = new(username);
							fNS.ShowDialog();
							break;

						case "Nhân viên":
							NhanVienGUI fNV = new();
							fNV.ShowDialog();
							break;

						case "QTV":
							QuanTriVienGUI fQTV = new(username);
							fQTV.ShowDialog();
							break;

						default:
							MessageBox.Show("Tài khoản hiện không khả dụng.");
							break;
					}
				}
				else
				{
					MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
				}
			}
		}

		private void RegisterLabel_Click(object sender, EventArgs e)
		{
			// dang ky tai khoan
		}

		private void LoginGUI_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}