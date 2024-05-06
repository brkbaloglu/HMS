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
    public partial class Medicine : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BURAK;Initial Catalog=HMSDb;Integrated Security=True;");

        private void getMedicinesFromDatabase()
        {
            sqlConnection.Open();
            string query = "SELECT * FROM medicines";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridViewMedicines.DataSource = dataset.Tables[0];
            sqlConnection.Close();
        }
        private void setData()
        {
            sqlConnection.Open();
            string query = "INSERT INTO medicines VALUES('" + textboxName.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Medicine successfully added");
            sqlConnection.Close();
            getMedicinesFromDatabase();
        }
        
        private void deleteData()
        {
            sqlConnection.Open();
            string query = "DELETE FROM medicines WHERE medicineName='" + textboxName.Text + "';";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Medicine successfully deleted");
            sqlConnection.Close();
            getMedicinesFromDatabase();
        }
        public Medicine()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            setData();
        }

       

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteData();
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

        private void buttonPatients_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
            this.Hide();
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            getMedicinesFromDatabase();
        }
    }
}
