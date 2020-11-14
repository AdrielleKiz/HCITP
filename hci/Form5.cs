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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
    
        private void Exit(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 Menu = new Form3();
            Menu.Show();
        }

        private void ClrAllbtn_Click(object sender, EventArgs e)
        {
            txtboxitemname.Clear();
            txtboxqnty.Clear();
            txtboxsku.Clear();
            cmbvariant.Items.Clear();
            txtboxdescription.Clear();

        }

      
        private void dgvprdtdtls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            dgvprdtdtls.Rows.Add(txtboxitemname.Text,txtboxqnty.Text,txtboxsku.Text,cmbvariant.Text,txtboxdescription.Text);
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            int rowindex = dgvprdtdtls.CurrentCell.RowIndex;
            dgvprdtdtls.Rows.RemoveAt(rowindex);
         
        }

        private void vcmpltdtls_Click(object sender, EventArgs e)
        {
          
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
           
;        }

        private void txtboxqnty_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnltlpdt_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
