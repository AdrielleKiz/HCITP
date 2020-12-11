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
        public static string title = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard(object sender, EventArgs e)
        {
            if (Form1.view_dash_menu == "0")
            {
                MessageBox.Show("You do not have sufficient permission to execute this action", "You cannot do this", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Visible = false;
                Form4 Dashboard = new Form4();
                Dashboard.Show();
            }

        }

        private void Sales(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 Salesform = new Form4();
            Salesform.Show();
        }

        private void ProductManagement(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 Productform = new Form5();
            Productform.Show();

        }

        private void OrderManagement(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 Orderform = new Form6();
            Orderform.Show();

        }

        private void EmpManagement(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 Empform = new Form7();
            Empform.Show();
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
            switch (Form1.view_dash_menu)
            {
                case"0":
                title = "Employees";
                break;

                case"1":
                title = "Administrator";
                break;

                case"3":
                title = "Manager";
                break;              
            }
            
            this.label3.Text = "User: " + Form1.SetValueForText1 + "Perms: " + title;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
