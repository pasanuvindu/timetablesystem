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
    public partial class ParallelSession : Form
    {
        public ParallelSession()
        {
            InitializeComponent();
        }





        //view
        SqlConnection parallelView;

        public void displayParallel_data()
        {
            try
            {
                parallelView = ConnectionManager.GetConnection();
                parallelView.Open();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



            SqlCommand cmd = parallelView.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Parallel_Session";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            comboBox1.DisplayMember = "Subject";
            comboBox1.DataSource = dt;
            parallelView.Close();

        }


        int Isload = 0;


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            displayParallel_data();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                parallelView = ConnectionManager.GetConnection();
                parallelView.Open();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



            SqlCommand cmd = parallelView.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Parallel_Session where Subject='" + comboBox1.Text.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;



            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

                if (Isload == 0)
                {
                    DataGridViewCheckBoxColumn datacheckbox = new DataGridViewCheckBoxColumn();
                    datacheckbox.HeaderText = "";
                    datacheckbox.Width = 30;
                    datacheckbox.Name = "Checkbox";
                    dataGridView1.Columns.Insert(0, datacheckbox);
                    Isload++;
                }
            }


            dataGridView1.DataSource = dt;
            parallelView.Close();

        }



        //delete method
        SqlConnection parallelDelete;

        void Delete_Data()
        {
            try
            {
                parallelDelete = ConnectionManager.GetConnection();


                if (parallelDelete.State != ConnectionState.Open)
                {
                    parallelDelete.Open();
                    string q = "delete from Parallel_Session where ID in (" + ids + ") ";
                    SqlCommand cmd = new SqlCommand(q, parallelDelete);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Deleted parallel Data");
                    displayParallel_data();
                    parallelDelete.Close();

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }





        string ids = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Checkbox"].Value);
                if (isSelected)
                {
                    if (i == 0)
                    {
                        ids += Convert.ToString(row.Cells["ID"].Value);
                        i++;
                    }
                    else
                    {
                        ids += "," + Convert.ToString(row.Cells["ID"].Value);
                    }
                }
            }


            if (ids != "")
            {

                if (MessageBox.Show("Do You Want to delete this ", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Delete_Data();
                }


                else
                {

                    MessageBox.Show("Not Deleted", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else
            {
                MessageBox.Show("please select a data");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            TimesAllocation ff6 = new TimesAllocation();
            ff6.Show();
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 & e.Value != null)
            {




                string su = Convert.ToString(e.Value);
                string sub = Convert.ToString(e.Value);

                if (sub == "Y1S1.IT.1")
                {


                    e.CellStyle.BackColor = Color.Red;
                }


                else if (sub == "Y1S1.IT.2")
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }


                else if (sub == "Y1S2.IT.1")
                {
                    e.CellStyle.BackColor = Color.Green;
                }

                else if (sub == "Y1S2.IT.2")
                {
                    e.CellStyle.BackColor = Color.Aqua;
                }

                else if (sub == "Y3S1.IM.1")
                {
                    e.CellStyle.BackColor = Color.Aqua;
                }

            }
        }
    }
}
