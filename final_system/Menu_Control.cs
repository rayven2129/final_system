/*
 * Created by SharpDevelop.
 * User: OAL
 * Date: 2/12/2022
 * Time: 11:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace final_system
{
	/// <summary>
	/// Description of Menu_Control.
	/// </summary>
	public partial class Menu_Control : Form
	{
		public Menu_Control()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Menu_ControlLoad(object sender, EventArgs e)
		{
			try{
				String check_conn = "datasource='localhost';username='root';password='';database='simple_data'";
				MySqlConnection conn = new MySqlConnection(check_conn);
				String sql = "SELECT * FROM enrollment_system";
				MySqlCommand command = new MySqlCommand(sql,conn);
				MySqlDataAdapter adapter = new MySqlDataAdapter();
				adapter.SelectCommand = command;
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dataGrid1.DataSource = dt;
				
				
			}catch (Exception ex){
				MessageBox.Show(ex.Message);
			}
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
			this.Hide();
		}
	}
}
