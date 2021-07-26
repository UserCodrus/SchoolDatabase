using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDatabase
{
	public class ChildForm : Form
	{
		protected ParentForm parent = null;

		// Set the parent of this window if it isn't already set
		public void ClaimParent(ParentForm _parent)
		{
			if (parent == null)
			{
				parent = _parent;
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);

			if (parent != null)
			{
				parent.ChildClosed();
			}
		}
	}
}
