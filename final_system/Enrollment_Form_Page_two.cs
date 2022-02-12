/*
 * Created by SharpDevelop.
 * User: OAL
 * Date: 2/12/2022
 * Time: 2:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace final_system
{
	/// <summary>
	/// Description of Enrollment_Form_Page_two.
	/// </summary>
	/// 
	public partial class Enrollment_Form_Page_two : Form
	{
		public static String house_number_value = "";
		public static String street_value = "";
		public static String sitio_barangay_value = "";
		public static String barangay_value = "";
		public static String city_municipality_value = "";
		public static String province_value = "";
		public static String zip_code_value = "";
		public static String contact_number_value = "";
		public static String email_address_value = "";
				
		
		public Enrollment_Form_Page_two()
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
			Enrollment_Form enrollment = new Enrollment_Form();
			
			enrollment.Show();
			this.Hide();
		}
		
		
		
		void Next_buttonClick(object sender, EventArgs e)
		{
			Enrollment_Form_Page_Three page_three = new Enrollment_Form_Page_Three();
			house_number_value = house_number.Text;
			street_value = street_number.Text;
			sitio_barangay_value = sitio_villages.Text;
			barangay_value = barangay.Text;
			city_municipality_value = muncipality_city.Text;
			province_value = province.Text;
			zip_code_value = zip_code.Text;
			contact_number_value = contact_number.Text;
			email_address_value = email_address.Text;
			page_three.Show();
			this.Hide();
			
		}
	}
}
