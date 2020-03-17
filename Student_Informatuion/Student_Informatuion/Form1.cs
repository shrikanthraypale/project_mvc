using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Student_Informatuion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con1;
        SqlCommand Cmd;
        String Query;
        SqlDataAdapter ADP;
        DataSet DS;
        int i;
        int RNO = 0;
        MemoryStream MS;
        byte[] PhotoArray;
        String Gender;





        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Con1 = new SqlConnection("Server = BLT188\\SQLEXPRESS;Database =stud;Integrated Security=True");
            Con1.Open();
            MessageBox.Show("DataBase Connected");
            ADP = new SqlDataAdapter("Select * from StudentInformation", Con1);
            DS = new DataSet();
            ADP.Fill(DS, "StudentInformation");
            MessageBox.Show("DataBase Connected");
            LoadData();
            
        }
        void LoadData()
        {
            ADP = new SqlDataAdapter("Select StudentNo,StudentName,Course,dateTimePicker1 ", Con1);
            ADP.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DS = new DataSet();
            ADP.Fill(DS, "StudentInformation");
    
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Query = "Insert into StudentInformation Values('" + textBox2.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Value + "')";
            Cmd = new SqlCommand(Query, Con1);
            //  Con1.Open();
            Cmd.ExecuteNonQuery();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Query = "Update StudentInformation set  StudentName = '" + textBox2.Text + "',Course = '" + comboBox1.Text + "', DOJ = '" + dateTimePicker1.Value + "' Where StudentNo = " + textBox1.Text + "";
            Cmd = new SqlCommand(Query, Con1);
            //Con1.Open();
            Cmd.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Query = "Delete from StudentInformation Where StudentNo =" + textBox1.Text + "";
            Cmd = new SqlCommand(Query, Con1);
            //  Con1.Open();
            Cmd.ExecuteNonQuery();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter Adapter;

            if (comboBox2.Text == "All")
            {

                Adapter = new SqlDataAdapter("Select * From StudentInformation", Con1);
                DataSet DS = new DataSet();
                Adapter.Fill(DS, "StudentInformation");

                dataGridView1.DataSource = DS;
                dataGridView1.DataMember = "StudentInformation";
            }
            else if (comboBox2.Text == "Course")
            {
                Adapter = new SqlDataAdapter("Select Course From StudentInformation", Con1);
                DataSet DS = new DataSet();
                Adapter.Fill(DS, "Course");

                dataGridView1.DataSource = DS;
                dataGridView1.DataMember = "Course";
            }
            else
            {
                Adapter = new SqlDataAdapter("Select DOJ From StudentInformation", Con1);
                DataSet DS = new DataSet();
                Adapter.Fill(DS, "dateTimePicker1");

                dataGridView1.DataSource = DS;
                dataGridView1.DataMember = "dateTimePicker1";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
