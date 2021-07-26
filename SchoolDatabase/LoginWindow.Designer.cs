namespace SchoolDatabase
{
	partial class LoginWindow
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
			this.PassText = new System.Windows.Forms.TextBox();
			this.UserText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SubmitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PassText
			// 
			this.PassText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PassText.Location = new System.Drawing.Point(81, 35);
			this.PassText.Name = "PassText";
			this.PassText.PasswordChar = '*';
			this.PassText.Size = new System.Drawing.Size(136, 20);
			this.PassText.TabIndex = 0;
			// 
			// UserText
			// 
			this.UserText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UserText.Location = new System.Drawing.Point(81, 12);
			this.UserText.Name = "UserText";
			this.UserText.Size = new System.Drawing.Size(136, 20);
			this.UserText.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "User Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password:";
			// 
			// SubmitButton
			// 
			this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SubmitButton.Location = new System.Drawing.Point(127, 61);
			this.SubmitButton.Name = "SubmitButton";
			this.SubmitButton.Size = new System.Drawing.Size(90, 23);
			this.SubmitButton.TabIndex = 5;
			this.SubmitButton.Text = "Submit";
			this.SubmitButton.UseVisualStyleBackColor = true;
			this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
			// 
			// LoginWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(229, 94);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PassText);
			this.Controls.Add(this.UserText);
			this.Controls.Add(this.SubmitButton);
			this.Name = "LoginWindow";
			this.Text = "User Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PassText;
		private System.Windows.Forms.TextBox UserText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button SubmitButton;
	}
}

