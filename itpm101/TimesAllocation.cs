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
    public partial class TimesAllocation : Form
    {
        public TimesAllocation()
        {
            InitializeComponent();
        }

        SqlConnection connsec;

        public void display_data()
        {
            try
            {
                connsec = ConnectionManager.GetConnection();
                connsec.Open();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



            SqlCommand cmd = connsec.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Add_Sessions";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt;
                dataGridView3.DataSource = dt;

                DataGridViewCheckBoxColumn datacheckbox = new DataGridViewCheckBoxColumn();
                DataGridViewCheckBoxColumn datacheckbox2 = new DataGridViewCheckBoxColumn();
                DataGridViewCheckBoxColumn datacheckbox3 = new DataGridViewCheckBoxColumn();

                datacheckbox.HeaderText = "";
                datacheckbox.Width = 30;
                datacheckbox.Name = "Checkbox";
                dataGridView1.Columns.Insert(0, datacheckbox);

                //for parallel view checkbox
                datacheckbox2.HeaderText = "";
                datacheckbox2.Width = 30;
                datacheckbox2.Name = "Checkbox2";
                dataGridView2.Columns.Insert(0, datacheckbox2);


                //for Nonoverlapping view checkbox
                datacheckbox3.HeaderText = "";
                datacheckbox3.Width = 30;
                datacheckbox3.Name = "Checkbox3";
                dataGridView3.Columns.Insert(0, datacheckbox3);

            }

            
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
            dataGridView3.DataSource = dt;
            connsec.Close();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            display_data();
        }



        int IsLoad2 = 0;

        //adding consective session part 
        SqlConnection consective;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                consective = ConnectionManager.GetConnection();
                consective.Open();
      
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



            foreach (DataGridViewRow dt in dataGridView1.Rows)
            {


                bool datacheckboxselected = Convert.ToBoolean(dt.Cells["Checkbox"].Value);

                if (datacheckboxselected)
                {

                    string q = "insert into Times_Allocation values (@Lecturer_f,@Lecture_s,@Subject_code,@Subject,@Tag,@Group_id,@Student_count,@Duration)";
                    SqlCommand cmd = new SqlCommand(q, consective);
                   
                    cmd.Parameters.AddWithValue("@Lecturer_f", dt.Cells[2].Value);
                    cmd.Parameters.AddWithValue("@Lecture_s", dt.Cells[3].Value);
                    cmd.Parameters.AddWithValue("@Subject_code", dt.Cells[4].Value);
                    cmd.Parameters.AddWithValue("@Subject", dt.Cells[5].Value);
                    cmd.Parameters.AddWithValue("@Tag", dt.Cells[6].Value);
                    cmd.Parameters.AddWithValue("@Group_id", dt.Cells[7].Value);
                    cmd.Parameters.AddWithValue("@Student_count", dt.Cells[8].Value);
                    cmd.Parameters.AddWithValue("@Duration", dt.Cells[9].Value);
                    cmd.ExecuteNonQuery();

                    if (IsLoad2 == 0)
                    {
                        MessageBox.Show("Sucessfully Saved consective Data");
                        IsLoad2++;
                        //consective.Close();
                    }
                }
               

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsecutiveSession f7 = new ConsecutiveSession();
            f7.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        //adding parallel session part 
        SqlConnection parallel;
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                parallel = ConnectionManager.GetConnection();
                parallel.Open();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



            string idss = string.Empty;

            foreach(DataGridViewRow row in dataGridView2.Rows)
            {

                bool isSelect = Convert.ToBoolean(row.Cells["Checkbox2"].Value);

                if (isSelect)
                {
                    idss += Environment.NewLine;
                    idss += (row.Cells["Subject_code"].Value);
                    //idss += (row.Cells["Tag"].Value);


                    string q = "insert into Parallel_Session values (@Lecturer_first,@Lecture_second,@Subject_code,@Subject,@Tag,@Group_id,@Student_count,@Duration)";
                    SqlCommand cmd = new SqlCommand(q, parallel);

                    cmd.Parameters.AddWithValue("@Lecturer_first", row.Cells[2].Value);
                    cmd.Parameters.AddWithValue("@Lecture_second", row.Cells[3].Value);
                    cmd.Parameters.AddWithValue("@Subject_code", row.Cells[4].Value);
                    cmd.Parameters.AddWithValue("@Subject", row.Cells[5].Value);
                    cmd.Parameters.AddWithValue("@Tag", row.Cells[6].Value);
                    cmd.Parameters.AddWithValue("@Group_id", row.Cells[7].Value);
                    cmd.Parameters.AddWithValue("@Student_count", row.Cells[8].Value);
                    cmd.Parameters.AddWithValue("@Duration", row.Cells[9].Value);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Sucessfully Saved "+ idss +"as parallel sessions");
                }
            }
           // MessageBox.Show(idss);
        }




        //search box
        SqlConnection Search;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            try
            {
                Search = ConnectionManager.GetConnection();
                Search.Open();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            SqlCommand cmd = Search.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Add_Sessions where Subject like '"+ textBox1.Text+"%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Search.Close();
            dataGridView1.DataSource = dt;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParallelSession f8 = new ParallelSession();
            f8.Show();
        }





        //search box2
        SqlConnection Searchparallel;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Searchparallel = ConnectionManager.GetConnection();
                Searchparallel.Open();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            SqlCommand cmd = Searchparallel.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Add_Sessions where Subject like '" + textBox2.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Searchparallel.Close();
            dataGridView2.DataSource = dt;
        }


        int IsLoad3 = 0;
        //add nonoverlap session
        SqlConnection nonoverlap;
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                nonoverlap = ConnectionManager.GetConnection();
                nonoverlap.Open();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



            foreach (DataGridViewRow roww in dataGridView3.Rows)
            {


                bool datacheckbox = Convert.ToBoolean(roww.Cells["Checkbox3"].Value);

                if (datacheckbox)
                {

                    string q = "insert into Non_Overlapping_Session values (@Lecturer_first,@Lecture_second,@Subject_code,@Subject,@Tag,@Group_id,@Student_count,@Duration)";
                    SqlCommand cmd = new SqlCommand(q, nonoverlap);

                    cmd.Parameters.AddWithValue("@Lecturer_first", roww.Cells[2].Value);
                    cmd.Parameters.AddWithValue("@Lecture_second", roww.Cells[3].Value);
                    cmd.Parameters.AddWithValue("@Subject_code", roww.Cells[4].Value);
                    cmd.Parameters.AddWithValue("@Subject", roww.Cells[5].Value);
                    cmd.Parameters.AddWithValue("@Tag", roww.Cells[6].Value);
                    cmd.Parameters.AddWithValue("@Group_id", roww.Cells[7].Value);
                    cmd.Parameters.AddWithValue("@Student_count", roww.Cells[8].Value);
                    cmd.Parameters.AddWithValue("@Duration", roww.Cells[9].Value);
                    cmd.ExecuteNonQuery();

                    if (IsLoad3 == 0)
                    {
                        MessageBox.Show("Sucessfully Saved nonoverlap Data");
                        IsLoad3++;
                        //consective.Close();
                    }
                }


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            NonOvelappingSession f9 = new NonOvelappingSession();
            f9.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
