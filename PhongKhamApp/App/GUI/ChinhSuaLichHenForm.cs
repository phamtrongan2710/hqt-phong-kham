namespace App.GUI
{
	public partial class ChinhSuaLichHenForm : Form
	{
		public string Date { get; set; } = "";
		public string Time { get; set; } = "";
		public bool XuLyTranhChap { get; set; } = false;

		public ChinhSuaLichHenForm(string name, string initialDate, string initialTime)
		{
			InitializeComponent();

			// Set patient name
			nameLabel.Text = name;

			// Set initial date and time
			DateTextBox.Text = initialDate;
			TimeTextBox.Text = initialTime;
		}

		private void DateTextBox_TextChanged(object sender, EventArgs e)
		{
			Date = DateTextBox.Text;
		}

		private void TimeTextBox_TextChanged(object sender, EventArgs e)
		{
			Time = TimeTextBox.Text;
		}

		private void ConfirmButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void xuLyCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (xuLyCheckbox.Checked)
			{
				XuLyTranhChap = true;
			}
			else
			{
				XuLyTranhChap = false;
			}
		}
	}
}