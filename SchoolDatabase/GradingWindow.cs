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
	partial class GradingWindow : ChildForm
	{
		private CourseOffering offering = null;
		List<StudentCourseRecord> records = null;

		public GradingWindow(CourseOffering _offering)
		{
			InitializeComponent();
			offering = _offering;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (offering == null)
			{
				Close();
			}

			// Put the course name in the window
			Text += offering.course.Name;

			// Load the course records
			LoadRecords();
			SelectionChange(null, null);

			DataGridRecords.SelectionChanged += new EventHandler(SelectionChange);
		}

		private void LoadRecords()
		{
			// Add record data for the course
			records = Program.database.GetCourseRecords(offering);

			// Add the records to the data table
			DataGridRecords.Rows.Clear();
			for (int i = 0; i < records.Count; ++i)
			{
				DataGridRecords.Rows.Add(records[i].ID, records[i].student.FullName, records[i].Grade == -1 ? "N/A" : records[i].Grade.ToString());
			}
		}

		private StudentCourseRecord GetSelected()
		{
			if (DataGridRecords.SelectedRows.Count == 1)
			{
				// Get the id column of the selected row
				int id = (int)DataGridRecords.Rows[DataGridRecords.SelectedRows[0].Index].Cells[0].Value;
				StudentCourseRecord record = null;

				// Find a record with a matching id
				for (int i = 0; i < records.Count; ++i)
				{
					if (records[i].ID == id)
					{
						record = records[i];
						break;
					}
				}

				return record;
			}
			return null;
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ButtonGrade_Click(object sender, EventArgs e)
		{
			StudentCourseRecord selected = GetSelected();

			if (selected != null)
			{
				// Update the grade for the given record
				if (Program.database.UpdateCourseRecord(selected, (int)NumericGrade.Value))
				{
					LoadRecords();
				}
				else
				{
					MessageBox.Show("Error: Unable to update grade entry");
				}
			}
		}

		private void ButtonDrop_Click(object sender, EventArgs e)
		{
			StudentCourseRecord selected = GetSelected();

			if (selected != null)
			{
				DialogResult res = MessageBox.Show("Are you sure you want to remove " + selected.student.FullName + " from this course?", "Alert", MessageBoxButtons.YesNo);
				if (res == DialogResult.Yes)
				{
					// Remove the student from the course
					if (Program.database.DropCourseRecord(selected))
					{
						LoadRecords();
						MessageBox.Show("Student dropped");
					}
					else
					{
						MessageBox.Show("Error: Unable to remove student from course");
					}
				}
			}
		}

		private void SelectionChange(object sender, EventArgs e)
		{
			if (DataGridRecords.SelectedRows.Count == 1)
			{
				// Change the value of the grade box to match selected cells
				string grade = (string)DataGridRecords.Rows[DataGridRecords.SelectedRows[0].Index].Cells[2].Value;

				if (grade != "N/A")
				{
					NumericGrade.Value = Int32.Parse(grade);
				}
				else
				{
					NumericGrade.Value = 0;
				}
			}
		}
	}
}
