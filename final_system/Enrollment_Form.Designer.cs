/*
 * Created by SharpDevelop.
 * User: OAL
 * Date: 2/12/2022
 * Time: 1:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace final_system
{
	partial class Enrollment_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enrollment_Form));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cancel_button = new System.Windows.Forms.Button();
			this.next_button = new System.Windows.Forms.Button();
			this.place_of_birth = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.date_of_birth = new System.Windows.Forms.DateTimePicker();
			this.label15 = new System.Windows.Forms.Label();
			this.age_field = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.gender_combobox = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.middle_name_field = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.first_name_field = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.last_name_field = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.student_status = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.middle_name = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.first_name = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.last_name = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.middle_name);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.first_name);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.last_name);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 35);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(421, 562);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.cancel_button);
			this.panel2.Controls.Add(this.next_button);
			this.panel2.Controls.Add(this.place_of_birth);
			this.panel2.Controls.Add(this.label16);
			this.panel2.Controls.Add(this.date_of_birth);
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.age_field);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.gender_combobox);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.middle_name_field);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.first_name_field);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.last_name_field);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.student_status);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Location = new System.Drawing.Point(-1, -1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(421, 562);
			this.panel2.TabIndex = 13;
			// 
			// cancel_button
			// 
			this.cancel_button.BackColor = System.Drawing.Color.SpringGreen;
			this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cancel_button.FlatAppearance.BorderSize = 0;
			this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancel_button.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancel_button.Location = new System.Drawing.Point(251, 444);
			this.cancel_button.Name = "cancel_button";
			this.cancel_button.Size = new System.Drawing.Size(99, 33);
			this.cancel_button.TabIndex = 18;
			this.cancel_button.Text = "Cancel";
			this.cancel_button.UseVisualStyleBackColor = false;
			this.cancel_button.Click += new System.EventHandler(this.Cancel_buttonClick);
			// 
			// next_button
			// 
			this.next_button.BackColor = System.Drawing.Color.SpringGreen;
			this.next_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.next_button.FlatAppearance.BorderSize = 0;
			this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.next_button.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.next_button.Location = new System.Drawing.Point(132, 444);
			this.next_button.Name = "next_button";
			this.next_button.Size = new System.Drawing.Size(105, 33);
			this.next_button.TabIndex = 17;
			this.next_button.Text = "Next";
			this.next_button.UseVisualStyleBackColor = false;
			this.next_button.Click += new System.EventHandler(this.Next_buttonClick);
			// 
			// place_of_birth
			// 
			this.place_of_birth.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.place_of_birth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.place_of_birth.Location = new System.Drawing.Point(132, 388);
			this.place_of_birth.Multiline = true;
			this.place_of_birth.Name = "place_of_birth";
			this.place_of_birth.Size = new System.Drawing.Size(218, 32);
			this.place_of_birth.TabIndex = 16;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(26, 396);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 23);
			this.label16.TabIndex = 15;
			this.label16.Text = "Place of Birth";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// date_of_birth
			// 
			this.date_of_birth.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_of_birth.Location = new System.Drawing.Point(132, 348);
			this.date_of_birth.Name = "date_of_birth";
			this.date_of_birth.Size = new System.Drawing.Size(218, 25);
			this.date_of_birth.TabIndex = 14;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(26, 348);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 13;
			this.label15.Text = "Birth Date";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// age_field
			// 
			this.age_field.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.age_field.Location = new System.Drawing.Point(132, 291);
			this.age_field.Multiline = true;
			this.age_field.Name = "age_field";
			this.age_field.Size = new System.Drawing.Size(218, 32);
			this.age_field.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(26, 299);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "Age";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gender_combobox
			// 
			this.gender_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.gender_combobox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gender_combobox.FormattingEnabled = true;
			this.gender_combobox.Items.AddRange(new object[] {
									"Please Select Option",
									"Male",
									"Female"});
			this.gender_combobox.Location = new System.Drawing.Point(132, 247);
			this.gender_combobox.Name = "gender_combobox";
			this.gender_combobox.Size = new System.Drawing.Size(218, 28);
			this.gender_combobox.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(26, 252);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 9;
			this.label9.Text = "Gender";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// middle_name_field
			// 
			this.middle_name_field.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.middle_name_field.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.middle_name_field.Location = new System.Drawing.Point(132, 198);
			this.middle_name_field.Multiline = true;
			this.middle_name_field.Name = "middle_name_field";
			this.middle_name_field.Size = new System.Drawing.Size(218, 32);
			this.middle_name_field.TabIndex = 8;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(26, 206);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 7;
			this.label10.Text = "Middle Name ";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// first_name_field
			// 
			this.first_name_field.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.first_name_field.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.first_name_field.Location = new System.Drawing.Point(132, 150);
			this.first_name_field.Multiline = true;
			this.first_name_field.Name = "first_name_field";
			this.first_name_field.Size = new System.Drawing.Size(218, 32);
			this.first_name_field.TabIndex = 6;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(26, 158);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 5;
			this.label11.Text = "First Name ";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// last_name_field
			// 
			this.last_name_field.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.last_name_field.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.last_name_field.Location = new System.Drawing.Point(132, 103);
			this.last_name_field.Multiline = true;
			this.last_name_field.Name = "last_name_field";
			this.last_name_field.Size = new System.Drawing.Size(218, 32);
			this.last_name_field.TabIndex = 4;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(26, 111);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 3;
			this.label12.Text = "Last Name ";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// student_status
			// 
			this.student_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.student_status.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.student_status.FormattingEnabled = true;
			this.student_status.Items.AddRange(new object[] {
									"Please Select Option",
									"Old",
									"New",
									"Transferee"});
			this.student_status.Location = new System.Drawing.Point(130, 56);
			this.student_status.Name = "student_status";
			this.student_status.Size = new System.Drawing.Size(220, 28);
			this.student_status.TabIndex = 2;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(-1, 59);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(158, 23);
			this.label13.TabIndex = 1;
			this.label13.Text = "Personal Information";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(42, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(358, 37);
			this.label14.TabIndex = 0;
			this.label14.Text = "Personal Information";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(132, 291);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 32);
			this.textBox1.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(26, 299);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Age";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox2
			// 
			this.comboBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
									"Male",
									"Female"});
			this.comboBox2.Location = new System.Drawing.Point(132, 247);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(152, 28);
			this.comboBox2.TabIndex = 10;
			this.comboBox2.Text = "Please Select Option";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(26, 252);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Gender";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// middle_name
			// 
			this.middle_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.middle_name.Location = new System.Drawing.Point(132, 198);
			this.middle_name.Multiline = true;
			this.middle_name.Name = "middle_name";
			this.middle_name.Size = new System.Drawing.Size(152, 32);
			this.middle_name.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(26, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Middle Name ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// first_name
			// 
			this.first_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.first_name.Location = new System.Drawing.Point(132, 150);
			this.first_name.Multiline = true;
			this.first_name.Name = "first_name";
			this.first_name.Size = new System.Drawing.Size(152, 32);
			this.first_name.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(26, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "First Name ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// last_name
			// 
			this.last_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.last_name.Location = new System.Drawing.Point(132, 103);
			this.last_name.Multiline = true;
			this.last_name.Name = "last_name";
			this.last_name.Size = new System.Drawing.Size(152, 32);
			this.last_name.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(26, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Last Name ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Old",
									"New",
									"Transferee"});
			this.comboBox1.Location = new System.Drawing.Point(130, 56);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(152, 28);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Text = "Please Select Option";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(-1, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Personal Information";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(42, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(358, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Personal Information";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Enrollment_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Salmon;
			this.ClientSize = new System.Drawing.Size(445, 609);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Enrollment_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enrollment_Form";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox place_of_birth;
		private System.Windows.Forms.Button next_button;
		private System.Windows.Forms.Button cancel_button;
		private System.Windows.Forms.DateTimePicker date_of_birth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox last_name;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox first_name;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox middle_name;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox student_status;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox last_name_field;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox first_name_field;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox middle_name_field;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox gender_combobox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox age_field;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		
		
	}
}
