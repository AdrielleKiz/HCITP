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
        public static string Permissions = "";
        //Added unique permissions
        public static int viewdashboard;
        public static int add_users;
        public static int delete_users;
        public static int modify_user_permission;
        public static int view_dash_menu;
        public static int view_orders_menu;
        public static int products_menu;
        public static int view_employees_menu;
        public static int view_checkout_menu;
        public static int view_checkin_menu;
        public static int modify_checkout_details;
        public static int modify_checkin_details;
        public static int add_order;
        public static int modify_order_details;
        public static int delete_order;
        public static int add_product;
        public static int modify_product_details;
        public static int delete_product;
        public static int allow_ordering_product;
        public static int allow_checkout;
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
                    string perms = "";
                    SQLiteConnection con = new SQLiteConnection(@"Data Source=Database.db ;Version=3;");
                    con.Open();
                    SQLiteCommand command = new SQLiteCommand();
                    command = con.CreateCommand();
                    command.CommandText = "SELECT Permissions FROM UserInformation WHERE UserName = '"+this.usertxtbox.Text+"';";
                    SQLiteDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            perms = reader.GetValue(0).ToString();
                        }
                    Permissions = perms;
                    con.Close();
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
