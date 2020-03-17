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

namespace LibraryApp
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }
        SqlConnection Con;
        SqlCommand Cmd;
        String Query;

        private void memberRegisterationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberRegister ul = new LibraryApp.MemberRegister();
            ul.MdiParent = this;
            ul.StartPosition = FormStartPosition.CenterScreen;
            ul.Show();
        }

        private void walkInRegisterationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WalkInRegister ul = new LibraryApp.WalkInRegister();
            ul.MdiParent = this;
            ul.StartPosition = FormStartPosition.CenterScreen;
            ul.Show();

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category ul = new LibraryApp.Category();
            ul.MdiParent = this;
            ul.StartPosition = FormStartPosition.CenterScreen;
            ul.Show();
        }

        private void booksDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDetail ul = new LibraryApp.BookDetail();
            ul.MdiParent = this;
            ul.StartPosition = FormStartPosition.CenterScreen;
            ul.Show();
        }

        private void Application_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Server = BLT188\\SQLEXPRESS; Database = Library; Integrated Security = true");
            Con.Open();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip5_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void transationDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionDetail ul = new LibraryApp.TransactionDetail();
            ul.MdiParent = this;
            ul.StartPosition = FormStartPosition.CenterScreen;
            ul.Show();
        }
    }
}
