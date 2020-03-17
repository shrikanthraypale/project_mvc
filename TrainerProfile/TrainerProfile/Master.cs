using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainerProfile
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {

        }

        private void trainersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void newTrainersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trainers Trainers = new TrainerProfile.Trainers();
            Trainers.MdiParent = this;
            Trainers.WindowState = FormWindowState.Maximized;
            Trainers.StartPosition = FormStartPosition.CenterScreen;
            Trainers.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
