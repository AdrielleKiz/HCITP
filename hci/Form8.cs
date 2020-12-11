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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void dgvprdtdtls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.SetValueForText1;
            label10.Text = Form1.Date;
        }
        private void Back(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 Orderform = new Form6();
            Orderform.Show();
        }
    }
}
