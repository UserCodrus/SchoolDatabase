using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDatabase
{
	public partial class AdminWindow : ParentForm
	{
		List<CourseOffering> offerings = null;
		List<User> users = null;
		int classes = 0;

		public AdminWindow()
		{
			InitializeComponent();
		}

		public override void ChildUpdate()
		{
			// Reload tabs when prompted by child windows
			LoadCourseData();
			LoadUserData();
			LoadOfferingData();
			LoadCourseRecords();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			// Add event handlers
			ListBoxCourses.SelectedValueChanged += new EventHandler(ListBoxCourses_SelectionValueChanged);

			// Make sure a user is logged in
			if (Program.user == null)
			{
				MessageBox.Show("Error: Please log in");
				OpenWindow(new LoginWindow());
				Close();
			}

			// Hide tabs that the user doesn't have the privileges to use
			if (Program.faculty == null)
			{
				TabController.TabPages.Remove(TabCourses);
				TabController.TabPages.Remove(TabUsers);
				TabController.TabPages.Remove(TabOfferings);
			}
			else
			{
				if (!Program.faculty.Admin)
				{
					TabController.TabPages.Remove(TabCourses);
					TabController.TabPages.Remove(TabUsers);
				}
			}
			if (Program.student == null)
			{
				TabController.TabPages.Remove(TabEnrollment);
			}

			// Load data from the database
			LoadCourseData();
			LoadUserData();
			LoadOfferingData();
			LoadCourseRecords();

			// Load user profile data
			LabelProfileName.Text = Program.user.FirstName + " " + Program.user.LastName;
			LabelProfileUser.Text = Program.user.UserName;
			LabelProfileEmail.Text = Program.user.Email;

			if (Program.faculty != null)
			{
				if (Program.faculty.Admin)
				{
					LabelProfileStatus.Text = "Administrator";
				}
				else
				{
					LabelProfileStatus.Text = "Professor";
				}
			}
			else if (Program.student != null)
			{
				if (Program.student.Undergrad)
				{
					LabelProfileStatus.Text = "Student";
				}
				else
				{
					LabelProfileStatus.Text = "Graduate Student";
				}
			}
			else
			{
				LabelProfileStatus.Text = "User";
			}
		}

		private void LoadCourseData()
		{
			if (TabController.TabPages.Contains(TabCourses))
			{
				// Get the courses in the database
				List<Course> courses = Program.database.GetCourses();

				// Add the courses to the list box
				ListBoxCourses.Items.Clear();
				if (courses != null)
				{
					for (int i = 0; i < courses.Count; ++i)
					{
						ListBoxCourses.Items.Add(courses[i]);
					}
				}
			}
		}

		private void LoadUserData()
		{
			if (TabController.TabPages.Contains(TabUsers))
			{
				// Get users from the database
				users = Program.database.GetUsers();

				// Add the user data to the grid
				DataGridUsers.Rows.Clear();
				for (int i = 0; i < users.Count; ++i)
				{
					string status = "N/A";

					// Check to see if the user is a student or faculty member
					Student student = Program.database.GetStudent(users[i]);
					if (student != null)
					{
						if (student.Undergrad)
						{
							status = "Undergrad";
						}
						else
						{
							status = "Graduate";
						}
					}
					Faculty faculty = Program.database.GetFaculty(users[i]);
					if (faculty != null)
					{
						if (faculty.Admin)
						{
							status = "Admin";
						}
						else
						{
							status = "Professor";
						}
					}

					DataGridUsers.Rows.Add(users[i].ID, users[i].LastName, users[i].FirstName, status, users[i].Active ? "Yes" : "No", users[i].UserName, users[i].Email);
				}
			}
		}

		private void LoadOfferingData()
		{
			if (TabController.TabPages.Contains(TabOfferings))
			{
				if (Program.faculty != null)
				{
					// Get all of the course offerings for the current faculty member
					offerings = Program.database.GetCourseOfferings(Program.faculty);

					// Add offering data to the table
					DataGridOfferings.Rows.Clear();
					for (int i = 0; i < offerings.Count; ++i)
					{
						DataGridOfferings.Rows.Add(offerings[i].ID, offerings[i].course.Name, offerings[i].StartDate, offerings[i].EndDate, offerings[i].Size.ToString(), offerings[i].Online ? "Yes" : "No");
					}
				}
			}
		}

		private void LoadCourseRecords()
		{
			if (TabController.TabPages.Contains(TabEnrollment))
			{
				if (Program.student != null)
				{
					// Get all of the records for the student logged in
					List<StudentCourseRecord> records = Program.database.GetCourseRecords(Program.student);

					// Add the records to the data table
					DataGridRecords.Rows.Clear();
					for (int i = 0; i < records.Count; ++i)
					{
						DataGridRecords.Rows.Add(records[i].ID, records[i].offering.course.Name, records[i].offering.instructor.FullName, records[i].RegisterDate, records[i].offering.Online ? "Yes" : "No", records[i].Grade == -1 ? "N/A" : records[i].Grade.ToString());
					}

					// Calculate the student's GPA
					float gpa_value = Program.database.GetGPA(Program.student);
					string gpa = gpa_value == -1.0f ? "N/A" : gpa_value.ToString();
					LabelGPA.Text = "GPA: " +  gpa;

					// Get the number of active classes the student is enrolled in
					classes = 0;
					foreach (StudentCourseRecord record in records)
					{
						if (record.offering.end > DateTime.Today)
						{
							classes++;
						}
					}
				}
			}
		}

		private void ButtonLogOut_Click_1(object sender, EventArgs e)
		{
			OpenWindow(new LoginWindow());
			Close();
		}

		private void ButtonNew_Click(object sender, EventArgs e)
		{
			OpenWindow(new NewCourseWindow());
		}

		private void ButtonNewUser_Click(object sender, EventArgs e)
		{
			OpenWindow(new NewUserWindow());
		}

		private void ButtonNewOffering_Click(object sender, EventArgs e)
		{
			OpenWindow(new NewOfferingWindow());
		}

		private void ButtonEnroll_Click(object sender, EventArgs e)
		{
			// Ensure that the user hasn't enrolled in too many classes
			if (classes >= 3)
			{
				float gpa = Program.database.GetGPA(Program.student);
				if (gpa < 3.0)
				{
					MessageBox.Show("You cannot enroll in more than three courses with a GPA less than 3.0");
					return;
				}
			}
			if (classes >= 6)
			{
				MessageBox.Show("You are enrolled in the maximum number of courses");
				return;
			}

			OpenWindow(new NewCourseRecordWindow());
		}

		private void ButtonUserActivate_Click(object sender, EventArgs e)
		{
			// Get the id column of the selected row
			int id = (int)DataGridUsers.Rows[DataGridUsers.SelectedRows[0].Index].Cells[0].Value;
			User user = null;

			// Find an offering with a matching id
			for (int i = 0; i < users.Count; ++i)
			{
				if (users[i].ID == id)
				{
					user = users[i];
					break;
				}
			}

			// Activate or deactivate the user
			if (user != null)
			{
				if (user.ID != Program.user.ID)
				{
					Program.database.UpdateUser(user, !user.Active);
					LoadUserData();
				}
				else
				{
					MessageBox.Show("Error: Cannot change the status of the current user");
				}
			}
		}

		private void ButtonGrades_Click(object sender, EventArgs e)
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

			// Open the grading window with the selected offering
			if (offering != null)
			{
				OpenWindow(new GradingWindow(offering));
			}
		}

		private void ListBoxCourses_SelectionValueChanged(object sender, EventArgs e)
		{
			// Change the description when a course is selected
			if (ListBoxCourses.SelectedIndex != -1)
			{
				LabelDescription.Text = ((Course)ListBoxCourses.SelectedItem).Description;
				if (string.IsNullOrEmpty(LabelDescription.Text))
				{
					LabelDescription.Text = "No description available.";
				}
				LabelFields.Text = ((Course)ListBoxCourses.SelectedItem).Fields;
				if (string.IsNullOrEmpty(LabelFields.Text))
				{
					LabelDescription.Text = "None";
				}
			}
		}
	}
}
