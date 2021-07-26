using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDatabase
{
	public partial class NewUserWindow : ChildForm
	{
		public NewUserWindow()
		{
			InitializeComponent();
		}

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			// Create a user and verify its information
			User user = new User(TextFName.Text, TextLName.Text, TextEmail.Text, TextUser.Text);
			if (!user.IsValid())
			{
				MessageBox.Show("Please complete all fields");
				return;
			}

			// Ensure that a valid password was entered
			if (String.IsNullOrEmpty(TextPassword.Text))
			{
				MessageBox.Show("Please enter a password");
				return;
			}
			if (!TextPassword.Text.Equals(TextPasswordConfirm.Text))
			{
				MessageBox.Show("The passwords entered do not match, please try again");
				return;
			}

			// Add the user to the system
			bool success = false;
			if (Radio1.Checked)
			{
				// Add a student
				Student student = new Student(user, CheckBox.Checked);
				success = Program.database.NewUser(student, TextPassword.Text);
			}
			else
			{
				// Add a faculty member
				Faculty faculty = new Faculty(user, CheckBox.Checked);
				success = Program.database.NewUser(faculty, TextPassword.Text);
			}

			if (success)
			{
				MessageBox.Show("New user added");
				parent.ChildUpdate();
				Close();
			}
			else
			{
				MessageBox.Show("Error: Unable to add new user, please try again");
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Radio1_CheckedChanged(object sender, EventArgs e)
		{
			if (Radio1.Checked)
			{
				CheckBox.Text = "Undergraduate";
				CheckBox.Checked = true;
			}
		}

		private void Radio2_CheckedChanged(object sender, EventArgs e)
		{
			if (Radio2.Checked)
			{
				CheckBox.Text = "Administrator";
				CheckBox.Checked = false;
			}
		}
	}
}
