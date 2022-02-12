/*
 * Created by SharpDevelop.
 * User: OAL
 * Date: 2/12/2022
 * Time: 1:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace final_system
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
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
			if(check_password.Checked == true){
				password.PasswordChar = (char)0;
			}else{
				password.PasswordChar = '*';
				
			}
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			Enrollment_Form enrollment = new Enrollment_Form();
			enrollment.Show();
			this.Hide();
			
		}
		void Button2Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
		}
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			try{
				String str_conn ="datasource='localhost';username='root';password=''";
				MySqlConnection conn = new MySqlConnection(str_conn);
				String create_database = "CREATE DATABASE IF NOT EXISTS simple_data";
				
				MySqlCommand cmd_create_database= new MySqlCommand(create_database, conn);
				MySqlDataReader reader_database;
				conn.Open();
				reader_database = cmd_create_database.ExecuteReader();
				while(reader_database.Read()){}
				conn.Close();
				//
				String str_conn2 ="datasource='localhost';username='root';password=''; database='simple_data'";
				String create_table = "CREATE TABLE IF NOT EXISTS enrollment_system(student_id int(255) AUTO_INCREMENT NOT NULL,lrn VARCHAR(255) NOT NULL,grade_level VARCHAR(255) NOT NULL, last_name VARCHAR(255) NOT NULL, first_name VARCHAR(255) NOT NULL, middle_name VARCHAR(255) NOT NULL, gender VARCHAR(255) NOT NULL,age int(255) NOT NULL,date_of_birth VARCHAR(255) NOT NULL, place_of_birth TEXT NOT NULL,address TEXT NOT NULL, zip_code INT(255) NOT NULL,contact_number VARCHAR(255) NOT NULL, email_address VARCHAR(255) NOT NULL, guardian_name VARCHAR(255) NOT NULL, guardian_contact_number VARCHAR(255) NOT NULL, guardian_relation_to_student VARCHAR(255) NOT NULL, username VARCHAR(255) NOT NULL, password_user VARCHAR(255) NOT NULL, student_status VARCHAR(255) NOT NULL, PRIMARY KEY(student_id), UNIQUE(lrn), UNIQUE(username))";
				MySqlConnection conn2 = new MySqlConnection(str_conn2);
				MySqlCommand cmd_create_table = new MySqlCommand(create_table,conn2);
				MySqlDataReader reader_table;
				conn2.Open();
				reader_table = cmd_create_table.ExecuteReader();
				while(reader_table.Read()){}
				conn2.Close();
				
				
			}catch (Exception ex){
				MessageBox.Show(ex.Message);
			}
		}
		
		void Login_buttonClick(object sender, EventArgs e)
		{
			try{
			String check_conn = "datasource='localhost';username='root';password='';database='simple_data'";
			MySqlConnection conn3 = new MySqlConnection(check_conn);
			//
			String username_value = username.Text;
			String password_value = password.Text;
			//
			String sql = "SELECT * FROM enrollment_system WHERE username = '"+username_value+"' AND password_user = '"+password_value+"'";
			MySqlCommand sql_command = new MySqlCommand(sql,conn3);
			MySqlDataReader reader;
			conn3.Open();
			reader = sql_command.ExecuteReader();
			if(reader.Read()){
				String com_username = reader["username"].ToString();
				String com_password = reader["password_user"].ToString();
				if(com_username == username_value && com_password == password_value){
					Menu_Control menu = new Menu_Control();
					menu.Show();
					this.Hide();
				}else{
					
				}
				
			}else{
				MessageBox.Show("Wrong Username or Password!");
			}
			
			conn3.Close();
			}catch (Exception ex){
				MessageBox.Show(ex.Message);
			}
		}
		
	}
	
}
