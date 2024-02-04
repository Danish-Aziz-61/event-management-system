using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_DB__Project
{
    public partial class Form1 : Form
    {
        //OracleConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminManagement adminManagement = new AdminManagement();
            adminManagement.ShowDialog();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginform loginForm = new loginform();
            loginForm.ShowDialog();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
