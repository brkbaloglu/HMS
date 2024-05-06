using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class HMS : Form
    {
        public HMS()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textboxUsername.Text == "admin" || textboxPassword.Text == "123456")
            {
                HomePage homePage = new HomePage();
                this.Hide();
                homePage.Show();
            }
            else
            {
                MessageBox.Show("Username or password is not correct");
            }
        }
    }
}
