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
	public partial class NewOfferingWindow : ChildForm
	{
		public NewOfferingWindow()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			// Fill the course list with courses from the database
			List<Course> courses = Program.database.GetCourses();

			ListBoxCourses.Items.Clear();
			if (courses != null)
			{
				for (int i = 0; i < courses.Count; ++i)
				{
					ListBoxCourses.Items.Add(courses[i]);
				}
			}
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			if (ListBoxCourses.SelectedIndex != -1)
			{
				// Create an offering object and add it to the database
				CourseOffering offering = new CourseOffering((Course)ListBoxCourses.SelectedItem, Program.faculty, DateTimeStart.Value, DateTimeEnd.Value, Decimal.ToInt32(NumericSize.Value), CheckBoxOnline.Checked);
				if (Program.database.AddOffering(offering))
				{
					MessageBox.Show("New course offering added");
					parent.ChildUpdate();
					Close();
				}
				else
				{
					MessageBox.Show("Error: Unable to add course offering");
				}
			}
			else
			{
				MessageBox.Show("Please select a course");
			}
		}
	}
}
