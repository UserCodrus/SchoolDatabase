namespace SchoolDatabase
{
	partial class NewCourseRecordWindow
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
			this.DataGridOfferings = new System.Windows.Forms.DataGridView();
			this.OfferingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OfferingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OfferingInstructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OfferingStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OfferingEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OfferingOnline = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.ButtonEnroll = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DataGridOfferings)).BeginInit();
			this.SuspendLayout();
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
            this.OfferingName,
            this.OfferingInstructor,
            this.OfferingStartDate,
            this.OfferingEndDate,
            this.OfferingOnline});
			this.DataGridOfferings.Location = new System.Drawing.Point(12, 12);
			this.DataGridOfferings.Name = "DataGridOfferings";
			this.DataGridOfferings.ReadOnly = true;
			this.DataGridOfferings.RowHeadersVisible = false;
			this.DataGridOfferings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridOfferings.Size = new System.Drawing.Size(464, 265);
			this.DataGridOfferings.TabIndex = 0;
			// 
			// OfferingID
			// 
			this.OfferingID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.OfferingID.HeaderText = "ID";
			this.OfferingID.Name = "OfferingID";
			this.OfferingID.ReadOnly = true;
			this.OfferingID.Visible = false;
			// 
			// OfferingName
			// 
			this.OfferingName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.OfferingName.HeaderText = "Name";
			this.OfferingName.Name = "OfferingName";
			this.OfferingName.ReadOnly = true;
			// 
			// OfferingInstructor
			// 
			this.OfferingInstructor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.OfferingInstructor.HeaderText = "Instructor";
			this.OfferingInstructor.Name = "OfferingInstructor";
			this.OfferingInstructor.ReadOnly = true;
			this.OfferingInstructor.Width = 76;
			// 
			// OfferingStartDate
			// 
			this.OfferingStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.OfferingStartDate.HeaderText = "Start Date";
			this.OfferingStartDate.Name = "OfferingStartDate";
			this.OfferingStartDate.ReadOnly = true;
			this.OfferingStartDate.Width = 80;
			// 
			// OfferingEndDate
			// 
			this.OfferingEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.OfferingEndDate.HeaderText = "End Date";
			this.OfferingEndDate.Name = "OfferingEndDate";
			this.OfferingEndDate.ReadOnly = true;
			this.OfferingEndDate.Width = 77;
			// 
			// OfferingOnline
			// 
			this.OfferingOnline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.OfferingOnline.HeaderText = "Online";
			this.OfferingOnline.Name = "OfferingOnline";
			this.OfferingOnline.ReadOnly = true;
			this.OfferingOnline.Width = 62;
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonCancel.Location = new System.Drawing.Point(401, 283);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 1;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// ButtonEnroll
			// 
			this.ButtonEnroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonEnroll.Location = new System.Drawing.Point(320, 283);
			this.ButtonEnroll.Name = "ButtonEnroll";
			this.ButtonEnroll.Size = new System.Drawing.Size(75, 23);
			this.ButtonEnroll.TabIndex = 2;
			this.ButtonEnroll.Text = "Enroll";
			this.ButtonEnroll.UseVisualStyleBackColor = true;
			this.ButtonEnroll.Click += new System.EventHandler(this.ButtonEnroll_Click);
			// 
			// NewCourseRecordWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 318);
			this.Controls.Add(this.ButtonEnroll);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.DataGridOfferings);
			this.Name = "NewCourseRecordWindow";
			this.Text = "Enrollment";
			((System.ComponentModel.ISupportInitialize)(this.DataGridOfferings)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView DataGridOfferings;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ButtonEnroll;
		private System.Windows.Forms.DataGridViewTextBoxColumn OfferingID;
		private System.Windows.Forms.DataGridViewTextBoxColumn OfferingName;
		private System.Windows.Forms.DataGridViewTextBoxColumn OfferingInstructor;
		private System.Windows.Forms.DataGridViewTextBoxColumn OfferingStartDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn OfferingEndDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn OfferingOnline;
	}
}