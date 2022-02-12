/*
 * Created by SharpDevelop.
 * User: OAL
 * Date: 2/12/2022
 * Time: 3:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace final_system
{
	/// <summary>
	/// Description of Enrollment_Form_Page_Three.
	/// </summary>
	public partial class Enrollment_Form_Page_Three : Form
	{
		public static String lrn_value = "";
		public static String grade_level_value = "";
		public static String g_name_value = "";
		public static String g_contact_value = "";
		public static String grs_value = "";
		public Enrollment_Form_Page_Three()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		
		void PreviousClick(object sender, EventArgs e)
		{
			Enrollment_Form_Page_two page_two = new Enrollment_Form_Page_two();
			page_two.Show();
			this.Hide();
		}
		
		void Next_buttonClick(object sender, EventArgs e)
		{
			Enrollment_Form_Page_Four page_four = new Enrollment_Form_Page_Four();
			lrn_value = lrn.Text;
			grade_level_value = grade_level.Text;
			g_name_value = guardian_name.Text;
			g_contact_value = guardian_contact.Text;
			grs_value = g_relation_student.Text;
			
			
			page_four.Show();
			this.Hide();
		}
	}
}
