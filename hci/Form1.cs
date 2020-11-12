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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin(object sender, EventArgs e)
        {
            this.Visible = false;

            Form3 mainMenu = new Form3();
            mainMenu.Show();
            MessageBox.Show("Login Successful");

            //MessageBox.Show("Login Failed");
        }

        private void btnCancel(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkSignup(object sender, EventArgs e)
        {
            this.Visible = false;

            Form2 signUp = new Form2();
            signUp.Show();

        }

    }
}
