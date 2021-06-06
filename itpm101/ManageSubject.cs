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
    public partial class ManageSubject : Form
    {

         int recordID;

        public ManageSubject()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            recordID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            comboBox1.Text = selectedRow.Cells[1].Value.ToString();
            comboBox2.Text = selectedRow.Cells[2].Value.ToString();
            textBox1.Text = selectedRow.Cells[3].Value.ToString();
            textBox2.Text = selectedRow.Cells[4].Value.ToString();
            numericUpDown1.Text = selectedRow.Cells[5].Value.ToString();
            numericUpDown2.Text = selectedRow.Cells[6].Value.ToString();
            numericUpDown3.Text = selectedRow.Cells[7].Value.ToString();
            numericUpDown4.Text = selectedRow.Cells[8].Value.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        SqlConnection connect;
        private void button3_Click(object sender, EventArgs e)
        {

            connect = ConnectionManager.GetConnection();

            connect.Open(); SqlCommand cmd = connect.CreateCommand();

            cmd.CommandType = CommandType.Text;

             cmd = new SqlCommand("update itmp2 set Offerd_Year ='" + comboBox1.SelectedItem + "',Offered_Semester ='" + comboBox2.SelectedItem + "',Subject_Name ='" + textBox1.Text + "',Subject_Code ='" + textBox2.Text + "',Number_Of_Lecture_Hours ='" + numericUpDown1.Value + "',Number_Of_Tutorial_Hours ='"+ numericUpDown2.Value + "',Number_Of_Lab_Hours ='" + numericUpDown3.Value + "',Number_Of_Evaluation_Hours ='" + numericUpDown4.Value + "' where ID = '" + recordID+ "'", connect);

            cmd.ExecuteNonQuery();

            MessageBox.Show("sucessfully updated ");

            connect.Close();

            displaplaydetails();
        }


       SqlConnection conn;
        public void displaplaydetails()
        {
            conn = ConnectionManager.GetConnection();
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM itmp2";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itpmDataSet.itmp2' table. You can move, or remove it, as needed.
            //this.itmp2TableAdapter.Fill(this.itpmDataSet.itmp2);
            displaplaydetails();
        }

        SqlConnection connecto;
        private void button1_Click(object sender, EventArgs e)
        {

            connecto = ConnectionManager.GetConnection();
            connecto.Open();

            SqlCommand cmd = connecto.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd = new SqlCommand("delete from itmp2 where ID ='" + recordID + "' ", connecto);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucessfully deleted data");
            connecto.Close();
            displaplaydetails();


        }
    }
}
