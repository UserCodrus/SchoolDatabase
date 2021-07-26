using System;
using System.Windows.Forms;

namespace SchoolDatabase
{
	public partial class LoginWindow : ParentForm
	{
		public LoginWindow()
		{
			InitializeComponent();
		}

		override protected void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			Program.user = null;
			Program.student = null;
			Program.faculty = null;
		}

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			Program.user = Program.database.Login(UserText.Text, PassText.Text);
			if (Program.user == null)
			{
				MessageBox.Show("Login failed");
				PassText.Text = "";
			}
			else
			{
				// Open the next window
				Program.student = Program.database.GetStudent(Program.user);
				Program.faculty = Program.database.GetFaculty(Program.user);
				OpenWindow(new AdminWindow());
				Close();
			}
		}
	}
}
