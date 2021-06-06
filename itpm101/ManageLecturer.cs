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
    public partial class ManageLecturer : Form
    {
        SqlConnection conn;
        int record_id;
       

        public ManageLecturer()
        {
            InitializeComponent();
        }

        public void displaplaydetails()
        {
            conn = ConnectionManager.GetConnection();
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM itmp";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            record_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            textBox1.Text = selectedRow.Cells[1].Value.ToString();
            textBox2.Text = selectedRow.Cells[2].Value.ToString();
            comboBox2.Text = selectedRow.Cells[3].Value.ToString();
            comboBox1.Text = selectedRow.Cells[4].Value.ToString();
            comboBox3.Text = selectedRow.Cells[5].Value.ToString();
            comboBox4.Text = selectedRow.Cells[6].Value.ToString();
            comboBox5.Text = selectedRow.Cells[7].Value.ToString();
            textBox3.Text = selectedRow.Cells[8].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }


        SqlConnection connecto;
        private void button1_Click(object sender, EventArgs e)
        {
            connecto = ConnectionManager.GetConnection();
            connecto.Open();

            SqlCommand cmd = connecto.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd = new SqlCommand("delete from itmp where ID ='" + record_id + "' ", connecto);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucessfully deleted ");
            connecto.Close();
            displaplaydetails();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            record_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            textBox1.Text = selectedRow.Cells[1].Value.ToString();
            textBox2.Text = selectedRow.Cells[2].Value.ToString();
            comboBox2.Text = selectedRow.Cells[3].Value.ToString();
            comboBox1.Text = selectedRow.Cells[4].Value.ToString();
            comboBox3.Text = selectedRow.Cells[5].Value.ToString();
            comboBox4.Text = selectedRow.Cells[6].Value.ToString();
            comboBox5.Text = selectedRow.Cells[7].Value.ToString();
            textBox3.Text = selectedRow.Cells[8].Value.ToString();
        }

        SqlConnection connect;
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                connect = ConnectionManager.GetConnection();

                connect.Open(); SqlCommand cmd = connect.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd = new SqlCommand("update itmp set Employee_ID ='" + textBox1.Text + "',Lecturer_Name ='" + textBox2.Text + "',Faculty ='" + comboBox2.SelectedItem + "',Department='" + comboBox1.SelectedItem + "',CenterName ='" + comboBox3.SelectedItem + "', Buildin='" + comboBox4.SelectedItem + "', Level='" + comboBox5.SelectedItem + "',Rank ='" + textBox3.Text + "' where ID = '" + record_id + "'", connect);

                cmd.ExecuteNonQuery();

                MessageBox.Show("sucessfully updated ");

                connect.Close();

                displaplaydetails();

            }


            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itpmDataSet.itmp' table. You can move, or remove it, as needed.
           // this.itmpTableAdapter.Fill(this.itpmDataSet.itmp);
            displaplaydetails();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}