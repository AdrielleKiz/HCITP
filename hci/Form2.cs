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
            string txtSQLQuery = "INSERT INTO UserInformation (FirstName,Lastname,EmailAddress,Address,PhoneNumber,UserName,Password) values ('" + this.txbxFirstN.Text + "','" + this.txbxLastN.Text + "','" + this.txbxEmail.Text + "','" + this.txbxAdd.Text + "','" + this.txbxNum.Text + "','" + this.txbxUname.Text + "','" + this.txbxPass.Text + "');";
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
                Add();
                MessageBox.Show("Sign Up Successful");
                this.Visible = false;
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }
        private void btnCancel(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
