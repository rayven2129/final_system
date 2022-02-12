/*
 * Created by SharpDevelop.
 * User: OAL
 * Date: 2/12/2022
 * Time: 3:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace final_system
{
	
	public partial class Enrollment_Form_Page_Four : Form
	{
		public Enrollment_Form_Page_Four()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if(show_password.Checked == true){
				password_field_text.PasswordChar = (char)0;
				
			}else{
				password_field_text.PasswordChar = '*';
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try{
			MainForm main = new MainForm();
			String str_conn  = "datasource = 'localhost';username = 'root'; password = ''; database = 'simple_data'";
			MySqlConnection conn = new MySqlConnection(str_conn);
			String last_name = Enrollment_Form.last_name_value;
			String first_name = Enrollment_Form.first_name_value;
			String middle_name = Enrollment_Form.middle_name_value;
			String gender = Enrollment_Form.gender_value;
			int age = int.Parse(Enrollment_Form.age_value);
			String birthdate = Enrollment_Form.birthday_value;
			String place_birth = Enrollment_Form.birth_place_value;
			String student_status = Enrollment_Form.student_status_value;
			//
			String house_number = Enrollment_Form_Page_two.house_number_value;
			String street_number = Enrollment_Form_Page_two.street_value;
			String sitio_vil = Enrollment_Form_Page_two.sitio_barangay_value;
			String municipal = Enrollment_Form_Page_two.city_municipality_value;
			String province = Enrollment_Form_Page_two.province_value;
			String address = house_number+" "+street_number+" "+sitio_vil+" "+municipal+" "+province;
			int zip_code = int.Parse(Enrollment_Form_Page_two.zip_code_value);
			String contact = Enrollment_Form_Page_two.contact_number_value;
			String email = Enrollment_Form_Page_two.email_address_value;
			//
			String lrn = Enrollment_Form_Page_Three.lrn_value;
			int g_level;
			String g_level_str = Enrollment_Form_Page_Three.grade_level_value;
			if (g_level_str == "Grade 7"){
				g_level = 7;
			}else if(g_level_str == "Grade 8"){
				g_level = 8;
			}else if(g_level_str == "Grade 9"){
				g_level = 9;
			}else if(g_level_str == "Grade 10"){
				g_level = 10;
			}else{
				g_level = 0;
			}
			String g_name = Enrollment_Form_Page_Three.g_name_value;
			String g_contact = Enrollment_Form_Page_Three.g_contact_value;
			String g_res = Enrollment_Form_Page_Three.grs_value;
			//
			String uname = username_field_text.Text;
			String password = password_field_text.Text;
			//
			String sql_insert = "INSERT INTO enrollment_system(lrn,grade_level,last_name,first_name,middle_name,gender,age,date_of_birth,place_of_birth,address,zip_code,contact_number,email_address,guardian_name,guardian_contact_number,guardian_relation_to_student,username,password_user,student_status) VALUES ('"+lrn+"','"+g_level+"','"+last_name+"','"+first_name+"','"+middle_name+"','"+gender+"','"+age+"','"+birthdate+"','"+place_birth+"','"+address+"','"+zip_code+"','"+contact+"','"+email+"','"+g_name+"','"+g_contact+"','"+g_res+"','"+uname+"','"+password+"','"+student_status+"')";
			
			MySqlCommand cmd_insert = new MySqlCommand(sql_insert,conn);
			MySqlDataReader reader_insert;
			conn.Open();
			reader_insert = cmd_insert.ExecuteReader();
			while(reader_insert.Read()){}
			DialogResult res = MessageBox.Show("Congratulations! You are now Registered in our system!. Thank You","Account Registered Successfully");
			if(res == DialogResult.OK){
				conn.Close();
				this.Close();
				main.Show();
			}
			conn.Close();
			}catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
		}
	}
}
