using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDatabase
{
	public class ParentForm : Form
	{
		protected ChildForm child = null;

		// Called when the child window is closed
		public void ChildClosed()
		{
			child = null;
		}

		// Called when the child window has performed an action
		public virtual void ChildUpdate()
		{

		}

		protected void OpenWindow(ParentForm window)
		{
			Program.context.RegisterWindow(window);
			window.Show();
		}

		protected void OpenWindow(ChildForm window)
		{
			if (child == null)
			{
				child = window;
				window.ClaimParent(this);
				window.Show();
			}
			else
			{
				window.Close();
				child.Focus();
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);

			if (child != null)
			{
				child.Close();
			}
		}
	}
}
