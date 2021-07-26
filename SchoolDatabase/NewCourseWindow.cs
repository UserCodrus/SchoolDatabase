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
	public partial class NewCourseWindow : ChildForm
	{
		public NewCourseWindow()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			// Get all the fields in the database
			List<Field> fields = Program.database.GetFields();

			// Populate the checklist with fields
			CheckList.Items.Clear();
			if (fields != null)
			{
				for (int i = 0; i < fields.Count; ++i)
				{
					CheckList.Items.Add(fields[i]);
				}
			}
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ButtonAccept_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBoxName.Text))
			{
				MessageBox.Show("Please enter a name for the course");
			}
			else
			{
				// Create a course object
				List<Field> fields = new List<Field>();
				for (int i = 0; i < CheckList.CheckedItems.Count; ++i)
				{
					fields.Add((Field)CheckList.CheckedItems[i]);
				}
				Course course = new Course(TextBoxName.Text, TextBoxDescription.Text, fields);

				// Add the course to the database
				if (Program.database.AddCourse(course))
				{
					MessageBox.Show("New course added");
					parent.ChildUpdate();
					Close();
				}
				else
				{
					MessageBox.Show("Error: Unable to add new course, please try again");
				}
			}
		}
	}
}
