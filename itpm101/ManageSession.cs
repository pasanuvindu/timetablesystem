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
    public partial class ManageSession : Form
    {
        SqlConnection con;
        int record_id;


        public ManageSession()
        {
            InitializeComponent();
        }

          public void displaydetails()
        {
            con = ConnectionManager.GetConnection();
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM Add_Sessions";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            con = ConnectionManager.GetConnection();
            con.Open();

            SqlCommand cmd1 = new SqlCommand("Select Lecturer_Name from itmp", con);

            SqlCommand cmd2 = new SqlCommand("Select Subject_Name,Subject_Code from itmp2", con);

            SqlCommand cmd3 = new SqlCommand("select GroupId from StudentGroup", con);



            DataTable dt = new DataTable();
            SqlDataAdapter data1 = new SqlDataAdapter(cmd1);
            data1.Fill(dt);

            foreach (DataRow dr1 in dt.Rows)
            {

                Lec1.Items.Add(dr1["Lecturer_Name"].ToString());
                Lec2.Items.Add(dr1["Lecturer_Name"].ToString());
            }


            DataTable dt1 = new DataTable();
            SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
            data2.Fill(dt1);

            foreach (DataRow dr2 in dt1.Rows)
            {

                SubjectCom.Items.Add(dr2["Subject_Name"].ToString());
                comboBox1.Items.Add(dr2["Subject_Code"].ToString());
            }

            DataTable dt2 = new DataTable();
            SqlDataAdapter data3 = new SqlDataAdapter(cmd3);
            data3.Fill(dt2);

            foreach (DataRow dr3 in dt2.Rows)
            {

                GroupCom.Items.Add(dr3["GroupId"].ToString());

            }

            con.Close();

            displaydetails();

        }

      

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            record_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            Lec1.Text = selectedRow.Cells[1].Value.ToString();
            Lec2.Text = selectedRow.Cells[2].Value.ToString();
            comboBox1.Text = selectedRow.Cells[3].Value.ToString();
            SubjectCom.Text = selectedRow.Cells[4].Value.ToString();
            Tag1.Text = selectedRow.Cells[5].Value.ToString();
            GroupCom.Text = selectedRow.Cells[6].Value.ToString();
            StudentCom.Text = selectedRow.Cells[7].Value.ToString();
            DurationTbox.Text = selectedRow.Cells[8].Value.ToString();
        }

        SqlConnection connect;
        private void button5_Click(object sender, EventArgs e)
        {
            {

                try
                {

                    connect = ConnectionManager.GetConnection();

                    connect.Open(); 

                    SqlCommand cmd = connect.CreateCommand();

                    cmd.CommandType = CommandType.Text;

                    cmd = new SqlCommand("update Add_Sessions set Lecturer_first ='" + Lec1.SelectedItem + "', Tag ='" + Tag1.SelectedItem + "', Lecturer_second ='" + Lec2.SelectedItem + "', Subject_code ='" + comboBox1.SelectedItem + "', Group_id = '" + GroupCom.SelectedItem + "', Student_count = '" + StudentCom.Text + "', Subject = '" + SubjectCom.SelectedItem + "', Duration = '" + DurationTbox.Text + "' where ID = '" + record_id + "'", connect);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("sucessfully updated ");

                    connect.Close();

                    displaydetails();

                }


                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message);
                }
            }
        }

        int recordd_id;
        SqlConnection connecto;
        private void button6_Click(object sender, EventArgs e)
        {
            connecto = ConnectionManager.GetConnection();
            connecto.Open();

            SqlCommand cmd = connecto.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd = new SqlCommand("delete from Add_Sessions where ID ='" + record_id + "' ", connecto);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucessfully deleted ");
            connecto.Close();
            displaydetails();
        }

        private void Lec1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
