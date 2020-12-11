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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Back(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 Menu = new Form3();
            Menu.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
