using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itpm101
{
    public partial class ManageNot : Form
    {
        SqlConnection cona;
        public ManageNot()
        {
            InitializeComponent();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string mainconn = ConfigurationManager.ConnectionStrings["ITPM.Properties.Settings.masterConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            sqlconn.Open();

            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            //Object Primary_Field_Value = dataGridView1[1, this.dataGridView1.SelectedRows[0].Index].Value;

            //SqlCommand cmd = new SqlCommand("Delete from DetailsTable where ID='" + this.dataGridView1.SelectedRows[0].Index + "'", sqlconn);
            //cmd.ExecuteNonQuery();
            sqlconn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //string mainconn = ConfigurationManager.ConnectionStrings["ITPM.Properties.Settings.masterConnectionString"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);

            cona = ConnectionManager.GetConnection();
            cona.Open();

            SqlCommand cmd = cona.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM DetailsTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cona.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
