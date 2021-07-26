namespace SchoolDatabase
{
	partial class GradingWindow
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
			this.DataGridRecords = new System.Windows.Forms.DataGridView();
			this.RecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RecordName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RecordGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.ButtonGrade = new System.Windows.Forms.Button();
			this.NumericGrade = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.ButtonDrop = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DataGridRecords)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericGrade)).BeginInit();
			this.SuspendLayout();
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
            this.RecordName,
            this.RecordGrade});
			this.DataGridRecords.Location = new System.Drawing.Point(12, 12);
			this.DataGridRecords.Name = "DataGridRecords";
			this.DataGridRecords.ReadOnly = true;
			this.DataGridRecords.RowHeadersVisible = false;
			this.DataGridRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridRecords.Size = new System.Drawing.Size(444, 289);
			this.DataGridRecords.TabIndex = 0;
			// 
			// RecordID
			// 
			this.RecordID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.RecordID.HeaderText = "ID";
			this.RecordID.Name = "RecordID";
			this.RecordID.ReadOnly = true;
			this.RecordID.Visible = false;
			// 
			// RecordName
			// 
			this.RecordName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.RecordName.HeaderText = "Student Name";
			this.RecordName.Name = "RecordName";
			this.RecordName.ReadOnly = true;
			// 
			// RecordGrade
			// 
			this.RecordGrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.RecordGrade.HeaderText = "Grade";
			this.RecordGrade.Name = "RecordGrade";
			this.RecordGrade.ReadOnly = true;
			this.RecordGrade.Width = 61;
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonCancel.Location = new System.Drawing.Point(381, 307);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 1;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// ButtonGrade
			// 
			this.ButtonGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonGrade.Location = new System.Drawing.Point(142, 307);
			this.ButtonGrade.Name = "ButtonGrade";
			this.ButtonGrade.Size = new System.Drawing.Size(75, 23);
			this.ButtonGrade.TabIndex = 2;
			this.ButtonGrade.Text = "Update";
			this.ButtonGrade.UseVisualStyleBackColor = true;
			this.ButtonGrade.Click += new System.EventHandler(this.ButtonGrade_Click);
			// 
			// NumericGrade
			// 
			this.NumericGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.NumericGrade.Location = new System.Drawing.Point(57, 310);
			this.NumericGrade.Name = "NumericGrade";
			this.NumericGrade.Size = new System.Drawing.Size(79, 20);
			this.NumericGrade.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Location = new System.Drawing.Point(12, 308);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Grade:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ButtonDrop
			// 
			this.ButtonDrop.Location = new System.Drawing.Point(223, 307);
			this.ButtonDrop.Name = "ButtonDrop";
			this.ButtonDrop.Size = new System.Drawing.Size(75, 23);
			this.ButtonDrop.TabIndex = 5;
			this.ButtonDrop.Text = "Drop";
			this.ButtonDrop.UseVisualStyleBackColor = true;
			this.ButtonDrop.Click += new System.EventHandler(this.ButtonDrop_Click);
			// 
			// GradingWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 342);
			this.Controls.Add(this.ButtonDrop);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NumericGrade);
			this.Controls.Add(this.ButtonGrade);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.DataGridRecords);
			this.Name = "GradingWindow";
			this.Text = "Gradebook - ";
			((System.ComponentModel.ISupportInitialize)(this.DataGridRecords)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericGrade)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView DataGridRecords;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ButtonGrade;
		private System.Windows.Forms.NumericUpDown NumericGrade;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordID;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordName;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordGrade;
		private System.Windows.Forms.Button ButtonDrop;
	}
}