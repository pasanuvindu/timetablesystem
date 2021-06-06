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
    public partial class AddSession : Form
    {
        SqlConnection con;

        public AddSession()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Lec1.Text = string.Empty;
            Lec2.Text = string.Empty;
            Tag1.Text = string.Empty;
            MessageBox.Show("Clear");
        }

       

        private void Form6_Load(object sender, EventArgs e)
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

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GroupCom.Text = string.Empty;
            SubjectCom.Text = string.Empty;
            StudentCom.Text = string.Empty;
            DurationTbox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
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

            string q = "insert into Add_Sessions(Lecturer_first,Tag,Lecturer_second,Subject_code,Group_id,Student_count,Subject,Duration) values ('" + Lec1.Text + "','" + Tag1.Text + "','" + Lec2.Text + "','" + comboBox1.Text + "','" + GroupCom.Text + "','" + StudentCom.Text + "','" + SubjectCom.Text + "','" + DurationTbox.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucess");
            con.Close();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Tag1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
