using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDatabase
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Connect to the database
			database = new Database("schoolrecords");
			database.Connect("schadmin", "diO8#7JK5$", false);

			// Open the login window
			context = new Context();
			ParentForm window = new LoginWindow();
			window.Show();
			context.RegisterWindow(window);

			// Start the application
			Application.Run(context);
		}

		static public Database database = null;	// The database access system for the application
		static public Context context = null;   // The application context that controls when to terminate the application

		static public User user = null;         // The user currently logged into the application
		static public Student student = null;   // Student data for the current user
		static public Faculty faculty = null;   // Faculty data for the current user
	}
}
