using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase
{
	public class Course
	{
		public readonly List<Field> fields;

		public int ID { get; }
		public string Name { get; }
		public string Description { get; }
		public string Fields
		{
			get
			{
				// Return a string containing a list of all the fields in the course
				string f = string.Empty;

				if (fields != null)
				{
					if (fields.Count != 0)
					{
						for (int i = 0; i < fields.Count; ++i)
						{
							f += fields[i].Name;
							if ((i + 1) < fields.Count)
							{
								f += ", ";
							}
						}
					}
					else
					{
						f = "None";
					}
				}
				else
				{
					f = "Error";
				}

				return f;
			}
		}

		public Course(int _id, string _name, string _description, List<Field> _fields)
		{
			ID = _id;
			Name = _name;
			Description = _description;
			fields = _fields;
		}

		public Course(int _id, string _name, string _description)
		{
			ID = _id;
			Name = _name;
			Description = _description;
			fields = new List<Field>();
		}

		public Course(string _name, string _description, List<Field> _fields)
		{
			Name = _name;
			Description = _description;
			fields = _fields;
		}

		public Course(string _name, string _description)
		{
			Name = _name;
			Description = _description;
			fields = new List<Field>();
		}

		public void AddField(Field field)
		{
			fields.Add(field);
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
