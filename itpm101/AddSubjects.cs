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
    public partial class AddSubjects : Form
    {
        private SqlConnection con;

        public AddSubjects()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                MessageBox.Show(con.State.ToString());

                string q = "insert into itmp2(Offerd_Year,Offered_Semester,Subject_Name,Subject_Code,Number_Of_Lecture_Hours,Number_Of_Tutorial_Hours,Number_Of_Lab_Hours,Number_Of_Evaluation_Hours) values ('" + comboBox1.Text + "','" + comboBox2.SelectedItem + "','" + textBox1.Text + "','" + textBox2.Text + "','" + numericUpDown1.Text + "','" + numericUpDown2.Text + "','" + numericUpDown3.Text + "','" + numericUpDown4.Text + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("sucess");
                con.Close();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
           // textBox3.Clear();
            comboBox1.Text = string.Empty;
           // numericUpDown1.AccessibleDefaultActionDescription = string.Empty;
            MessageBox.Show("Clear");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSubject f4 = new ManageSubject();
            f4.Show();
        }
    }
}
