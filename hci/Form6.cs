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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 Menu = new Form3();
            Menu.Show();
        }

        private void ClrAll_Click(object sender, EventArgs e)
        {
            txtqntty.Clear();
            txtboxsku.Clear();
            txtboxUofM.Clear();
            txtdsptn.Clear();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            dgvOrderDtls.Rows.Add(txtqntty.Text,txtboxsku.Text,txtboxUofM.Text,txtdsptn.Text);
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            int rowindex = dgvOrderDtls.CurrentCell.RowIndex;
            dgvOrderDtls.Rows.RemoveAt(rowindex);
        }
    }
}
