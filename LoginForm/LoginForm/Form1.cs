using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data.OleDb;

using System.Web;

//public partial class Login :
namespace LoginForm
{
    public partial class Form1 : Form
    {
        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Server = BLT188\\SQLEXPRESS; Database = LoginPage; Integrated Security = true");
            Con.Open();
            Cmd.ExecuteNonQuery();
            Con.Close();
        }
        
        

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection();
           
            Con.Open();
            string command = "select * from login1 where Id=Login_Id and Passwd=Password";
            SqlCommand cmd = new SqlCommand(command, Con);
            cmd.Parameters.AddWithValue("Login_Id", Id.Text);
            cmd.Parameters.AddWithValue("Password", Passwd.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                /*if ur using vc# i.e. GUI then u can add a msg box here at the place of Response.Redirect*/
                // Response.Redirect("Default2.aspx");
                MessageBox.Show("Successfull");
            }
            else
            {
                Id.Text = "unknown user";
            }
            Con.Close();


        }
    }
}   


