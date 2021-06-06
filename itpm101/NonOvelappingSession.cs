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
    public partial class NonOvelappingSession : Form
    {
        public NonOvelappingSession()
        {
            InitializeComponent();
        }



        //view
        SqlConnection nonoverlapView;

        public void displayNonoverlap_data()
        {
            try
            {
                nonoverlapView = ConnectionManager.GetConnection();
                nonoverlapView.Open();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



            SqlCommand cmd = nonoverlapView.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Non_Overlapping_Session";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            comboBox1.DisplayMember = "Subject";
            comboBox1.DataSource = dt;
            nonoverlapView.Close();

      

        }


        private void Form9_Load(object sender, EventArgs e)
        {
            displayNonoverlap_data();
        }


        int Isload = 0;
        SqlConnection nonoverlapCombo;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                nonoverlapCombo = ConnectionManager.GetConnection();
                nonoverlapCombo.Open();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



            SqlCommand cmd = nonoverlapCombo.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Non_Overlapping_Session where Subject='" + comboBox1.Text.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1P.DataSource = dt;



            if (dt.Rows.Count > 0)
            {
                dataGridView1P.DataSource = dt;

                if (Isload == 0)
                {
                    DataGridViewCheckBoxColumn datacheckbox = new DataGridViewCheckBoxColumn();
                    datacheckbox.HeaderText = "";
                    datacheckbox.Width = 30;
                    datacheckbox.Name = "Checkbox";
                    dataGridView1P.Columns.Insert(0, datacheckbox);
                    Isload++;
                }
            }


            dataGridView1P.DataSource = dt;
            nonoverlapCombo.Close();
        }





        //delete method
        SqlConnection nonoverlapDataDelete;

        void Delete_Data()
        {
            try
            {
                nonoverlapDataDelete = ConnectionManager.GetConnection();


                if (nonoverlapDataDelete.State != ConnectionState.Open)
                {
                    nonoverlapDataDelete.Open();
                    string q = "delete from Non_Overlapping_Session where ID in (" + ids + ") ";
                    SqlCommand cmd = new SqlCommand(q, nonoverlapDataDelete);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Deleted Nonoverlap Data");
                    displayNonoverlap_data();
                    nonoverlapDataDelete.Close();

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
            foreach (DataGridViewRow row in dataGridView1P.Rows)
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
            TimesAllocation fff6 = new TimesAllocation();
            fff6.Show();
        }

        private void dataGridView1P_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1P_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
