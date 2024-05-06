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
    public partial class Patients : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BURAK;Initial Catalog=HMSDb;Integrated Security=True;");

        private void getPatientsFromDatabase()
        {
            sqlConnection.Open();
            string query = "SELECT * FROM patients";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridViewPatients.DataSource = dataset.Tables[0];
            sqlConnection.Close();
        }
        private void setData()
        {
            sqlConnection.Open();
            string query = "INSERT INTO patients VALUES('" + textboxName.Text + "', '" + textboxAge.Text + "', '" + textboxDisease.Text + "', '" + textboxDoctor.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Patient successfully added");
            sqlConnection.Close();
            getPatientsFromDatabase();
        }
        private void updateData()
        {
            sqlConnection.Open();
            string query = "UPDATE patients SET patientName='" + textboxName.Text + "', patientAge='" + textboxAge.Text + "', patientDisease='" + textboxDisease.Text + "', patientDoctor='" + textboxDoctor.Text + "' WHERE patientName='" + textboxName.Text + "';";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Patient successfully updated");
            sqlConnection.Close();
            getPatientsFromDatabase();
        }
        private void deleteData()
        {
            sqlConnection.Open();
            string query = "DELETE FROM patients WHERE patientName='" + textboxName.Text + "';";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Patient successfully deleted");
            sqlConnection.Close();
            getPatientsFromDatabase();
        }
        public Patients()
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

        private void buttonDoctors_Click(object sender, EventArgs e)
        {
            Doctors doctors = new Doctors();
            doctors.Show();
            this.Hide();
        }

        private void buttonMedicine_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine(); 
            medicine.Show();
            this.Hide();
        }

        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Patients_Load(object sender, EventArgs e)
        {
            getPatientsFromDatabase();
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
