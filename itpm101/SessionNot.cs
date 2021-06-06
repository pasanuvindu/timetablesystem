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
    public partial class SessionNot : Form
    {
        Object lecturer = null, groupp = null, subGroup = null, sessionID = null;
        String time;

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewNotAvailable form2 = new ViewNotAvailable();
            this.Close();
            form2.Show();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.cmbLecturer.SelectedIndex = -1;
            this.cmbGroup.SelectedIndex = -1;
            this.cmbSubGroup.SelectedIndex = -1;
            this.cmbSessionID.SelectedIndex = -1;
            this.textBox1.Text = " ";
        }

        public SessionNot()
        {
            InitializeComponent();
        }
        SqlConnection cona;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lecturer = cmbLecturer.SelectedItem;
            groupp = cmbGroup.SelectedItem;
            subGroup = cmbSubGroup.SelectedItem;
            sessionID = cmbSessionID.SelectedItem;
            time = textBox1.Text;


            if (lecturer == null || groupp == null || subGroup == null || sessionID == null)
            {
                MessageBox.Show("Please Select All Fields");
                return;
            }

            //
            try
            {
                cona = ConnectionManager.GetConnection();
                cona.Open();
                // MessageBox.Show(con1.State.ToString());
            }

            catch (Exception ex)
            {

                MessageBox.Show(e.ToString());
            }
            //string mainconn = ConfigurationManager.ConnectionStrings["ITPM.Properties.Settings.masterConnectionString"].ConnectionString;
            //ection sqlconn = new SqlConnection(mainconn);

            //sqlconn.Open();

            string sqlquery = "insert into [dbo].[Session_nota]  values('" + this.lecturer.ToString() + "','" + this.groupp.ToString() + "', '" + this.subGroup.ToString() + "','" + this.sessionID.ToString() + "')";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, cona);

            sqlcomm.ExecuteNonQuery();
            MessageBox.Show("Saved");

            cona.Close();

        }
    }
}
