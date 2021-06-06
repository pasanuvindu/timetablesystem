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
    public partial class AddLocation : Form
    {
        SqlConnection con;

        public AddLocation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

            string q = "insert into location (Building_ID ,Lecture_Hall_ID ,Lab_ID ,Floor ,Lecture_Hall_Capacity,Lab_Capacity) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox6.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();
        }

        private void AddLocation_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox6.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox1.Text = string.Empty;
            MessageBox.Show("Clear");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
