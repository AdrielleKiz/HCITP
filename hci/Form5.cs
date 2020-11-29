using System;

using System.Data;

using System.Data.SQLite;

using System.Windows.Forms;
namespace hci
{
    public partial class Form5 : Form
    {
       
        public Form5()
        {
            InitializeComponent();
        }
        SQLiteConnection con = new SQLiteConnection("Data Source=Database.db;Version=3");

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void ClrAllbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void pnltlpdt_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logDBDataSet.ProductDetails' table. You can move, or remove it, as needed.
            GetProductDetailsRecord();

        }
        private void GetProductDetailsRecord()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM ProductDetails",con);
            DataTable dt = new DataTable();
            con.Open();
            SQLiteDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dgvprdtdtls.DataSource = dt;
        }
        private void Clear()
        {
      
            txtboxitemname.Text= txtboxqnty.Text = txtboxsku.Text = cmbvariant.Text = txtboxdescription.Text = "";
            txtboxitemname.Focus();
        }
              
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string query = "DELETE FROM ProductDetails";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.CommandType = CommandType.Text;
                
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery(); 
                    con.Close();
                    MessageBox.Show("The data is deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetProductDetailsRecord();
                    Clear();
                }
                catch (Exception eex)
                {
                    MessageBox.Show(eex.Message);
                } finally 
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }


            }
            else
            {
                MessageBox.Show("Please select an ItemName to delete", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvprdtdtls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                
                txtboxitemname.Text = dgvprdtdtls.SelectedRows[0].Cells[0].Value.ToString();
                txtboxqnty.Text= dgvprdtdtls.SelectedRows[0].Cells[1].Value.ToString();
                txtboxsku.Text= dgvprdtdtls.SelectedRows[0].Cells[2].Value.ToString();
                cmbvariant.Text= dgvprdtdtls.SelectedRows[0].Cells[3].Value.ToString();
                txtboxdescription.Text= dgvprdtdtls.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
           if (IsValid())
           
            {
                string query = "UPDATE ProductDetails SET ItemName= @ItemName, Quantity= @Quantity, SKU= @SKU, Variant= @Variant, Description= @Description";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ItemName",txtboxitemname.Text.Trim());
                cmd.Parameters.AddWithValue("@Quantity",txtboxqnty.Text.Trim());
                cmd.Parameters.AddWithValue("@SKU",txtboxsku.Text.Trim());
                cmd.Parameters.AddWithValue("@Variant",cmbvariant.Text.Trim());
                cmd.Parameters.AddWithValue("@Description",txtboxdescription.Text.Trim());
               
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The data is updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetProductDetailsRecord();
                    Clear();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
               MessageBox.Show("Please select an ItemName to update this information", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 Menu = new Form3();
            Menu.Show();
        }

        private void txtboxqnty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
           if (!Char.IsDigit(ch)&& ch != 8 && ch!=46)
            {
                e.Handled = true;
            }

        }

        private void txtboxitemname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbvariant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtboxsku_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtboxdescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private bool IsValid()
        {
            if (txtboxitemname.Text == string.Empty)
            {
                MessageBox.Show("ItemName is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void insertbtn_Click_1(object sender, EventArgs e)
        {

            if (IsValid())
            {

                string query = "INSERT INTO ProductDetails VALUES (@ItemName,@Quantity,@SKU,@Variant,@Description)";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ItemName",txtboxitemname.Text);
                cmd.Parameters.AddWithValue("@Quantity", txtboxqnty.Text);
                cmd.Parameters.AddWithValue("@SKU", txtboxsku.Text);
                cmd.Parameters.AddWithValue("@Variant", cmbvariant.Text);
                cmd.Parameters.AddWithValue("@Description", txtboxdescription.Text);
                try
                {

                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("The data is sucessfully Inserted in the database", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetProductDetailsRecord();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
    }
}
