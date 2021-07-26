using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDatabase
{
	class Context : ApplicationContext
	{
		private uint form_count = 0;

		public Context()
		{
			// Add a handler for closing the application
			Application.ApplicationExit += new EventHandler(ApplicationExit);
		}

		// Register a window to the application
		public void RegisterWindow(ParentForm form)
		{
			form_count++;
			form.FormClosed += new FormClosedEventHandler(FormClosed);
		}

		// Callback for closing forms
		private void FormClosed(object sender, EventArgs e)
		{
			// Terminate the application when all forms are closed
			form_count--;
			if (form_count == 0)
			{
				ExitThread();
			}
		}

		// Callback for exiting the application
		private void ApplicationExit(object sender, EventArgs e)
		{
			
		}
	}
}
