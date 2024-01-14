using App.DAO;

namespace App.GUI
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            // username = id
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không thể để trống.");
            }
            else
            {
                if (KhachHangDAO.Instance.KiemTraTonTai(username, password) != "0")
                {
                    this.Hide();
                    KhachHangGUI fKH = new KhachHangGUI(username);
                    fKH.ShowDialog();
                }
                else if (NhanVienDAO.Instance.KiemTraTonTai(username, password) != "0")
                {
                    string role = NhanVienDAO.Instance.LayVaiTro(username);
                    this.Hide();

                    switch (role)
                    {
                        case "Nha sĩ":
                            NhaSiGUI fNS = new NhaSiGUI(username);
                            fNS.ShowDialog();
                            break;
                        case "Nhân viên":
                            NhanVienGUI fNV = new NhanVienGUI();
                            fNV.ShowDialog();
                            break;
                        case "QTV":
                            QuanTriVienGUI fQTV = new QuanTriVienGUI(username);
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

        private void label2_Click(object sender, EventArgs e)
        {
            // dang ky tai khoan
        }

        private void LoginGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
