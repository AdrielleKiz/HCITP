using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 Dashboard = new Form4();
            Dashboard.Show();
        }

        private void OrderDeets(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 OrderDeets = new Form6();
            OrderDeets.Show();
        }

        private void ProductDeets(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 ProductDeets = new Form5();
            ProductDeets.Show();
        }

        private void Emp(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 Emp = new Form7();
            Emp.Show();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 LoginPage = new Form1();
            LoginPage.Show();
        }

       private void Username(object sender, EventArgs e)
        {
            this.label3.Text = "User: " + Form1.SetValueForText1;
        }
    }
}
