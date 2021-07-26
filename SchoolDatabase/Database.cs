using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SchoolDatabase
{
	class Database
	{
		private string name = string.Empty;					// The name of the database
		private string connection_string = string.Empty;	// The connection string used to connect to the database;
		const int salt_size = 16;							// The number of bytes in password salts
		const int hash_size = 32;							// The number of bytes in password hashes
		const bool debug = true;

		public Database(string _name)
		{
			name = _name;
		}

		// Convert a DateTime to an SQL compatible string
		public string SQLDate(DateTime time)
		{
			return time.ToString("yyyyMMdd");
		}

		// Create the connection string for the database
		public bool Connect(string user, string password, bool ssl = true)
		{
			// Create the connection string
			if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
			{
				return false;
			}
			MySqlConnectionStringBuilder con_str = new MySqlConnectionStringBuilder();
			con_str.Database = name;
			con_str.UserID = user;
			con_str.Password = password;
			if (!ssl)
			{
				con_str.SslMode = MySqlSslMode.None;
			}
			connection_string = con_str.ToString();

			return true;
		}

		// Add a new user to the database
		public bool NewUser(User user, string password)
		{
			// Ensure that no bad data was provided
			if (!user.IsValid() || string.IsNullOrEmpty(password))
			{
				return false;
			}

			// Hash and salt the password provided
			byte[] salt = new byte[salt_size];
			new RNGCryptoServiceProvider().GetBytes(salt);
			byte[] hash = new Rfc2898DeriveBytes(password, salt).GetBytes(hash_size);

			// Convert the hash and salt to strings
			string hash_string = Convert.ToBase64String(hash);
			string salt_string = Convert.ToBase64String(salt);

			// Create the query
			int result = 0;

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Execute the query
					MySqlCommand cmd = new MySqlCommand("insert into Users(firstname, lastname, email, username, hash, salt, active) values(@FName, @LName, @Email, @Username, @Hash, @Salt, true);", connection);
					cmd.Parameters.AddWithValue("@FName", user.FirstName);
					cmd.Parameters.AddWithValue("@LName", user.LastName);
					cmd.Parameters.AddWithValue("@Email", user.Email);
					cmd.Parameters.AddWithValue("@Username", user.UserName);
					cmd.Parameters.AddWithValue("@Hash", hash_string);
					cmd.Parameters.AddWithValue("@Salt", salt_string);
					result = cmd.ExecuteNonQuery();
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return false;
			}

			// Check to see if the database was updated
			if (result > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// Add a student to the database
		public bool NewUser(Student student, string password)
		{
			// Add a user login first
			if (NewUser(student.user, password))
			{
				// Register the user as a student
				int id = 0;

				try
				{
					using (MySqlConnection connection = new MySqlConnection(connection_string))
					{
						connection.Open();

						MySqlCommand cmd = new MySqlCommand("select id from Users where username=@Name;", connection);
						cmd.Parameters.AddWithValue("@Name", student.user.UserName);
						using (MySqlDataReader reader = cmd.ExecuteReader())
						{
							// Get the id of the user we created
							if (reader.Read())
							{
								id = reader.GetInt32(0);
							}
						}

						// Create the student entry in the database
						if (id > 0)
						{
							int result = 0;

							// Execute the query
							cmd = new MySqlCommand("insert into Students (id, undergrad) values (@ID, @Undergrad);", connection);
							cmd.Parameters.AddWithValue("@ID", id);
							cmd.Parameters.AddWithValue("@Undergrad", student.Undergrad ? 1 : 0);
							result = cmd.ExecuteNonQuery();


							// Check to see if the database was updated
							if (result > 0)
							{
								return true;
							}
							else
							{
								return false;
							}
						}
						else
						{
							return false;
						}
					}
				}
				catch (MySqlException e)
				{
					if (debug)
					{
						MessageBox.Show(e.ToString());
					}
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		// Add a faculty member to the database
		public bool NewUser(Faculty faculty, string password)
		{
			// Add a user login first
			if (NewUser(faculty.user, password))
			{
				// Register the user as a faculty member
				int id = 0;

				try
				{
					using (MySqlConnection connection = new MySqlConnection(connection_string))
					{
						connection.Open();

						MySqlCommand cmd = new MySqlCommand("select id from Users where username=@Name;", connection);
						cmd.Parameters.AddWithValue("@Name", faculty.user.UserName);
						using (MySqlDataReader reader = cmd.ExecuteReader())
						{
							// Get the id of the user we created
							if (reader.Read())
							{
								id = reader.GetInt32(0);
							}
						}

						// Create the faculty member entry in the database
						if (id > 0)
						{
							int result = 0;


							// Execute the query
							cmd = new MySqlCommand("insert into Faculty (id, administrator) values (@ID, @Admin);", connection);
							cmd.Parameters.AddWithValue("@ID", id);
							cmd.Parameters.AddWithValue("@Admin", faculty.Admin ? 1 : 0);
							result = cmd.ExecuteNonQuery();


							// Check to see if the database was updated
							if (result > 0)
							{
								return true;
							}
							else
							{
								return false;
							}
						}
						else
						{
							return false;
						}
					}
				}
				catch (MySqlException e)
				{
					if (debug)
					{
						MessageBox.Show(e.ToString());
					}
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		// Change the activation status of a user
		public bool UpdateUser(User user, bool active)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Update the grade entry
					MySqlCommand cmd = new MySqlCommand("update Users set active = @Active where id = @Id;", connection);
					cmd.Parameters.AddWithValue("@Active", active);
					cmd.Parameters.AddWithValue("@Id", user.ID);
					cmd.ExecuteNonQuery();

					return true;
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return false;
			}
		}

		// Retrieve all users in the database
		public List<User> GetUsers()
		{
			List<User> users = null;

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Get the users from the database
					MySqlCommand cmd = new MySqlCommand("select id, firstname, lastname, email, username, active from Users;", connection);
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						users = new List<User>();
						while (reader.Read())
						{
							users.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5)));
						}
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return null;
			}

			return users;
		}

		// Retrieve a user by id
		public User GetUser(int id)
		{
			User user = null;

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Get the users from the database
					MySqlCommand cmd = new MySqlCommand("select id, firstname, lastname, email, username, active from Users where id=@Id;", connection);
					cmd.Parameters.AddWithValue("@Id", id);

					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5));
						}
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return null;
			}

			return user;
		}

		// Get a student object from the database
		public Student GetStudent(User user)
		{
			Student student = null;

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Try to get a student record from the database
					MySqlCommand cmd = new MySqlCommand("select undergrad from Students where id=@ID;", connection);
					cmd.Parameters.AddWithValue("@ID", user.ID);

					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							// Add the data to an object
							student = new Student(user, reader.GetBoolean(0));
						}
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return null;
			}

			return student;
		}

		// Get a faculty object from the database
		public Faculty GetFaculty(User user)
		{
			Faculty faculty = null;

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Try to get a faculty record from the database
					MySqlCommand cmd = new MySqlCommand("select administrator from Faculty where id=@ID;", connection);
					cmd.Parameters.AddWithValue("@ID", user.ID);

					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							// Add the data to an object
							faculty = new Faculty(user, reader.GetBoolean(0));
						}
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return null;
			}

			return faculty;
		}

		// Retrieve all of the fields available in the database
		public List<Field> GetFields()
		{
			List<Field> fields = null;

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Get the fields from the database
					MySqlCommand cmd = new MySqlCommand("select * from Fields;", connection);
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						fields = new List<Field>();
						while (reader.Read())
						{
							fields.Add(new Field(reader.GetInt32(0), reader.GetString(1)));
						}
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return null;
			}

			return fields;
		}
		
		// Retrieve all of the courses in the database
		public List<Course> GetCourses()
		{
			List<Course> courses = null;

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Get the list of courses
					MySqlCommand cmd = new MySqlCommand("select * from Courses;", connection);
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						// Fill the course array with the database data
						courses = new List<Course>();
						while (reader.Read())
						{
							courses.Add(new Course(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
						}
					}

					if (courses != null)
					{
						// Add field data for each course
						cmd = new MySqlCommand("select Fields.id, Fields.name from ((Fields inner join CourseField on Fields.id = CourseField.field) inner join Courses on Courses.id = CourseField.course) where Courses.id = @ID;", connection);
						cmd.Parameters.Add("@ID", MySqlDbType.Int32);
						cmd.Prepare();

						for (int i = 0; i < courses.Count; ++i)
						{
							// Retrieve the relevant fields for each course from the database
							cmd.Parameters["@ID"].Value = courses[i].ID;
							using (MySqlDataReader reader = cmd.ExecuteReader())
							{
								while (reader.Read())
								{
									courses[i].AddField(new Field(reader.GetInt32(0), reader.GetString(1)));
								}
							}
						}
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return null;
			}

			return courses;
		}
		
		// Get a course by id
		public Course GetCourse(int id)
		{
			Course course = null;

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Get a course from the database with a matching id
					MySqlCommand cmd = new MySqlCommand("select id, name, description from Courses where id=@Id;", connection);
					cmd.Parameters.AddWithValue("@Id", id);

					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							course = new Course(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
						}
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return null;
			}

			return course;
		}

		// Remove a course from the database
		public bool RemoveCourse(Course course)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Delete field assignments related to the course
					MySqlCommand cmd = new MySqlCommand("delete from CourseField where course=@id;", connection);
					cmd.Parameters.AddWithValue("@id", course.ID);
					cmd.ExecuteNonQuery();

					// Delete course offerings related to the course
					cmd = new MySqlCommand("delete from CourseOfferings where course=@id;", connection);
					cmd.Parameters.AddWithValue("@id", course.ID);
					cmd.ExecuteNonQuery();

					// Delete the course
					cmd = new MySqlCommand("delete from Courses where id=@id;", connection);
					cmd.Parameters.AddWithValue("@id", course.ID);
					cmd.ExecuteNonQuery();

					return true;
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return false;
			}
		}

		// Add a course to the database
		public bool AddCourse(Course course)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Add the course to the database
					MySqlCommand cmd = new MySqlCommand("insert into Courses (name, description) values (@Name, @Desc);", connection);
					cmd.Parameters.AddWithValue("@Name", course.Name);
					cmd.Parameters.AddWithValue("@Desc", course.Description);
					cmd.ExecuteNonQuery();

					if (course.fields.Count == 0)
					{
						// If no fields are present, we are done
						return true;
					}

					// Get the id of the newly added course
					cmd = new MySqlCommand("select id from Courses where name=@Name;", connection);
					cmd.Parameters.AddWithValue("@Name", course.Name);

					int id = 0;
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							id = reader.GetInt32(0);
						}
					}

					if (id == 0)
					{
						return false;
					}

					// Add the fields for the course to the database
					cmd = new MySqlCommand("insert into CourseField (course, field) values (@Course, @Field);", connection);
					cmd.Parameters.AddWithValue("@Course", id);
					cmd.Parameters.Add("@Field", MySqlDbType.Int32);
					cmd.Prepare();

					for (int i = 0; i < course.fields.Count; ++i)
					{
						cmd.Parameters["@Field"].Value = course.fields[i].ID;
						cmd.ExecuteNonQuery();
					}

					return true;
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return false;
			}
		}

		// Get all course offerings in the database that are not expired
		public List<CourseOffering> GetCurrentCourseOfferings()
		{
			List<CourseOffering> offerings = null;

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Get the course offerings and associated data from the database
					MySqlCommand cmd = new MySqlCommand("select Courses.id, Courses.name, Courses.description, " +
						"CourseOfferings.id, CourseOfferings.startdate, CourseOfferings.enddate, CourseOfferings.classsize, CourseOfferings.onlineclass, " +
						"Users.id, Users.firstname, Users.lastname, Users.email, Users.username, " +
						"Faculty.administrator " +
						"from (((CourseOfferings inner join Courses on CourseOfferings.course = Courses.id) inner join Faculty on CourseOfferings.instructor = Faculty.id) inner join Users on Faculty.id = Users.id) where CourseOfferings.enddate > CURDATE();", connection);

					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						offerings = new List<CourseOffering>();

						Course course;
						Faculty faculty;
						User user;

						while (reader.Read())
						{
							// Create data associated with the offering
							course = new Course(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
							user = new User(reader.GetInt32(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12));
							faculty = new Faculty(user, reader.GetBoolean(13));

							// Add the offering to the list
							offerings.Add(new CourseOffering(course, faculty, reader.GetInt32(3), reader.GetDateTime(4), reader.GetDateTime(5), reader.GetInt32(6), reader.GetBoolean(7)));
						}
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return null;
			}

			return offerings;
		}

		// Get all course offerings for a particular faculty member
		public List<CourseOffering> GetCourseOfferings(Faculty faculty)
		{
			List<CourseOffering> offerings = null;

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Get course and offering data for every course offering the faculty member teaches
					MySqlCommand cmd = new MySqlCommand("select Courses.id, Courses.name, Courses.description, CourseOfferings.id, CourseOfferings.startdate, CourseOfferings.enddate, CourseOfferings.classsize, CourseOfferings.onlineclass from CourseOfferings inner join Courses on CourseOfferings.course = Courses.id where instructor=@Id;", connection);
					cmd.Parameters.AddWithValue("@Id", faculty.user.ID);

					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						offerings = new List<CourseOffering>();
						Course course;
						while (reader.Read())
						{
							// Extract course and course offering data
							course = new Course(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
							offerings.Add(new CourseOffering(course, faculty, reader.GetInt32(3), reader.GetDateTime(4), reader.GetDateTime(5), reader.GetInt32(6), reader.GetBoolean(7)));
						}
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return null;
			}

			return offerings;
		}

		// Add a new course offering to the database
		public bool AddOffering(CourseOffering offering)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Add the offering to the database
					MySqlCommand cmd = new MySqlCommand("insert into CourseOfferings (course, instructor, startdate, enddate, classsize, onlineclass) values (@Course, @Instructor, @Start, @End, @Size, @Online);", connection);
					cmd.Parameters.AddWithValue("@Course", offering.course.ID);
					cmd.Parameters.AddWithValue("@Instructor", offering.instructor.user.ID);
					cmd.Parameters.AddWithValue("@Start", SQLDate(offering.start));
					cmd.Parameters.AddWithValue("@End", SQLDate(offering.end));
					cmd.Parameters.AddWithValue("@Size", offering.Size);
					cmd.Parameters.AddWithValue("@Online", offering.Online);
					cmd.ExecuteNonQuery();
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return false;
			}

			return true;
		}

		// Get all the student course records from the database for a given student
		public List<StudentCourseRecord> GetCourseRecords(Student student)
		{
			List<StudentCourseRecord> records = null;

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Get the records and associated information from the database
					MySqlCommand cmd = new MySqlCommand("select Courses.id, Courses.name, Courses.description, " +
						"CourseOfferings.id, CourseOfferings.startdate, CourseOfferings.enddate, CourseOfferings.classsize, CourseOfferings.onlineclass, " +
						"Users.id, Users.firstname, Users.lastname, Users.email, Users.username, " +
						"Faculty.administrator, " +
						"StudentCourseRecords.id, StudentCourseRecords.registration, StudentCourseRecords.grade " +
						"from ((((StudentCourseRecords inner join CourseOfferings on StudentCourseRecords.offering = CourseOfferings.id) inner join Courses on CourseOfferings.course = Courses.id) inner join Faculty on CourseOfferings.instructor = Faculty.id) inner join Users on Faculty.id = Users.id) where StudentCourseRecords.student=@Id;", connection);
					cmd.Parameters.AddWithValue("@Id", student.user.ID);

					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						records = new List<StudentCourseRecord>();

						Course course;
						User user;
						Faculty faculty;
						CourseOffering offering;

						while (reader.Read())
						{
							// Create data for the course offering
							course = new Course(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
							user = new User(reader.GetInt32(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12));
							faculty = new Faculty(user, reader.GetBoolean(13));
							offering = new CourseOffering(course, faculty, reader.GetInt32(3), reader.GetDateTime(4), reader.GetDateTime(5), reader.GetInt32(6), reader.GetBoolean(7));

							int grade = -1;
							if (!reader.IsDBNull(16))
							{
								grade = reader.GetInt32(16);
							}

							// Add the student course record to the list
							records.Add(new StudentCourseRecord(offering, student, reader.GetInt32(14), reader.GetDateTime(15), grade));
						}
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return null;
			}

			return records;
		}

		// Get all the student course records from the database for a given offering
		public List<StudentCourseRecord> GetCourseRecords(CourseOffering offering)
		{
			List<StudentCourseRecord> records = null;

			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					MySqlCommand cmd = new MySqlCommand("select StudentCourseRecords.id, StudentCourseRecords.registration, StudentCourseRecords.grade, " +
						"Users.id, Users.firstname, Users.lastname, Users.email, Users.username, " +
						"Students.undergrad " +
						"from ((StudentCourseRecords inner join Students on StudentCourseRecords.student = Students.id) inner join Users on Users.id = Students.id) where StudentCourseRecords.offering = @Id;", connection);
					cmd.Parameters.AddWithValue("@Id", offering.ID);

					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						records = new List<StudentCourseRecord>();

						Student student;
						User user;

						while (reader.Read())
						{
							// Create data associated with the course record
							user = new User(reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
							student = new Student(user, reader.GetBoolean(8));

							int grade = -1;
							if (!reader.IsDBNull(2))
							{
								grade = reader.GetInt32(2);
							}

							// Add the student course record to the list
							records.Add(new StudentCourseRecord(offering, student, reader.GetInt32(0), reader.GetDateTime(1), grade));
						}
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return null;
			}

			return records;
		}

		// Check to see if the student is registered for a particular class
		public bool CheckRegistration(CourseOffering offering, Student student)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Make sure the student is not already registered for this class
					MySqlCommand cmd = new MySqlCommand("select * from StudentCourseRecords where student=@Student and offering=@Offering;", connection);
					cmd.Parameters.AddWithValue("@Student", student.user.ID);
					cmd.Parameters.AddWithValue("@Offering", offering.ID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return true;
						}
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return true;
			}

			return false;
		}

		// Register a student for a course by adding a course record
		public bool RegisterCourseRecord(CourseOffering offering, Student student)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Add the record to the database
					MySqlCommand cmd = new MySqlCommand("insert into StudentCourseRecords (student, offering, registration) values (@Student, @Offering, CURDATE());", connection);
					cmd.Parameters.AddWithValue("@Student", student.user.ID);
					cmd.Parameters.AddWithValue("@Offering", offering.ID);
					cmd.ExecuteNonQuery();

					return true;
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return false;
			}
		}

		// Change the grade on a student course record
		public bool UpdateCourseRecord(StudentCourseRecord record, int grade)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Update the grade entry
					MySqlCommand cmd = new MySqlCommand("update StudentCourseRecords set grade = @Grade where id = @Id;", connection);
					cmd.Parameters.AddWithValue("@Grade", grade);
					cmd.Parameters.AddWithValue("@Id", record.ID);
					cmd.ExecuteNonQuery();

					return true;
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return false;
			}
		}

		// Remove a course record from the database
		public bool DropCourseRecord(StudentCourseRecord record)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Remove the course record
					MySqlCommand cmd = new MySqlCommand("delete from StudentCourseRecords where id = @Id;", connection);
					cmd.Parameters.AddWithValue("@Id", record.ID);
					cmd.ExecuteNonQuery();

					return true;
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return false;
			}
		}

		// Calculate a student's GPA
		public float GetGPA(Student student)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Get a list of the user's grades
					MySqlCommand cmd = new MySqlCommand("select StudentCourseRecords.grade from StudentCourseRecords where student = @Id;", connection);
					cmd.Parameters.AddWithValue("@Id", student.user.ID);

					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						List<double> grades = new List<double>();

						// Calculate the grade points of each grade in the database
						while (reader.Read())
						{
							if (!reader.IsDBNull(0))
							{
								double points = Math.Ceiling((reader.GetInt32(0) - 59) / 10.0f);
								if (points > 4.0)
								{
									points = 4.0;
								}
								else if (points < 0.0)
								{
									points = 0.0;
								}

								grades.Add(points);
							}
						}

						// Calculate the gpa from the grade point list
						double total = 0.0;
						if (grades.Count > 0)
						{
							foreach (double element in grades)
							{
								total += element;
							}
							total /= grades.Count;
						}
						else
						{
							return -1.0f;
						}

						return (float)total;
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return 0.0f;
			}
		}

		// Verify a user's login credentials
		public User Login(string username, string password)
		{
			string query = string.Empty;
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connection_string))
				{
					connection.Open();

					// Verify the username
					MySqlCommand cmd = new MySqlCommand("select * from Users where username=@Name and active=true;", connection);
					cmd.Parameters.AddWithValue("@Name", username);
					MySqlDataReader reader = cmd.ExecuteReader();

					if (reader.Read())
					{
						// Get the password hash and salt
						byte[] hash = Convert.FromBase64String(reader.GetString(5));
						byte[] salt = Convert.FromBase64String(reader.GetString(6));

						// Get the hash of the password entered
						byte[] password_hash = new Rfc2898DeriveBytes(password, salt).GetBytes(hash_size);

						// Verify the password
						for (int i = 0; i < hash_size; ++i)
						{
							if (hash[i] != password_hash[i])
							{
								// The password entered was wrong
								reader.Close();
								return null;
							}
						}

						// Return a valid user
						User login_user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
						reader.Close();
						return login_user;
					}
					else
					{
						// Username entered was wrong
						return null;
					}
				}
			}
			catch (MySqlException e)
			{
				if (debug)
				{
					MessageBox.Show(e.ToString());
				}
				return null;
			}
		}
	}
}
