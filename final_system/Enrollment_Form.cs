/*
 * Created by SharpDevelop.
 * User: OAL
 * Date: 2/12/2022
 * Time: 1:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace final_system
{
	/// <summary>
	/// Description of Enrollment_Form.
	/// </summary>
	/// 
	
	public partial class Enrollment_Form : Form
	{
		public static String student_status_value = "";
		public static String last_name_value = "";
		public static String first_name_value = "";
		public static String middle_name_value = "";
		public static String gender_value = "";
		public static String age_value = "";
		public static String birthday_value= "";
		public static String birth_place_value = "";
		public Enrollment_Form()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Cancel_buttonClick(object sender, EventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
			this.Hide();
			
		}
		
		void Next_buttonClick(object sender, EventArgs e)
		{	
			Enrollment_Form_Page_two page_two = new Enrollment_Form_Page_two();
			student_status_value = student_status.Text;
			last_name_value = last_name_field.Text;
			first_name_value = first_name_field.Text;
			middle_name_value = middle_name_field.Text;
			gender_value = gender_combobox.Text;
			age_value = age_field.Text;
			birthday_value = date_of_birth.Text;
			birth_place_value = place_of_birth.Text;
			page_two.Show();
			this.Hide();
		}
	}
}
