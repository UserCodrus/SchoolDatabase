using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase
{
	public class StudentCourseRecord
	{
		public readonly CourseOffering offering = null;
		public readonly Student student = null;
		public readonly DateTime registered;

		public int ID { get; }
		public string RegisterDate { get { return registered.ToString("d"); } }
		public int Grade { get; }

		public StudentCourseRecord(CourseOffering _offering, Student _student, int _id, DateTime _registered, int _grade)
		{
			ID = _id;
			offering = _offering;
			student = _student;
			registered = _registered;
			Grade = _grade;
		}

		public StudentCourseRecord(CourseOffering _offering, Student _student, DateTime _registered, int _grade)
		{
			ID = 0;
			offering = _offering;
			student = _student;
			registered = _registered;
			Grade = _grade;
		}
	}
}
