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

namespace itpm101
{
    public partial class AddTags : Form
    {
        public AddTags()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        SqlConnection con1;
        private void button2_Click(object sender, EventArgs e)
        {




            if (textBox1SubjectN.Text == String.Empty)
            {

                textBox1SubjectN.Focus();
                MessageBox.Show("please enter the Subject Name", "error");

            }


            else if (textBox2SubjectC.Text == String.Empty)
            {
                textBox2SubjectC.Focus();
                MessageBox.Show("please enter the Subject Code", "error");

            }

            else if (comboBox1RT.SelectedIndex == -1)
            {
                comboBox1RT.Focus();
                MessageBox.Show("please enter the Related Tag", "error");
            }


            else
            {

                try
                {
                    con1 = ConnectionManager.GetConnection();
                    con1.Open();
                   // MessageBox.Show(con1.State.ToString());
                }

                catch (Exception ex)
                {

                    MessageBox.Show(e.ToString());
                }

                string q = "insert into Tag_Details(Subject_Name,Subject_Code,Related_Tag) values ('" + textBox1SubjectN.Text + "','" + textBox2SubjectC.Text + "','" + comboBox1RT.SelectedItem + "')";
                SqlCommand cmd = new SqlCommand(q, con1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucess Saved Data");
                con1.Close();


            }
 
        }



  //clear
        public void clear()
        {
            textBox1SubjectN.Text = "";
            textBox2SubjectC.Text = "";
            comboBox1RT.Text = "";
            button2.Enabled = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3nxt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageTags f4 = new ManageTags();
            f4.Show();
            
        }

        private void button5clo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
