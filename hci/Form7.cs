using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Employee Management

namespace hci
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 Menu = new Form3();
            Menu.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.SetValueForText1;
            label10.Text = Form1.Date;
        }

        private void dgvemprecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
