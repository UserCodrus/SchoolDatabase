using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase
{
	public class Student
	{
		public readonly User user;
		protected bool undergrad;

		public bool Undergrad { get { return undergrad; } }
		public string FullName { get { return user.FirstName + " " + user.LastName; } }

		public Student(User _user, bool _undergrad = false)
		{
			user = _user;
			undergrad = _undergrad;
		}
	}
}
