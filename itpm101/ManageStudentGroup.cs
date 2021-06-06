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
using itpm101.StudentGroup;

namespace itpm101
{
 
    public partial class ManageStudentGroup : Form
    {
        int record_id;

        private Student student = new Student();

        SqlConnection con;



        public ManageStudentGroup()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        //view

       SqlConnection conn;

        public void disp_data()
        {
            conn = ConnectionManager.GetConnection();
            conn.Open();

           SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from StudentGroup";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
           dataGridView1.DataSource = dt;
            conn.Close();

      }

       private void Form2_Load(object sender, EventArgs e)
        {
            disp_data();

        }

        SqlConnection connect;
        //update
        private void button2_Click(object sender, EventArgs e)
        {

                student.Gid = comboBox1.SelectedItem + "." + textBox3.Text + "." + comboBox2.SelectedItem.ToString();
                textBox5.Text = student.Gid;

                student.Sgi = comboBox2.SelectedItem + "." + numericUpDown1.Value.ToString();
                textBox6.Text = student.Sgi;

                textBox3.Enabled = true;
                comboBox1.Enabled = true;
                textBox5.Enabled = true;
                comboBox2.Enabled = true;
                button3.Enabled = true;


            try
            {

                connect = ConnectionManager.GetConnection();
                connect.Open();

                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd = new SqlCommand("update StudentGroup set AcademicYS ='" + comboBox1.SelectedItem + "',DegreeP='" + textBox3.Text + "',GroupN='" + comboBox2.SelectedItem + "',GroupId='" + textBox5.Text + "',SGroupId ='" + textBox6.Text + "',SGroupN='" + numericUpDown1.Value + "' where ID = '" + record_id + "'", connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("sucessfully updated ");
                connect.Close();
                disp_data();
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        //delete
        SqlConnection connection;
        private void button3_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Do You Want to delete this ","Remove Row",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
            {

                try
                {
                    connection = ConnectionManager.GetConnection();
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd = new SqlCommand("delete from  StudentGroup where ID ='" + record_id + "' ", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("sucessfully deleted ");
                    connection.Close();
                    disp_data();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

            }

            else
            {

                MessageBox.Show("Not Deleted", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        //to text boxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            record_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBox1.Text = selectedRow.Cells[1].Value.ToString();
            textBox3.Text = selectedRow.Cells[2].Value.ToString();
            comboBox2.Text = selectedRow.Cells[3].Value.ToString();
            textBox5.Text = selectedRow.Cells[4].Value.ToString();
            textBox6.Text = selectedRow.Cells[5].Value.ToString();
            numericUpDown1.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudentGroup f1 = new AddStudentGroup();
            f1.Show();
        }

        private void button5c_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
