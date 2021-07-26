using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase
{
	public class User
	{
		public int ID { get; }
		public string FirstName { get; }
		public string LastName { get; }
		public string Email { get; }
		public string UserName { get; }
		public bool Active { get; }

		public User(int _id, string _fname, string _lname, string _email, string _user, bool _active = true)
		{
			ID = _id;
			FirstName = _fname;
			LastName = _lname;
			Email = _email;
			UserName = _user;
			Active = _active;
		}

		public User(string _fname, string _lname, string _email, string _user)
		{
			FirstName = _fname;
			LastName = _lname;
			Email = _email;
			UserName = _user;
			Active = true;
		}

		public bool IsValid()
		{
			return !(string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(UserName));
		}
	}
}
