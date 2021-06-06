using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itpm101
{
    public partial class AddWorkingDays : Form
    {
        public bool check = false;
        public String monday, tuesday, wednesday, thursday, friday, saturday, sunday;
        public int noOfWrkDays, hours, minutes;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.noOfWrkDays = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.hours = Convert.ToInt32(numericUpDown2.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.minutes = Convert.ToInt32(numericUpDown3.Value);
        }

        SqlConnection cona;

        private void button1_Click(object sender, EventArgs e)
        {
            //string mainconn = ConfigurationManager.ConnectionStrings["ITPM.Properties.Settings.masterConnectionString"].ConnectionString;

            //SqlConnection sqlconn = new SqlConnection(mainconn);
            try
            {
                cona = ConnectionManager.GetConnection();
                cona.Open();
                // MessageBox.Show(con1.State.ToString());
            }

            catch (Exception ex)
            {

                MessageBox.Show(e.ToString());
            }

            //sqlconn.Open();

            string sqlquery = "insert into [dbo].[WorkingDaysHours] values('" + this.noOfWrkDays + "','" + this.monday + "', '" + this.tuesday + "','" + this.wednesday + "','" + this.thursday + "','" + this.friday + "','" + this.saturday + "','" + this.sunday + "','" + this.hours + "','" + this.minutes + "')";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, cona);
            //SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);

            sqlcomm.ExecuteNonQuery();
            MessageBox.Show("Saved");

            cona.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            check = checkBox7.Checked;
            checkBox7.Text = "Friday";
            this.friday = "Friday";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            check = checkBox2.Checked;
            checkBox2.Text = "Saturday";
            this.saturday = "Saturday";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            check = checkBox6.Checked;
            checkBox6.Text = "Sunday";
            this.sunday = "Sunday";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            check = checkBox4.Checked;
            checkBox4.Text = "Thursday";
            this.thursday = "Thursday";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            check = checkBox3.Checked;
            checkBox3.Text = "Wednesday";
            this.wednesday = "Wednesday";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            check = checkBox5.Checked;
            checkBox5.Text = "Tuesday";
            this.tuesday = "Tuesday";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            check = checkBox1.Checked;
            checkBox1.Text = "Monday";
            this.monday = "Monday";
        }

        
        public AddWorkingDays()
        {
            InitializeComponent();
            
        }

        
    }
}
