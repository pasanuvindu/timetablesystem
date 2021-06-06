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
    public partial class LocationNot : Form
    {
        Object room = null;
        String startTime = " ", endTime = " ";
        DateTime iDate;

        SqlConnection cona;

        public LocationNot()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.cmbSelectRoom.SelectedIndex = -1;
            this.txtEndTime.Text = " ";
            this.txtStartTime.Text = " ";
            this.dateTimePicker1.Value = DateTime.Today;
        }

        private void tab1_Sessions_Click(object sender, EventArgs e)
        {

        }

        private void tab_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {

            room = cmbSelectRoom.SelectedItem;
            startTime = txtStartTime.Text;
            endTime = txtEndTime.Text;
            iDate = dateTimePicker1.Value;

            if (room == null || startTime == " " || endTime == " ")
            {
                MessageBox.Show("Please Select All Fields");
                return;
            }

            //string mainconn = ConfigurationManager.ConnectionStrings["ITPM.Properties.Settings.masterConnectionString"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);

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

            // sqlconn.Open();

            string sqlquery = "insert into [dbo].[DetailsTable]  values('" + this.room.ToString() + "','" + this.iDate.ToString("MM/dd/yyyy") + "', '" + this.startTime.ToString() + "','" + this.endTime.ToString() + "')";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, cona);

            sqlcomm.ExecuteNonQuery();
            MessageBox.Show("Saved");

            cona.Close();
        }
    }
}
