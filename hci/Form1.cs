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

    public partial class Form1 : Form
    {
        public static string SetValueForText1 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin(object sender, EventArgs e)
        {
            if (usertxtbox.Text.Trim() == "" && passtxtbox.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields");
            }
            else
            {
                string query = "SELECT * FROM UserInformation WHERE UserName= @textBox1 AND Password= @textBox2";
                SQLiteConnection Con = new SQLiteConnection("Data Source=Database.db;Version=3;");
                Con.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, Con);
                cmd.Parameters.AddWithValue("@textBox1",usertxtbox.Text);
                cmd.Parameters.AddWithValue("@textBox2", passtxtbox.Text);
                SQLiteDataAdapter DA = new SQLiteDataAdapter(cmd);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                if(DT.Rows.Count > 0)
                {

                    SetValueForText1 = usertxtbox.Text;
                    this.Visible = false;
                    Form3 mainMenu = new Form3();
                    mainMenu.Show();
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    usertxtbox.Clear();
                    passtxtbox.Clear();
                    usertxtbox.Focus();

                }

                
            }

            
        }

        private void btnCancel(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkSignup(object sender, EventArgs e)
        {
            this.Visible = false;

            Form2 signUp = new Form2();
            signUp.Show();

        }

    }
}
