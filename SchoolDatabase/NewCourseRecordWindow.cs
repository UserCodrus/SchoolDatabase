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
	public partial class NewCourseRecordWindow : ChildForm
	{
		List<CourseOffering> offerings = null;

		public NewCourseRecordWindow()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			// Get all of the course offerings for the current faculty member
			offerings = Program.database.GetCurrentCourseOfferings();

			// Add offering data to the table
			DataGridOfferings.Rows.Clear();
			for (int i = 0; i < offerings.Count; ++i)
			{
				// Omit the offering if the student is already registered
				if (!Program.database.CheckRegistration(offerings[i], Program.student))
				{
					DataGridOfferings.Rows.Add(offerings[i].ID, offerings[i].course.Name, offerings[i].instructor.FullName, offerings[i].StartDate, offerings[i].EndDate, offerings[i].Online ? "Yes" : "No");
				}
			}
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ButtonEnroll_Click(object sender, EventArgs e)
		{
			// Get the currently selected offering
			if (DataGridOfferings.SelectedRows.Count == 1)
			{
				// Get the id column of the selected row
				int id = (int)DataGridOfferings.Rows[DataGridOfferings.SelectedRows[0].Index].Cells[0].Value;
				CourseOffering offering = null;

				// Find an offering with a matching id
				for (int i = 0; i < offerings.Count; ++i)
				{
					if (offerings[i].ID == id)
					{
						offering = offerings[i];
						break;
					}
				}

				// Register the course
				Program.database.RegisterCourseRecord(offering, Program.student);

				parent.ChildUpdate();
				Close();
			}
		}
	}
}
