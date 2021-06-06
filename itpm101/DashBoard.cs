using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itpm101
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            AddTags f3 = new AddTags();
            f3.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddStudentGroup f1 = new AddStudentGroup();
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f1);
            f1.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ManageStudentGroup f2 = new ManageStudentGroup();
            f2.TopLevel = false;
            f2.Dock = DockStyle.Fill;
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f2);
            f2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddTags f3 = new AddTags();
            f3.TopLevel = false;
            f3.Dock = DockStyle.Fill;
            f3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f3);
            f3.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            ManageTags f4 = new ManageTags();
            f4.TopLevel = false;
            f4.Dock = DockStyle.Fill;
            f4.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f4);
            f4.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //test tttttttttttt
            //ttttttttttttttttt
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddLecture f5 = new AddLecture();
            f5.TopLevel = false;
            f5.Dock = DockStyle.Fill;
            f5.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f5);
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddSubjects f6 = new AddSubjects();
            f6.TopLevel = false;
            f6.Dock = DockStyle.Fill;
            f6.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f6);
            f6.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddSession f7 = new AddSession();
            f7.TopLevel = false;
            f7.Dock = DockStyle.Fill;
            f7.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f7);
            f7.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ManageLecturer f8 = new ManageLecturer();
            f8.TopLevel = false;
            f8.Dock = DockStyle.Fill;
            f8.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f8);
            f8.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ManageSubject f9 = new ManageSubject();
            f9.TopLevel = false;
            f9.Dock = DockStyle.Fill;
            f9.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f9);
            f9.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ManageSession f10 = new ManageSession();
            f10.TopLevel = false;
            f10.Dock = DockStyle.Fill;
            f10.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f10);
            f10.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ViewLocation f11 = new ViewLocation();
            f11.TopLevel = false;
            f11.Dock = DockStyle.Fill;
            f11.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f11);
            f11.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddLocation f011 = new AddLocation();
            f011.TopLevel = false;
            f011.Dock = DockStyle.Fill;
            f011.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f011);
            f011.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            TimesAllocation f12 = new TimesAllocation();
            f12.TopLevel = false;
            f12.Dock = DockStyle.Fill;
            f12.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f12);
            f12.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            ManageSessionRooms f13 = new ManageSessionRooms();
            f13.TopLevel = false;
            f13.Dock = DockStyle.Fill;
            f13.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f13);
            f13.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ManageLocation f14 = new ManageLocation();
            f14.TopLevel = false;
            f14.Dock = DockStyle.Fill;
            f14.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f14);
            f14.Show();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ConsecutiveSession f15 = new ConsecutiveSession();
            f15.TopLevel = false;
            f15.Dock = DockStyle.Fill;
            f15.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f15);
            f15.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ParallelSession f16 = new ParallelSession();
            f16.TopLevel = false;
            f16.Dock = DockStyle.Fill;
            f16.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f16);
            f16.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            NonOvelappingSession f17 = new NonOvelappingSession();
            f17.TopLevel = false;
            f17.Dock = DockStyle.Fill;
            f17.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f17);
            f17.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            LocationNot f18 = new LocationNot();
            f18.TopLevel = false;
            f18.Dock = DockStyle.Fill;
            f18.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f18);
            f18.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddWorkingDays f19 = new AddWorkingDays();
            f19.TopLevel = false;
            f19.Dock = DockStyle.Fill;
            f19.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f19);
            f19.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ManageNot f21 = new ManageNot();
            f21.TopLevel = false;
            f21.Dock = DockStyle.Fill;
            f21.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f21);
            f21.Show();
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            SessionNot f22 = new SessionNot();
            f22.TopLevel = false;
            f22.Dock = DockStyle.Fill;
            f22.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f22);
            f22.Show();
        }
    }
}
