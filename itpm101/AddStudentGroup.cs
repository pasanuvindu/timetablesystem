using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using itpm101.StudentGroup;
using System.Data.SqlClient;

namespace itpm101
{
    public partial class AddStudentGroup : Form
    {
        private Student student = new Student();

        public AddStudentGroup()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudentGroup f2 = new ManageStudentGroup();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {

                comboBox1.Focus();
                MessageBox.Show("please enter academic year and semester", "error");

            }


            else if (textBox1.Text == String.Empty)
            {
                textBox2.Focus();
                MessageBox.Show("please enter the degree programme", "error");

            }

            else if (comboBox2.SelectedIndex == -1)
            {
                comboBox2.Focus();
                MessageBox.Show("please enter the group number", "error");
            }

          //  else if (textBox3.Text == String.Empty)
           // {
               // textBox2.Focus();
               // MessageBox.Show("please enter the Group id", "error");

           // }

            else 
            {

                student.Gid= comboBox1.SelectedItem + "." + textBox1.Text + "." + comboBox2.SelectedItem.ToString();
                textBox2.Text = student.Gid;

                student.Sgi = comboBox2.SelectedItem +"." + numericUpDown1.Value.ToString();
                textBox3.Text = student.Sgi;

                textBox3.Enabled = true;
                comboBox1.Enabled = true;
                textBox2.Enabled = true;
                comboBox2.Enabled = true;
                //button3.Enabled = false;

            }

            }
        //insert
        SqlConnection con;

        private void button2_Click(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex == -1)
            {

                comboBox1.Focus();
                MessageBox.Show("please enter academic year and semester", "error");

            }


            else if (textBox1.Text == String.Empty)
            {
                textBox2.Focus();
                MessageBox.Show("please enter the degree programme", "error");

            }

            else if (comboBox2.SelectedIndex == -1)
            {
                comboBox2.Focus();
                MessageBox.Show("please enter the group number", "error");
            }



            else
            {

                try
                {
                    con = ConnectionManager.GetConnection();
                    con.Open();
                   // MessageBox.Show(con.State.ToString());
                }

                catch (Exception ex)
                {

                    MessageBox.Show(e.ToString());
                }

                string q = "insert into StudentGroup(AcademicYS,DegreeP,GroupN,GroupId,SGroupId,SGroupN) values ('" + comboBox1.SelectedItem + "','" + textBox1.Text + "','" + comboBox2.SelectedItem + "','" + textBox2.Text + "','" + textBox3.Text + "','" + numericUpDown1.Value + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucessfully Saved Data");
                con.Close();


            }
   

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        //clear
        public void clear()
        {
            comboBox1.Text= "";
            textBox1.Text = "";
            comboBox2.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            numericUpDown1.Text = "";
           
        }


        private void button1_Click(object sender, EventArgs e)
        {

            clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
