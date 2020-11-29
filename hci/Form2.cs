using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace hci
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ExecuteQuery(string txtQuery)
        {
            SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=Database.db ;Version=3;");
            sqlCon.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = sqlCon.CreateCommand();
            cmd.CommandText = txtQuery;

            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }
            
        private void Add()
        {
            string txtSQLQuery = "INSERT INTO UserInformation (FirstName,Lastname,EmailAddress,Address,PhoneNumber,UserName,Password) values ('" + this.txbxFirstN.Text + "','" + this.txbxLastN.Text + "','" + this.txbxEmail.Text + "','" + this.txbxAdd.Text + "','" + this.txbxNum.Text + "','" + this.txbxUname.Text + "','" + this.txbxPass.Text + "'); INSERT INTO lib_permissions (add_users, delete_user, modify_user_permission, view_dash_menu, view_orders_menu, view_products_menu, view_employees_menu, view_checkout_menu, view_checkin_menu, modify_checkout_details, modify_checkin_details, add_order, modify_order_details, delete_order, add_product, modify_product_details, delete_product, allow_ordering_product, allow_checkout) VALUES (0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0);";
            ExecuteQuery(txtSQLQuery);
        }

        private void btnSave(object sender, EventArgs e)
        {

            if (txbxFirstN.Text.Trim() == "" && txbxLastN.Text.Trim() == "" && txbxEmail.Text.Trim() == "" && txbxAdd.Text.Trim() == "" && txbxNum.Text.Trim() == "" && txbxUname.Text.Trim() == "" && txbxPass.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields");
            }
            else
            {
                try
                {
                Add();
                MessageBox.Show("Sign Up Successful");
                this.Visible = false;
                Form1 loginForm = new Form1();
                loginForm.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        private void btnCancel(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
