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
    public partial class ManageTags : Form
    {

        int record_Id;

        public ManageTags()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //view

        SqlConnection con2;

        public void display_data()
        {
            con2 = ConnectionManager.GetConnection();
            con2.Open();

            SqlCommand cmd = con2.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Tag_Details";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con2.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            display_data();
        }

        //to text box
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index2 = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index2];
            record_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox2F4Sn.Text = selectedRow.Cells[1].Value.ToString();
            textBox3F4Sc.Text = selectedRow.Cells[2].Value.ToString();
            comboBox1F4R.Text = selectedRow.Cells[3].Value.ToString();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTags f3 = new AddTags();
            f3.Show();
        }


        SqlConnection con3;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                con3 = ConnectionManager.GetConnection();
                con3.Open();

                SqlCommand cmd = con3.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd = new SqlCommand("update Tag_Details  set  Subject_Name ='" + textBox2F4Sn.Text + "',Subject_Code ='" +textBox3F4Sc.Text + "',Related_Tag='" + comboBox1F4R.SelectedItem + "' where ID = '" + record_Id + "'", con3);
                cmd.ExecuteNonQuery();
                MessageBox.Show("sucessfully updated ");
                con3.Close();
                display_data();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        SqlConnection con4;
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to delete this ", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                try
                {
                    con4 = ConnectionManager.GetConnection();
                    con4.Open();

                    SqlCommand cmd = con4.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd = new SqlCommand("delete from  Tag_Details where ID ='" + record_Id + "' ", con4);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("sucessfully deleted ");
                    con4.Close();
                    display_data();

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3F4Sc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1F4R_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
