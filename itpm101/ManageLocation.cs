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
    public partial class ManageLocation : Form
    {
        SqlConnection conn;
        int record_idd;

        string connectionstring = @" Data Source=MSI;Initial Catalog=itpm;Integrated Security=True; ";


        public ManageLocation()
        {
            InitializeComponent();
        }

        public void displaplaydetails()
        {
            conn = ConnectionManager.GetConnection();
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM sessions";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void ManageLocation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("Select *From sessions ", sqlcon);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
