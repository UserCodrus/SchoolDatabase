namespace SchoolDatabase
{
	partial class AdminWindow
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
			this.LabelDescription = new System.Windows.Forms.Label();
			this.LabelFields = new System.Windows.Forms.Label();
			this.ButtonNew = new System.Windows.Forms.Button();
			this.TabController = new System.Windows.Forms.TabControl();
			this.TabCourses = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TabUsers = new System.Windows.Forms.TabPage();
			this.ButtonNewUser = new System.Windows.Forms.Button();
			this.DataGridUsers = new System.Windows.Forms.DataGridView();
			this.TabOfferings = new System.Windows.Forms.TabPage();
			this.ButtonNewOffering = new System.Windows.Forms.Button();
			this.DataGridOfferings = new System.Windows.Forms.DataGridView();
			this.TabEnrollment = new System.Windows.Forms.TabPage();
			this.TabProfile = new System.Windows.Forms.TabPage();
			this.ButtonLogOut = new System.Windows.Forms.Button();
			this.DataGridRecords = new System.Windows.Forms.DataGridView();
			this.ButtonEnroll = new System.Windows.Forms.Button();
			this.LabelGPA = new System.Windows.Forms.Label();
			this.ButtonGrades = new System.Windows.Forms.Button();
			this.OfferingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OfferingCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OfferingStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OfferingEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OfferingSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OfferingOnline = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RecordCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RecordInstructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RecordRegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RecordOnline = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RecordGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LabelProfileName = new System.Windows.Forms.Label();
			this.LabelProfileUser = new System.Windows.Forms.Label();
			this.LabelProfileEmail = new System.Windows.Forms.Label();
			this.LabelProfileStatus = new System.Windows.Forms.Label();
			this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UsersActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ButtonUserActivate = new System.Windows.Forms.Button();
			this.TabController.SuspendLayout();
			this.TabCourses.SuspendLayout();
			this.TabUsers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridUsers)).BeginInit();
			this.TabOfferings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridOfferings)).BeginInit();
			this.TabEnrollment.SuspendLayout();
			this.TabProfile.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridRecords)).BeginInit();
			this.SuspendLayout();
			// 
			// ListBoxCourses
			// 
			this.ListBoxCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.ListBoxCourses.FormattingEnabled = true;
			this.ListBoxCourses.Location = new System.Drawing.Point(3, 19);
			this.ListBoxCourses.Name = "ListBoxCourses";
			this.ListBoxCourses.Size = new System.Drawing.Size(149, 316);
			this.ListBoxCourses.Sorted = true;
			this.ListBoxCourses.TabIndex = 0;
			// 
			// LabelDescription
			// 
			this.LabelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelDescription.BackColor = System.Drawing.SystemColors.Window;
			this.LabelDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LabelDescription.Location = new System.Drawing.Point(158, 19);
			this.LabelDescription.Name = "LabelDescription";
			this.LabelDescription.Size = new System.Drawing.Size(394, 274);
			this.LabelDescription.TabIndex = 1;
			// 
			// LabelFields
			// 
			this.LabelFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelFields.BackColor = System.Drawing.SystemColors.Window;
			this.LabelFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LabelFields.Location = new System.Drawing.Point(158, 316);
			this.LabelFields.Name = "LabelFields";
			this.LabelFields.Size = new System.Drawing.Size(394, 19);
			this.LabelFields.TabIndex = 2;
			// 
			// ButtonNew
			// 
			this.ButtonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonNew.Location = new System.Drawing.Point(477, 342);
			this.ButtonNew.Name = "ButtonNew";
			this.ButtonNew.Size = new System.Drawing.Size(75, 23);
			this.ButtonNew.TabIndex = 3;
			this.ButtonNew.Text = "New";
			this.ButtonNew.UseVisualStyleBackColor = true;
			this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
			// 
			// TabController
			// 
			this.TabController.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.TabController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TabController.Controls.Add(this.TabCourses);
			this.TabController.Controls.Add(this.TabUsers);
			this.TabController.Controls.Add(this.TabOfferings);
			this.TabController.Controls.Add(this.TabEnrollment);
			this.TabController.Controls.Add(this.TabProfile);
			this.TabController.Location = new System.Drawing.Point(12, 12);
			this.TabController.Multiline = true;
			this.TabController.Name = "TabController";
			this.TabController.SelectedIndex = 0;
			this.TabController.Size = new System.Drawing.Size(582, 376);
			this.TabController.TabIndex = 5;
			// 
			// TabCourses
			// 
			this.TabCourses.BackColor = System.Drawing.SystemColors.Control;
			this.TabCourses.Controls.Add(this.label3);
			this.TabCourses.Controls.Add(this.label2);
			this.TabCourses.Controls.Add(this.label1);
			this.TabCourses.Controls.Add(this.ListBoxCourses);
			this.TabCourses.Controls.Add(this.LabelDescription);
			this.TabCourses.Controls.Add(this.ButtonNew);
			this.TabCourses.Controls.Add(this.LabelFields);
			this.TabCourses.Location = new System.Drawing.Point(23, 4);
			this.TabCourses.Name = "TabCourses";
			this.TabCourses.Padding = new System.Windows.Forms.Padding(3);
			this.TabCourses.Size = new System.Drawing.Size(555, 368);
			this.TabCourses.TabIndex = 0;
			this.TabCourses.Text = "Courses";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(155, 300);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Fields";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(155, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Description";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Courses";
			// 
			// TabUsers
			// 
			this.TabUsers.BackColor = System.Drawing.SystemColors.Control;
			this.TabUsers.Controls.Add(this.ButtonUserActivate);
			this.TabUsers.Controls.Add(this.ButtonNewUser);
			this.TabUsers.Controls.Add(this.DataGridUsers);
			this.TabUsers.Location = new System.Drawing.Point(23, 4);
			this.TabUsers.Name = "TabUsers";
			this.TabUsers.Padding = new System.Windows.Forms.Padding(3);
			this.TabUsers.Size = new System.Drawing.Size(555, 368);
			this.TabUsers.TabIndex = 1;
			this.TabUsers.Text = "Users";
			// 
			// ButtonNewUser
			// 
			this.ButtonNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonNewUser.Location = new System.Drawing.Point(477, 342);
			this.ButtonNewUser.Name = "ButtonNewUser";
			this.ButtonNewUser.Size = new System.Drawing.Size(75, 23);
			this.ButtonNewUser.TabIndex = 3;
			this.ButtonNewUser.Text = "New";
			this.ButtonNewUser.UseVisualStyleBackColor = true;
			this.ButtonNewUser.Click += new System.EventHandler(this.ButtonNewUser_Click);
			// 
			// DataGridUsers
			// 
			this.DataGridUsers.AllowUserToAddRows = false;
			this.DataGridUsers.AllowUserToDeleteRows = false;
			this.DataGridUsers.AllowUserToResizeColumns = false;
			this.DataGridUsers.AllowUserToResizeRows = false;
			this.DataGridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DataGridUsers.BackgroundColor = System.Drawing.SystemColors.Window;
			this.DataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserLastName,
            this.UserFirstName,
            this.UserStatus,
            this.UsersActive,
            this.UserName,
            this.UserEmail});
			this.DataGridUsers.Location = new System.Drawing.Point(3, 3);
			this.DataGridUsers.Name = "DataGridUsers";
			this.DataGridUsers.ReadOnly = true;
			this.DataGridUsers.RowHeadersVisible = false;
			this.DataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridUsers.Size = new System.Drawing.Size(549, 333);
			this.DataGridUsers.TabIndex = 2;
			// 
			// TabOfferings
			// 
			this.TabOfferings.BackColor = System.Drawing.SystemColors.Control;
			this.TabOfferings.Controls.Add(this.ButtonGrades);
			this.TabOfferings.Controls.Add(this.ButtonNewOffering);
			this.TabOfferings.Controls.Add(this.DataGridOfferings);
			this.TabOfferings.Location = new System.Drawing.Point(23, 4);
			this.TabOfferings.Name = "TabOfferings";
			this.TabOfferings.Size = new System.Drawing.Size(555, 368);
			this.TabOfferings.TabIndex = 2;
			this.TabOfferings.Text = "Classes";
			// 
			// ButtonNewOffering
			// 
			this.ButtonNewOffering.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonNewOffering.Location = new System.Drawing.Point(477, 342);
			this.ButtonNewOffering.Name = "ButtonNewOffering";
			this.ButtonNewOffering.Size = new System.Drawing.Size(75, 23);
			this.ButtonNewOffering.TabIndex = 1;
			this.ButtonNewOffering.Text = "New";
			this.ButtonNewOffering.UseVisualStyleBackColor = true;
			this.ButtonNewOffering.Click += new System.EventHandler(this.ButtonNewOffering_Click);
			// 
			// DataGridOfferings
			// 
			this.DataGridOfferings.AllowUserToAddRows = false;
			this.DataGridOfferings.AllowUserToDeleteRows = false;
			this.DataGridOfferings.AllowUserToResizeColumns = false;
			this.DataGridOfferings.AllowUserToResizeRows = false;
			this.DataGridOfferings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DataGridOfferings.BackgroundColor = System.Drawing.SystemColors.Window;
			this.DataGridOfferings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridOfferings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OfferingID,
            this.OfferingCourse,
            this.OfferingStart,
            this.OfferingEnd,
            this.OfferingSize,
            this.OfferingOnline});
			this.DataGridOfferings.Location = new System.Drawing.Point(3, 3);
			this.DataGridOfferings.Name = "DataGridOfferings";
			this.DataGridOfferings.ReadOnly = true;
			this.DataGridOfferings.RowHeadersVisible = false;
			this.DataGridOfferings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridOfferings.Size = new System.Drawing.Size(549, 333);
			this.DataGridOfferings.TabIndex = 0;
			// 
			// TabEnrollment
			// 
			this.TabEnrollment.BackColor = System.Drawing.SystemColors.Control;
			this.TabEnrollment.Controls.Add(this.LabelGPA);
			this.TabEnrollment.Controls.Add(this.ButtonEnroll);
			this.TabEnrollment.Controls.Add(this.DataGridRecords);
			this.TabEnrollment.Location = new System.Drawing.Point(23, 4);
			this.TabEnrollment.Name = "TabEnrollment";
			this.TabEnrollment.Size = new System.Drawing.Size(555, 368);
			this.TabEnrollment.TabIndex = 3;
			this.TabEnrollment.Text = "Enrollment";
			// 
			// TabProfile
			// 
			this.TabProfile.BackColor = System.Drawing.SystemColors.Control;
			this.TabProfile.Controls.Add(this.LabelProfileStatus);
			this.TabProfile.Controls.Add(this.LabelProfileEmail);
			this.TabProfile.Controls.Add(this.LabelProfileUser);
			this.TabProfile.Controls.Add(this.LabelProfileName);
			this.TabProfile.Controls.Add(this.ButtonLogOut);
			this.TabProfile.Location = new System.Drawing.Point(23, 4);
			this.TabProfile.Name = "TabProfile";
			this.TabProfile.Size = new System.Drawing.Size(555, 368);
			this.TabProfile.TabIndex = 4;
			this.TabProfile.Text = "Profile";
			// 
			// ButtonLogOut
			// 
			this.ButtonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonLogOut.Location = new System.Drawing.Point(477, 342);
			this.ButtonLogOut.Name = "ButtonLogOut";
			this.ButtonLogOut.Size = new System.Drawing.Size(75, 23);
			this.ButtonLogOut.TabIndex = 1;
			this.ButtonLogOut.Text = "Log Out";
			this.ButtonLogOut.UseVisualStyleBackColor = true;
			this.ButtonLogOut.Click += new System.EventHandler(this.ButtonLogOut_Click_1);
			// 
			// DataGridRecords
			// 
			this.DataGridRecords.AllowUserToAddRows = false;
			this.DataGridRecords.AllowUserToDeleteRows = false;
			this.DataGridRecords.AllowUserToResizeColumns = false;
			this.DataGridRecords.AllowUserToResizeRows = false;
			this.DataGridRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DataGridRecords.BackgroundColor = System.Drawing.SystemColors.Window;
			this.DataGridRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordID,
            this.RecordCourse,
            this.RecordInstructor,
            this.RecordRegisterDate,
            this.RecordOnline,
            this.RecordGrade});
			this.DataGridRecords.Location = new System.Drawing.Point(3, 3);
			this.DataGridRecords.Name = "DataGridRecords";
			this.DataGridRecords.ReadOnly = true;
			this.DataGridRecords.RowHeadersVisible = false;
			this.DataGridRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridRecords.Size = new System.Drawing.Size(549, 333);
			this.DataGridRecords.TabIndex = 0;
			// 
			// ButtonEnroll
			// 
			this.ButtonEnroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonEnroll.Location = new System.Drawing.Point(477, 342);
			this.ButtonEnroll.Name = "ButtonEnroll";
			this.ButtonEnroll.Size = new System.Drawing.Size(75, 23);
			this.ButtonEnroll.TabIndex = 1;
			this.ButtonEnroll.Text = "Enroll";
			this.ButtonEnroll.UseVisualStyleBackColor = true;
			this.ButtonEnroll.Click += new System.EventHandler(this.ButtonEnroll_Click);
			// 
			// LabelGPA
			// 
			this.LabelGPA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LabelGPA.BackColor = System.Drawing.SystemColors.Window;
			this.LabelGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LabelGPA.Location = new System.Drawing.Point(3, 342);
			this.LabelGPA.Name = "LabelGPA";
			this.LabelGPA.Size = new System.Drawing.Size(111, 23);
			this.LabelGPA.TabIndex = 2;
			this.LabelGPA.Text = "GPA: ";
			this.LabelGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ButtonGrades
			// 
			this.ButtonGrades.Location = new System.Drawing.Point(396, 342);
			this.ButtonGrades.Name = "ButtonGrades";
			this.ButtonGrades.Size = new System.Drawing.Size(75, 23);
			this.ButtonGrades.TabIndex = 2;
			this.ButtonGrades.Text = "Grades";
			this.ButtonGrades.UseVisualStyleBackColor = true;
			this.ButtonGrades.Click += new System.EventHandler(this.ButtonGrades_Click);
			// 
			// OfferingID
			// 
			this.OfferingID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.OfferingID.HeaderText = "ID";
			this.OfferingID.Name = "OfferingID";
			this.OfferingID.ReadOnly = true;
			this.OfferingID.Visible = false;
			this.OfferingID.Width = 24;
			// 
			// OfferingCourse
			// 
			this.OfferingCourse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.OfferingCourse.HeaderText = "Course";
			this.OfferingCourse.Name = "OfferingCourse";
			this.OfferingCourse.ReadOnly = true;
			// 
			// OfferingStart
			// 
			this.OfferingStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.OfferingStart.HeaderText = "Start Date";
			this.OfferingStart.Name = "OfferingStart";
			this.OfferingStart.ReadOnly = true;
			this.OfferingStart.Width = 80;
			// 
			// OfferingEnd
			// 
			this.OfferingEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.OfferingEnd.HeaderText = "End Date";
			this.OfferingEnd.Name = "OfferingEnd";
			this.OfferingEnd.ReadOnly = true;
			this.OfferingEnd.Width = 77;
			// 
			// OfferingSize
			// 
			this.OfferingSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.OfferingSize.HeaderText = "Max Students";
			this.OfferingSize.Name = "OfferingSize";
			this.OfferingSize.ReadOnly = true;
			this.OfferingSize.Width = 97;
			// 
			// OfferingOnline
			// 
			this.OfferingOnline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.OfferingOnline.HeaderText = "Online";
			this.OfferingOnline.Name = "OfferingOnline";
			this.OfferingOnline.ReadOnly = true;
			this.OfferingOnline.Width = 62;
			// 
			// RecordID
			// 
			this.RecordID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.RecordID.HeaderText = "ID";
			this.RecordID.Name = "RecordID";
			this.RecordID.ReadOnly = true;
			this.RecordID.Visible = false;
			this.RecordID.Width = 24;
			// 
			// RecordCourse
			// 
			this.RecordCourse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.RecordCourse.HeaderText = "Course";
			this.RecordCourse.Name = "RecordCourse";
			this.RecordCourse.ReadOnly = true;
			// 
			// RecordInstructor
			// 
			this.RecordInstructor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.RecordInstructor.HeaderText = "Instructor";
			this.RecordInstructor.Name = "RecordInstructor";
			this.RecordInstructor.ReadOnly = true;
			this.RecordInstructor.Width = 76;
			// 
			// RecordRegisterDate
			// 
			this.RecordRegisterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.RecordRegisterDate.HeaderText = "Registered";
			this.RecordRegisterDate.Name = "RecordRegisterDate";
			this.RecordRegisterDate.ReadOnly = true;
			this.RecordRegisterDate.Width = 83;
			// 
			// RecordOnline
			// 
			this.RecordOnline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.RecordOnline.HeaderText = "Online";
			this.RecordOnline.Name = "RecordOnline";
			this.RecordOnline.ReadOnly = true;
			this.RecordOnline.Width = 62;
			// 
			// RecordGrade
			// 
			this.RecordGrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.RecordGrade.HeaderText = "Grade";
			this.RecordGrade.Name = "RecordGrade";
			this.RecordGrade.ReadOnly = true;
			this.RecordGrade.Width = 61;
			// 
			// LabelProfileName
			// 
			this.LabelProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelProfileName.Location = new System.Drawing.Point(3, 0);
			this.LabelProfileName.Name = "LabelProfileName";
			this.LabelProfileName.Size = new System.Drawing.Size(549, 30);
			this.LabelProfileName.TabIndex = 2;
			this.LabelProfileName.Text = "Your Name";
			this.LabelProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelProfileUser
			// 
			this.LabelProfileUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelProfileUser.Location = new System.Drawing.Point(3, 61);
			this.LabelProfileUser.Name = "LabelProfileUser";
			this.LabelProfileUser.Size = new System.Drawing.Size(549, 30);
			this.LabelProfileUser.TabIndex = 3;
			this.LabelProfileUser.Text = "Username";
			this.LabelProfileUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelProfileEmail
			// 
			this.LabelProfileEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelProfileEmail.Location = new System.Drawing.Point(3, 91);
			this.LabelProfileEmail.Name = "LabelProfileEmail";
			this.LabelProfileEmail.Size = new System.Drawing.Size(549, 30);
			this.LabelProfileEmail.TabIndex = 4;
			this.LabelProfileEmail.Text = "Email";
			this.LabelProfileEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelProfileStatus
			// 
			this.LabelProfileStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelProfileStatus.Location = new System.Drawing.Point(3, 149);
			this.LabelProfileStatus.Name = "LabelProfileStatus";
			this.LabelProfileStatus.Size = new System.Drawing.Size(549, 30);
			this.LabelProfileStatus.TabIndex = 5;
			this.LabelProfileStatus.Text = "Status";
			this.LabelProfileStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UserID
			// 
			this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.UserID.HeaderText = "ID";
			this.UserID.Name = "UserID";
			this.UserID.ReadOnly = true;
			this.UserID.Visible = false;
			this.UserID.Width = 24;
			// 
			// UserLastName
			// 
			this.UserLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.UserLastName.HeaderText = "Last Name";
			this.UserLastName.Name = "UserLastName";
			this.UserLastName.ReadOnly = true;
			this.UserLastName.Width = 83;
			// 
			// UserFirstName
			// 
			this.UserFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.UserFirstName.HeaderText = "First Name";
			this.UserFirstName.Name = "UserFirstName";
			this.UserFirstName.ReadOnly = true;
			this.UserFirstName.Width = 82;
			// 
			// UserStatus
			// 
			this.UserStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.UserStatus.HeaderText = "Status";
			this.UserStatus.Name = "UserStatus";
			this.UserStatus.ReadOnly = true;
			this.UserStatus.Width = 62;
			// 
			// UsersActive
			// 
			this.UsersActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.UsersActive.HeaderText = "Active";
			this.UsersActive.Name = "UsersActive";
			this.UsersActive.ReadOnly = true;
			this.UsersActive.Width = 62;
			// 
			// UserName
			// 
			this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.UserName.HeaderText = "Username";
			this.UserName.Name = "UserName";
			this.UserName.ReadOnly = true;
			this.UserName.Width = 80;
			// 
			// UserEmail
			// 
			this.UserEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.UserEmail.HeaderText = "Email Address";
			this.UserEmail.Name = "UserEmail";
			this.UserEmail.ReadOnly = true;
			// 
			// ButtonUserActivate
			// 
			this.ButtonUserActivate.Location = new System.Drawing.Point(350, 342);
			this.ButtonUserActivate.Name = "ButtonUserActivate";
			this.ButtonUserActivate.Size = new System.Drawing.Size(121, 23);
			this.ButtonUserActivate.TabIndex = 4;
			this.ButtonUserActivate.Text = "Activate / Deactivate";
			this.ButtonUserActivate.UseVisualStyleBackColor = true;
			this.ButtonUserActivate.Click += new System.EventHandler(this.ButtonUserActivate_Click);
			// 
			// AdminWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(604, 400);
			this.Controls.Add(this.TabController);
			this.Name = "AdminWindow";
			this.Text = "Class Manager";
			this.TabController.ResumeLayout(false);
			this.TabCourses.ResumeLayout(false);
			this.TabCourses.PerformLayout();
			this.TabUsers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridUsers)).EndInit();
			this.TabOfferings.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridOfferings)).EndInit();
			this.TabEnrollment.ResumeLayout(false);
			this.TabProfile.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridRecords)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox ListBoxCourses;
		private System.Windows.Forms.Label LabelDescription;
		private System.Windows.Forms.Label LabelFields;
		private System.Windows.Forms.Button ButtonNew;
		private System.Windows.Forms.TabControl TabController;
		private System.Windows.Forms.TabPage TabCourses;
		private System.Windows.Forms.TabPage TabUsers;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView DataGridUsers;
		private System.Windows.Forms.Button ButtonNewUser;
		private System.Windows.Forms.TabPage TabOfferings;
		private System.Windows.Forms.TabPage TabEnrollment;
		private System.Windows.Forms.TabPage TabProfile;
		private System.Windows.Forms.Button ButtonLogOut;
		private System.Windows.Forms.Button ButtonNewOffering;
		private System.Windows.Forms.DataGridView DataGridOfferings;
		private System.Windows.Forms.Label LabelGPA;
		private System.Windows.Forms.Button ButtonEnroll;
		private System.Windows.Forms.DataGridView DataGridRecords;
		private System.Windows.Forms.Button ButtonGrades;
		private System.Windows.Forms.DataGridViewTextBoxColumn OfferingID;
		private System.Windows.Forms.DataGridViewTextBoxColumn OfferingCourse;
		private System.Windows.Forms.DataGridViewTextBoxColumn OfferingStart;
		private System.Windows.Forms.DataGridViewTextBoxColumn OfferingEnd;
		private System.Windows.Forms.DataGridViewTextBoxColumn OfferingSize;
		private System.Windows.Forms.DataGridViewTextBoxColumn OfferingOnline;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordID;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordCourse;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordInstructor;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordRegisterDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordOnline;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordGrade;
		private System.Windows.Forms.Label LabelProfileStatus;
		private System.Windows.Forms.Label LabelProfileEmail;
		private System.Windows.Forms.Label LabelProfileUser;
		private System.Windows.Forms.Label LabelProfileName;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserFirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn UsersActive;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
		private System.Windows.Forms.Button ButtonUserActivate;
	}
}