using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase
{
	public class Faculty
	{
		public readonly User user;
		protected bool admin;

		public bool Admin { get { return admin; } }
		public string FullName { get { return user.FirstName + " " + user.LastName; } }

		public Faculty(User _user, bool _admin = false)
		{
			user = _user;
			admin = _admin;
		}
	}
}
