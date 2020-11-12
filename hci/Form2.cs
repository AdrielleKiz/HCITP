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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave(object sender, EventArgs e)
        {
            MessageBox.Show("Sign Up Successful");
            this.Visible = false;
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
        private void btnCancel(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
