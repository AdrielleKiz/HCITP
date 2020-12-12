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

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.SetValueForText1;
            label10.Text = Form1.Date;
        }
    }
}
