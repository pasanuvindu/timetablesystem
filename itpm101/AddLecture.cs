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

namespace itpm101
{
    public partial class AddLecture : Form
    {
        private SqlConnection con;
        private Lecture lecture = new Lecture();
 
        public AddLecture()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            string q = "insert into itmp(Employee_ID,Lecturer_Name,Faculty,Department,CenterName,Buildin,Level,Rank) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + textBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();

           // this.Hide();
            //Form2 f2 = new Form2();
           // f2.ShowDialog();
            //this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox4.Text = string.Empty;
            comboBox3.Text = string.Empty;
            MessageBox.Show("Clear");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lecture.Rank = comboBox5.SelectedItem + "." + textBox1.Text.Trim(); 
            textBox3.Text = lecture.Rank;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageLecturer f3 = new ManageLecturer();
            f3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



