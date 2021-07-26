namespace SchoolDatabase
{
	partial class NewOfferingWindow
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
			this.ListBoxCourses = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.DateTimeStart = new System.Windows.Forms.DateTimePicker();
			this.DateTimeEnd = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.NumericSize = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.CheckBoxOnline = new System.Windows.Forms.CheckBox();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.ButtonAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.NumericSize)).BeginInit();
			this.SuspendLayout();
			// 
			// ListBoxCourses
			// 
			this.ListBoxCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.ListBoxCourses.FormattingEnabled = true;
			this.ListBoxCourses.Location = new System.Drawing.Point(12, 24);
			this.ListBoxCourses.Name = "ListBoxCourses";
			this.ListBoxCourses.Size = new System.Drawing.Size(120, 173);
			this.ListBoxCourses.Sorted = true;
			this.ListBoxCourses.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Course";
			// 
			// DateTimeStart
			// 
			this.DateTimeStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DateTimeStart.Location = new System.Drawing.Point(138, 24);
			this.DateTimeStart.Name = "DateTimeStart";
			this.DateTimeStart.Size = new System.Drawing.Size(206, 20);
			this.DateTimeStart.TabIndex = 7;
			// 
			// DateTimeEnd
			// 
			this.DateTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DateTimeEnd.Location = new System.Drawing.Point(138, 68);
			this.DateTimeEnd.Name = "DateTimeEnd";
			this.DateTimeEnd.Size = new System.Drawing.Size(206, 20);
			this.DateTimeEnd.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(138, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Start Date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(138, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "End Date";
			// 
			// NumericSize
			// 
			this.NumericSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NumericSize.Location = new System.Drawing.Point(138, 113);
			this.NumericSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericSize.Name = "NumericSize";
			this.NumericSize.Size = new System.Drawing.Size(206, 20);
			this.NumericSize.TabIndex = 11;
			this.NumericSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(135, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Class Size";
			// 
			// CheckBoxOnline
			// 
			this.CheckBoxOnline.AutoSize = true;
			this.CheckBoxOnline.Location = new System.Drawing.Point(138, 149);
			this.CheckBoxOnline.Name = "CheckBoxOnline";
			this.CheckBoxOnline.Size = new System.Drawing.Size(92, 17);
			this.CheckBoxOnline.TabIndex = 13;
			this.CheckBoxOnline.Text = "Online Course";
			this.CheckBoxOnline.UseVisualStyleBackColor = true;
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonCancel.Location = new System.Drawing.Point(269, 174);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 14;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// ButtonAdd
			// 
			this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonAdd.Location = new System.Drawing.Point(188, 174);
			this.ButtonAdd.Name = "ButtonAdd";
			this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
			this.ButtonAdd.TabIndex = 15;
			this.ButtonAdd.Text = "Add Class";
			this.ButtonAdd.UseVisualStyleBackColor = true;
			this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// NewOfferingWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 208);
			this.Controls.Add(this.ButtonAdd);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.CheckBoxOnline);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.NumericSize);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DateTimeEnd);
			this.Controls.Add(this.DateTimeStart);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ListBoxCourses);
			this.Name = "NewOfferingWindow";
			this.Text = "New Class";
			((System.ComponentModel.ISupportInitialize)(this.NumericSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ListBoxCourses;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker DateTimeStart;
		private System.Windows.Forms.DateTimePicker DateTimeEnd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown NumericSize;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox CheckBoxOnline;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ButtonAdd;
	}
}