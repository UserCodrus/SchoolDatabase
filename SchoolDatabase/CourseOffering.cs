using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase
{
	public class CourseOffering
	{
		public readonly Course course;
		public readonly Faculty instructor;
		public readonly DateTime start;
		public readonly DateTime end;

		public int ID { get; }
		public string StartDate { get { return start.ToString("d"); } }
		public string EndDate { get { return end.ToString("d"); } }
		public int Size { get; }
		public bool Online { get; }
		

		public CourseOffering(Course _course, Faculty _instructor, int _id, DateTime _startdate, DateTime _enddate, int _size, bool _online)
		{
			course = _course;
			instructor = _instructor;
			ID = _id;
			start = _startdate;
			end = _enddate;
			Size = _size;
			Online = _online;
		}

		public CourseOffering(Course _course, Faculty _instructor, DateTime _startdate, DateTime _enddate, int _size, bool _online)
		{
			course = _course;
			instructor = _instructor;
			ID = 0;
			start = _startdate;
			end = _enddate;
			Size = _size;
			Online = _online;
		}
	}
}
