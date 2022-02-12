/*
 * Created by SharpDevelop.
 * User: OAL
 * Date: 2/12/2022
 * Time: 1:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace final_system
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.enroll_here = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.check_password = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.exit_button = new System.Windows.Forms.Button();
			this.login_button = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.password = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.username = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.enroll_here);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.check_password);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.exit_button);
			this.panel1.Controls.Add(this.login_button);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.password);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.username);
			this.panel1.Location = new System.Drawing.Point(12, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(438, 527);
			this.panel1.TabIndex = 0;
			// 
			// enroll_here
			// 
			this.enroll_here.Cursor = System.Windows.Forms.Cursors.Hand;
			this.enroll_here.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enroll_here.ForeColor = System.Drawing.Color.Blue;
			this.enroll_here.Location = new System.Drawing.Point(230, 462);
			this.enroll_here.Name = "enroll_here";
			this.enroll_here.Size = new System.Drawing.Size(100, 23);
			this.enroll_here.TabIndex = 11;
			this.enroll_here.Text = "Enroll here";
			this.enroll_here.Click += new System.EventHandler(this.Label4Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(140, 462);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "No account?";
			// 
			// check_password
			// 
			this.check_password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.check_password.Location = new System.Drawing.Point(140, 306);
			this.check_password.Name = "check_password";
			this.check_password.Size = new System.Drawing.Size(236, 24);
			this.check_password.TabIndex = 9;
			this.check_password.Text = "Show Password";
			this.check_password.UseVisualStyleBackColor = true;
			this.check_password.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(149, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(226, 64);
			this.label2.TabIndex = 8;
			this.label2.Text = "Login Centre";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(150, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 64);
			this.label1.TabIndex = 7;
			this.label1.Text = "Recto Memorial National High School";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(38, 27);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(105, 114);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			// 
			// exit_button
			// 
			this.exit_button.BackColor = System.Drawing.Color.White;
			this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exit_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.exit_button.FlatAppearance.BorderSize = 2;
			this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exit_button.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit_button.Location = new System.Drawing.Point(100, 404);
			this.exit_button.Name = "exit_button";
			this.exit_button.Size = new System.Drawing.Size(276, 40);
			this.exit_button.TabIndex = 5;
			this.exit_button.Text = "Exit";
			this.exit_button.UseVisualStyleBackColor = false;
			this.exit_button.Click += new System.EventHandler(this.Button2Click);
			// 
			// login_button
			// 
			this.login_button.BackColor = System.Drawing.Color.LightGreen;
			this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.login_button.FlatAppearance.BorderSize = 0;
			this.login_button.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_button.Location = new System.Drawing.Point(100, 347);
			this.login_button.Name = "login_button";
			this.login_button.Size = new System.Drawing.Size(276, 40);
			this.login_button.TabIndex = 4;
			this.login_button.Text = "Login";
			this.login_button.UseVisualStyleBackColor = false;
			this.login_button.Click += new System.EventHandler(this.Login_buttonClick);
			
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(100, 241);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(43, 44);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// password
			// 
			this.password.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(140, 241);
			this.password.Multiline = true;
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size(236, 44);
			this.password.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(100, 177);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(43, 44);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// username
			// 
			this.username.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.Location = new System.Drawing.Point(140, 177);
			this.username.Multiline = true;
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(236, 44);
			this.username.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.CancelButton = this.exit_button;
			this.ClientSize = new System.Drawing.Size(462, 588);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "final_system";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label enroll_here;
		private System.Windows.Forms.CheckBox check_password;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button login_button;
		private System.Windows.Forms.Button exit_button;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		
		
	}
}
