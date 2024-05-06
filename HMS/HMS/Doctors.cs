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

namespace HMS
{
    public partial class Doctors : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BURAK;Initial Catalog=HMSDb;Integrated Security=True;");

        private void getDoctorsFromDatabase()
        {
            sqlConnection.Open();
            string query = "SELECT * FROM doctors";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridViewDoctors.DataSource = dataset.Tables[0];
            sqlConnection.Close();
        }
        private void setData()
        {
            sqlConnection.Open();
            string query = "INSERT INTO doctors VALUES('"+textboxName.Text+"', '"+textboxAge.Text+"', '"+textboxDepartment.Text+"', '"+textboxYear.Text+"', '"+textboxPassword.Text+"')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Doctor successfully added");
            sqlConnection.Close();
            getDoctorsFromDatabase();
        }
        private void updateData()
        {
            sqlConnection.Open();
            string query = "UPDATE doctors SET doctorName='" + textboxName.Text + "', doctorAge='" + textboxAge.Text + "', doctorDepartment='" + textboxDepartment.Text + "', doctorYear='" + textboxYear.Text + "', doctorPassword='" + textboxPassword.Text + "' WHERE doctorName='"+textboxName.Text+"';";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Doctor successfully updated");
            sqlConnection.Close();
            getDoctorsFromDatabase();
        }
        private void deleteData()
        {
            sqlConnection.Open();
            string query = "DELETE FROM doctors WHERE doctorName='"+textboxName.Text+"';";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Doctor successfully deleted");
            sqlConnection.Close();
            getDoctorsFromDatabase();
        }

        public Doctors()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void buttonPatients_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
            this.Hide();
        }

        private void buttonMedicine_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine(); 
            medicine.Show();
            this.Hide();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            getDoctorsFromDatabase();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            setData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteData();
        }
    }
}
