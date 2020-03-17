using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class MemberRegister : Form
    {
        public MemberRegister()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
         //   Cmd = new SqlCommand("Insert Into members2 Values(" + MID.Text + ", '" + Idv.Text + "', '" + regdate.Text + "', '" + CBOCourse.Text + "', '" + DTPCourseJoined.Text + "', @photo)", Con);
        }
    }
}
