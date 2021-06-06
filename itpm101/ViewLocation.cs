using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace itpm101
{
    public partial class ViewLocation : Form
    {
        SqlConnection conn;
        int record_id;
        

        public ViewLocation()
        {
            InitializeComponent();
        }

        public void displaplaydetails()
        {
            conn= ConnectionManager.GetConnection();
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM location";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        
        }

        SqlConnection connecto;
        private void button2_Click(object sender, EventArgs e)
        {
            /*int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);*/


            connecto = ConnectionManager.GetConnection();
            connecto.Open();

            SqlCommand cmd = connecto.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd = new SqlCommand("delete from location where ID ='" + record_id + "' ", connecto);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sucessfully deleted ");
            connecto.Close();
            displaplaydetails();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            record_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            textBox10.Text = selectedRow.Cells[1].Value.ToString();
            textBox70.Text = selectedRow.Cells[2].Value.ToString();
            textBox60.Text = selectedRow.Cells[3].Value.ToString();
            comboBox40.Text = selectedRow.Cells[4].Value.ToString();
            comboBox20.Text = selectedRow.Cells[5].Value.ToString();
            comboBox30.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            displaplaydetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*panel2.Controls.Clear();
            Form3 f3 = new Form3();
            f3.TopLevel = false;
            f3.Dock = DockStyle.Fill;
            f3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(f3);
            f3.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLocation f1 = new AddLocation();
            f1.ShowDialog();
            this.Close();
        }

        SqlConnection connect;
        private void button4_Click(object sender, EventArgs e)
        {
            
            connect = ConnectionManager.GetConnection();

            connect.Open(); SqlCommand cmd = connect.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd = new SqlCommand("update location set Building_ID ='" + textBox10.Text + "',Lecture_Hall_ID ='" + textBox70.Text + "',Lab_ID ='" + textBox60.Text + "',Floor='" + comboBox40.SelectedItem + "',Lecture_Hall_Capacity ='" + comboBox20.SelectedItem + "',Lab_Capacity ='" +comboBox30.SelectedItem + "' where ID = '" + record_id + "'", connect);

            cmd.ExecuteNonQuery();

            MessageBox.Show("sucessfully updated ");

            connect.Close();

            displaplaydetails();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
























/* 
SqlConnection connect; 
update private void button2_Click(object sender, EventArgs e){
    student.Gid = comboBox1.SelectedItem + "." + textBox3.Text + "." + comboBox2.SelectedItem.ToString();
    textBox5.Text = student.Gid;
    student.Sgi = comboBox2.SelectedItem + "." + numericUpDown1.Value.ToString(); 
    textBox6.Text = student.Sgi; textBox3.Enabled = true;
    comboBox1.Enabled = true; 
    textBox5.Enabled = true; 
    comboBox2.Enabled = true; 
    button3.Enabled = true; 
try
  { 
        connect = ConnectionManager.GetConnection();
        connect.Open();
        SqlCommand cmd = connect.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd = new SqlCommand("update StudentGroup set AcademicYS ='" + comboBox1.SelectedItem + "',DegreeP='" + textBox3.Text + "',GroupN='" + comboBox2.SelectedItem + "',GroupId='" + textBox5.Text + "',SGroupId ='" + textBox6.Text + "',SGroupN='" + numericUpDown1.Value + "' where ID = '" + record_id + "'", connect); 
        cmd.ExecuteNonQuery();
        MessageBox.Show("sucessfully updated ");
        connect.Close(); disp_data();
   }
catch(Exception ex){
        MessageBox.Show(ex.Message);
   } 
} 
delete SqlConnection connection;
private void button3_Click(object sender, EventArgs e)
{
    try 
    { 
        connection = ConnectionManager.GetConnection();
        connection.Open(); 
        SqlCommand cmd = connection.CreateCommand(); 
        cmd.CommandType = CommandType.Text; 
        cmd = new SqlCommand("delete from StudentGroup where ID ='" + record_id + "' ", connection); 
        cmd.ExecuteNonQuery(); 
        MessageBox.Show("sucessfully deleted ");
        connection.Close(); 
        disp_data();
    } catch (Exception ex) {
        MessageBox.Show(ex.Message);
    }
}
*/