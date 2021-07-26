using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase
{
	public class Field
	{
		public int ID { get; }
		public string Name { get; }

		public Field(int _id, string _name)
		{
			ID = _id;
			Name = _name;
		}

		public Field(string _name)
		{
			ID = 0;
			Name = _name;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
