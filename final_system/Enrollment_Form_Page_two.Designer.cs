/*
 * Created by SharpDevelop.
 * User: OAL
 * Date: 2/12/2022
 * Time: 2:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace final_system
{
	partial class Enrollment_Form_Page_two
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enrollment_Form_Page_two));
			this.previous = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.email_address = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.zip_code = new System.Windows.Forms.TextBox();
			this.muncipality_city = new System.Windows.Forms.TextBox();
			this.house_number = new System.Windows.Forms.TextBox();
			this.next_button = new System.Windows.Forms.Button();
			this.contact_number = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.province = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.barangay = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.sitio_villages = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.street_number = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
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
			// previous
			// 
			this.previous.BackColor = System.Drawing.Color.SpringGreen;
			this.previous.Cursor = System.Windows.Forms.Cursors.Hand;
			this.previous.FlatAppearance.BorderSize = 0;
			this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.previous.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.previous.Location = new System.Drawing.Point(250, 500);
			this.previous.Name = "previous";
			this.previous.Size = new System.Drawing.Size(100, 33);
			this.previous.TabIndex = 18;
			this.previous.Text = "Previous";
			this.previous.UseVisualStyleBackColor = false;
			this.previous.Click += new System.EventHandler(this.PreviousClick);
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
			this.panel1.Location = new System.Drawing.Point(12, 23);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(421, 562);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.email_address);
			this.panel2.Controls.Add(this.label17);
			this.panel2.Controls.Add(this.zip_code);
			this.panel2.Controls.Add(this.muncipality_city);
			this.panel2.Controls.Add(this.house_number);
			this.panel2.Controls.Add(this.previous);
			this.panel2.Controls.Add(this.next_button);
			this.panel2.Controls.Add(this.contact_number);
			this.panel2.Controls.Add(this.label16);
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.province);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.barangay);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.sitio_villages);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.street_number);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Location = new System.Drawing.Point(-1, -1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(421, 562);
			this.panel2.TabIndex = 13;
			// 
			// email_address
			// 
			this.email_address.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.email_address.Location = new System.Drawing.Point(132, 441);
			this.email_address.Multiline = true;
			this.email_address.Name = "email_address";
			this.email_address.Size = new System.Drawing.Size(218, 32);
			this.email_address.TabIndex = 23;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(26, 441);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 23);
			this.label17.TabIndex = 22;
			this.label17.Text = "Email Address";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// zip_code
			// 
			this.zip_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.zip_code.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zip_code.Location = new System.Drawing.Point(132, 348);
			this.zip_code.Multiline = true;
			this.zip_code.Name = "zip_code";
			this.zip_code.Size = new System.Drawing.Size(218, 32);
			this.zip_code.TabIndex = 21;
			// 
			// muncipality_city
			// 
			this.muncipality_city.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.muncipality_city.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.muncipality_city.Location = new System.Drawing.Point(132, 252);
			this.muncipality_city.Multiline = true;
			this.muncipality_city.Name = "muncipality_city";
			this.muncipality_city.Size = new System.Drawing.Size(218, 32);
			this.muncipality_city.TabIndex = 20;
			// 
			// house_number
			// 
			this.house_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.house_number.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.house_number.Location = new System.Drawing.Point(132, 56);
			this.house_number.Multiline = true;
			this.house_number.Name = "house_number";
			this.house_number.Size = new System.Drawing.Size(218, 32);
			this.house_number.TabIndex = 19;
			// 
			// next_button
			// 
			this.next_button.BackColor = System.Drawing.Color.SpringGreen;
			this.next_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.next_button.FlatAppearance.BorderSize = 0;
			this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.next_button.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.next_button.Location = new System.Drawing.Point(130, 500);
			this.next_button.Name = "next_button";
			this.next_button.Size = new System.Drawing.Size(101, 33);
			this.next_button.TabIndex = 17;
			this.next_button.Text = "Next";
			this.next_button.UseVisualStyleBackColor = false;
			this.next_button.Click += new System.EventHandler(this.Next_buttonClick);
			// 
			// contact_number
			// 
			this.contact_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.contact_number.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contact_number.Location = new System.Drawing.Point(132, 396);
			this.contact_number.Multiline = true;
			this.contact_number.Name = "contact_number";
			this.contact_number.Size = new System.Drawing.Size(218, 32);
			this.contact_number.TabIndex = 16;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(26, 396);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 23);
			this.label16.TabIndex = 15;
			this.label16.Text = "Contact Number";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(26, 348);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 13;
			this.label15.Text = "ZIP Code";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// province
			// 
			this.province.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.province.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.province.Location = new System.Drawing.Point(132, 299);
			this.province.Multiline = true;
			this.province.Name = "province";
			this.province.Size = new System.Drawing.Size(218, 32);
			this.province.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(26, 299);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "Province";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(26, 252);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 9;
			this.label9.Text = "Muncipality/City";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// barangay
			// 
			this.barangay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.barangay.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.barangay.Location = new System.Drawing.Point(132, 198);
			this.barangay.Multiline = true;
			this.barangay.Name = "barangay";
			this.barangay.Size = new System.Drawing.Size(218, 32);
			this.barangay.TabIndex = 8;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(26, 206);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 7;
			this.label10.Text = "Barangay";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sitio_villages
			// 
			this.sitio_villages.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.sitio_villages.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sitio_villages.Location = new System.Drawing.Point(132, 150);
			this.sitio_villages.Multiline = true;
			this.sitio_villages.Name = "sitio_villages";
			this.sitio_villages.Size = new System.Drawing.Size(218, 32);
			this.sitio_villages.TabIndex = 6;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(26, 158);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 5;
			this.label11.Text = "Sitio or Villages";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// street_number
			// 
			this.street_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.street_number.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.street_number.Location = new System.Drawing.Point(132, 103);
			this.street_number.Multiline = true;
			this.street_number.Name = "street_number";
			this.street_number.Size = new System.Drawing.Size(218, 32);
			this.street_number.TabIndex = 4;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(26, 111);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 3;
			this.label12.Text = "Street Number";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(26, 59);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(158, 23);
			this.label13.TabIndex = 1;
			this.label13.Text = "House Number";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(42, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(358, 37);
			this.label14.TabIndex = 0;
			this.label14.Text = "Additional Personal Information";
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
			// Enrollment_Form_Page_two
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Salmon;
			this.ClientSize = new System.Drawing.Size(445, 609);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Enrollment_Form_Page_two";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enrollment_Form_Page_two";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox zip_code;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox email_address;
		private System.Windows.Forms.TextBox muncipality_city;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox last_name;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox first_name;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox middle_name;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox street_number;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox sitio_villages;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox barangay;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox province;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox contact_number;
		private System.Windows.Forms.Button next_button;
		private System.Windows.Forms.TextBox house_number;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button previous;
	}
}
