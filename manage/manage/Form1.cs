/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.IO;

namespace StudentManagement
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataAdapter Adapter;
        DataSet DS;
        int RNO = 0;
        MemoryStream MS;
        byte[] PhotoArray;
        string Gender;

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Server = GNANS\\SQLEXPRESS; Database = StudentManagement; Integrated Security = true");
            LoadData();
            ShowData();
        }

        void LoadData()
        {
            Adapter = new SqlDataAdapter("Select Student_No, Student_Name, Gender, Course, Date_Joined, Photo From Student", Con);
            Adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DS = new DataSet();
            Adapter.Fill(DS, "Student");
        }

        void ShowData()
        {
            string Gender = "";

            if (CHKMale.Checked == true)
            {
                Gender = "Male";
            }

            else
            {
                Gender = "Female";
            }

            if (DS.Tables[0].Rows.Count > 0)
            {
                TxtStudentNo.Text = DS.Tables[0].Rows[RNO][0].ToString();
                TxtName.Text = DS.Tables[0].Rows[RNO][1].ToString();
                Gender = DS.Tables[0].Rows[RNO][2].ToString();
                CBOCourse.Text = DS.Tables[0].Rows[RNO][3].ToString();
                DTPCourseJoined.Text = DS.Tables[0].Rows[RNO][4].ToString();
                PBXImage.Image = null;

                if (DS.Tables[0].Rows[RNO][5] != System.DBNull.Value)
                {
                    PhotoArray = (byte[])DS.Tables[0].Rows[RNO][5];
                    MemoryStream MS = new MemoryStream(PhotoArray);
                    PBXImage.Image = Image.FromStream(MS);
                }
            }

            else
            {
                MessageBox.Show("No Records Found", "Student Records");
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OPNDialog.Filter = "jpeg|*.jpg|bmp|*.bmp|All Files|*.*";
            DialogResult Result = OPNDialog.ShowDialog();
            if (Result == DialogResult.OK)
            {
                PBXImage.Image = Image.FromFile(OPNDialog.FileName);
            }
        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("Select max(Student_No) + 10 From Student", Con);
            Con.Open();
            TxtStudentNo.Text = Cmd.ExecuteScalar().ToString();
            Con.Close();

            TxtStudentNo.Text = CBOCourse.Text = "";
            PBXImage.Image = null;
        }

        private void BTNInsert_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("Insert Into Student Values(" + TxtStudentNo.Text + ", '" + TxtName.Text + "', '" + Gender + "', '" + CBOCourse.Text + "', '" + DTPCourseJoined.Value + "', @photo", Con);
            ConvertPhoto();
            Con.Open();
            int n = Cmd.ExecuteNonQuery();
            Con.Close();

            if (n > 0)
            {
                MessageBox.Show("Record Inserted", "Insert");
                LoadData();
            }

            else
            {
                MessageBox.Show("Insertion Failes", "Insert");
            }
        }

        void ConvertPhoto()
        {
            if (PBXImage.Image != null)
            {
                MS = new MemoryStream();
                PBXImage.Image.Save(MS, ImageFormat.Jpeg);
                byte[] PhotoArray = new byte[MS.Length];
                MS.Position = 0;
                MS.Read(PhotoArray, 0, PhotoArray.Length);
                Cmd.Parameters.AddWithValue("@photo", PhotoArray);
            }
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(Interaction.InputBox("Enter Student_No", "Search", "20", 100, 100));
                DataRow DRow;
                DRow = DS.Tables[0].Rows.Find(n);

                if (DRow != null)
                {
                    RNO = DS.Tables[0].Rows.IndexOf(DRow);
                    TxtStudentNo.Text = DS.Tables[0].Rows[RNO][0].ToString();
                    TxtName.Text = DS.Tables[0].Rows[RNO][1].ToString();
                    Gender = DS.Tables[0].Rows[RNO][2].ToString();
                    CBOCourse.Text = DS.Tables[0].Rows[RNO][3].ToString();
                    DTPCourseJoined.Text = DS.Tables[0].Rows[RNO][4].ToString();

                    PBXImage.Image = null;

                    if (DRow[5] != System.DBNull.Value)
                    {
                        PhotoArray = (byte[])DRow[5];
                        MemoryStream MS = new MemoryStream(PhotoArray);
                        PBXImage.Image = Image.FromStream(MS);
                    }

                }

                else
                {
                    MessageBox.Show("Record Not Found", "Record Search");
                }
            }

            catch
            {
                MessageBox.Show("Invalid Input", "Input");
            }
        }
    }
}
