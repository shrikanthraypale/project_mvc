using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDatasetDemo
{
    public partial class WebFrmInsertPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(TextBox1.Text);
            string name = Convert.ToString(TextBox2.Text);

            int marks = Convert.ToInt32(TextBox3.Text);
            webInfo inf = new webInfo { Id = Id, name = name, marks = marks };
            DataLayer d = new DataLayer();
            string msg = d.InsertaInfo(inf);

           // d.InsertaInfo(inf);
        }
    }
}