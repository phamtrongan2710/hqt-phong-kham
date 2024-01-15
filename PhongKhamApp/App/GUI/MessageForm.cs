namespace App.GUI
{
	public partial class MessageForm : Form
	{
		public MessageForm(string message)
		{
			InitializeComponent();
			label1.Text = message;
		}
	}
}