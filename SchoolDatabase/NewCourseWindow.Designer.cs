namespace SchoolDatabase
{
	partial class NewCourseWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.TextBoxName = new System.Windows.Forms.TextBox();
			this.TextBoxDescription = new System.Windows.Forms.TextBox();
			this.ButtonAccept = new System.Windows.Forms.Button();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.CheckList = new System.Windows.Forms.CheckedListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// TextBoxName
			// 
			this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxName.Location = new System.Drawing.Point(12, 23);
			this.TextBoxName.Name = "TextBoxName";
			this.TextBoxName.Size = new System.Drawing.Size(258, 20);
			this.TextBoxName.TabIndex = 1;
			// 
			// TextBoxDescription
			// 
			this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxDescription.Location = new System.Drawing.Point(12, 64);
			this.TextBoxDescription.Multiline = true;
			this.TextBoxDescription.Name = "TextBoxDescription";
			this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBoxDescription.Size = new System.Drawing.Size(258, 203);
			this.TextBoxDescription.TabIndex = 3;
			// 
			// ButtonAccept
			// 
			this.ButtonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonAccept.Location = new System.Drawing.Point(239, 272);
			this.ButtonAccept.Name = "ButtonAccept";
			this.ButtonAccept.Size = new System.Drawing.Size(75, 23);
			this.ButtonAccept.TabIndex = 4;
			this.ButtonAccept.Text = "Add Course";
			this.ButtonAccept.UseVisualStyleBackColor = true;
			this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonCancel.Location = new System.Drawing.Point(320, 272);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 5;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Description";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// CheckList
			// 
			this.CheckList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CheckList.CheckOnClick = true;
			this.CheckList.FormattingEnabled = true;
			this.CheckList.Location = new System.Drawing.Point(276, 23);
			this.CheckList.Name = "CheckList";
			this.CheckList.Size = new System.Drawing.Size(119, 244);
			this.CheckList.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(273, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Fields";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// NewCourseWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 300);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CheckList);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.ButtonAccept);
			this.Controls.Add(this.TextBoxDescription);
			this.Controls.Add(this.TextBoxName);
			this.Controls.Add(this.label1);
			this.Name = "NewCourseWindow";
			this.Text = "New Course";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextBoxName;
		private System.Windows.Forms.TextBox TextBoxDescription;
		private System.Windows.Forms.Button ButtonAccept;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckedListBox CheckList;
		private System.Windows.Forms.Label label3;
	}
}