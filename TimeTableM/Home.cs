using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddLec_Click(object sender, EventArgs e)
        {
            AddLecturer frm = new AddLecturer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkingDaysAndHours_Click(object sender, EventArgs e)
        {
            AddWorking frm = new AddWorking() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubject frm = new AddSubject() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

        private void btnAddTags_Click(object sender, EventArgs e)
        {
            AddTag frm = new AddTag() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

        private void btnStdGrp_Click(object sender, EventArgs e)
        {
            AddStudent frm = new AddStudent() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            AddLocation frm = new AddLocation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

        private void btnVisuStat_Click(object sender, EventArgs e)
        {
            Statistics frm = new Statistics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SessionDash frm = new SessionDash() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            TimeTbl frm = new TimeTbl() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageLecturers frm = new ManageLecturers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageSubject frm = new ManageSubject() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageTag frm = new ManageTag() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageLocation frm = new ManageLocation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManageStudent frm = new ManageStudent() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlView.Controls.Add(frm);
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }
    }
}
