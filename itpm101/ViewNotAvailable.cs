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
    public partial class ViewNotAvailable : Form
    {
        public ViewNotAvailable()
        {
            InitializeComponent();
        }

        SqlConnection conn;

        private void ViewNotAvailable_Load(object sender, EventArgs e)
        {
            
                conn = ConnectionManager.GetConnection();
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * FROM Session_nota";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();


        }
    }
}
