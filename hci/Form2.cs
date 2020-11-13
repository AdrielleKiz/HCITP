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
            SQLiteConnection Con = new SQLiteConnection(@"Data Source = Database.db ;Version=3;");
            Con.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = Con.CreateCommand();
            cmd.CommandText = txtQuery;

            cmd.ExecuteNonQuery();
            Con.Close();
        }
        private void Add()
        {
            string txtSQLQuery = "INSERT INTO UserInformation (FirstName,Lastname,EmailAddress,Address,PhoneNumber,UserName,Password) values ('" + this.txbxFirstN.Text + "','" + this.txbxLastN.Text + "','" + this.txbxEmail.Text + "','" + this.txbxAdd.Text + "','" + this.txbxNum.Text + "','" + this.txbxUname.Text + "','" + this.txbxPass.Text + "')";
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
                string dbConnection = "Data Source=Database.db ;Version=3;";
                using (SQLiteConnection myConnection = new SQLiteConnection(dbConnection))
                {
                    SQLiteCommand sqlCommand = new SQLiteCommand("INSERT INTO UserInformation (FirstName,LastName,Address,PhoneNumber,EmailAddress) Values (@FirstName, @LastName,@Address,@PhoneNumber,@EmailAddress);", myConnection);
                    sqlCommand.Parameters.AddWithValue("@FirstName", txbxFirstN.Text);
                    sqlCommand.Parameters.AddWithValue("@Lastname", txbxLastN.Text);
                    sqlCommand.Parameters.AddWithValue("@EmailAddress", txbxEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@Address", txbxAdd.Text);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", txbxNum.Text);
/*                     sqlCommand.Parameters.AddWithValue("@UserName", txbxUname.Text);
                    sqlCommand.Parameters.AddWithValue("@Password", txbxPass.Text); */

                    myConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    
                }
                    

                    //string query = "INSERT INTO UserInformation (FirstName,Lastname,EmailAddress,Address,PhoneNumber,UserName,Password)";
                    //SQLiteConnection Con = new SQLiteConnection("Data Source=Database.db;Version=3;");
                    //Con.Open();
                    //SQLiteCommand cmd = new SQLiteCommand(query, Con);
                    //cmd.Parameters.AddWithValue("@FirstName", txbxFirstN.Text);
                    //cmd.Parameters.AddWithValue("@Lastname", txbxLastN.Text);
                    //cmd.Parameters.AddWithValue("@EmailAddress", txbxEmail.Text);
                    //cmd.Parameters.AddWithValue("@Address", txbxAdd.Text);
                    //cmd.Parameters.AddWithValue("@PhoneNumber", txbxNum.Text);
                    //cmd.Parameters.AddWithValue("@UserName", txbxUname.Text);
                    //cmd.Parameters.AddWithValue("@Password", txbxPass.Text);
                    //SQLiteDataAdapter DA = new SQLiteDataAdapter(cmd);
                    //cmd.ExecuteNonQuery();

                    MessageBox.Show("Sign Up Successful");
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
