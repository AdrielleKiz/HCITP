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
        public static string Date = "Date: " + DateTime.Now.ToString("dddd, dd MMMM yyyy");
        public static string user_id = "";
        //Added unique permissions
        public static string add_users;
        public static string delete_users;
        public static string modify_user_permission;
        public static string view_dash_menu;
        public static string view_orders_menu;
        public static string view_products_menu;
        public static string view_employees_menu;
        public static string view_checkout_menu;
        public static string view_checkin_menu;
        public static string modify_checkout_details;
        public static string modify_checkin_details;
        public static string add_order;
        public static string modify_order_details;
        public static string delete_order;
        public static string add_product;
        public static string modify_product_details;
        public static string delete_product;
        public static string allow_ordering_product;
        public static string allow_checkout;



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
                    //retrieve user_id
                    string userid = "";
                    SQLiteConnection con = new SQLiteConnection(@"Data Source=Database.db ;Version=3;");
                    con.Open();
                    SQLiteCommand command = new SQLiteCommand();
                    command = con.CreateCommand();
                    command.CommandText = "SELECT UserID FROM UserInformation WHERE UserName = '"+this.usertxtbox.Text+"';";
                    SQLiteDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            userid = reader.GetValue(0).ToString();
                        }
                    user_id = userid;
                    //end of query
                    
                    //retrieve permissions
                        SQLiteCommand permcom = new SQLiteCommand();
                        permcom = con.CreateCommand();
                        permcom.CommandText = "select * FROM lib_permissions WHERE user_id = "+user_id+";";
                        SQLiteDataReader readperms = permcom.ExecuteReader();              
                        string 	addusers = " ";
                        string 	deleteusers = " ";
                        string 	modifyuserpermission = " ";
                        string 	viewdashmenu = " ";
                        string 	viewordersmenu = " ";
                        string 	viewproductsmenu = " ";
                        string 	viewemployeesmenu = " ";
                        string 	viewcheckoutmenu = " ";
                        string 	viewcheckinmenu = " ";
                        string 	modifycheckoutdetails = " ";
                        string 	modifycheckindetails = " ";
                        string 	addorder = " ";
                        string 	modifyorderdetails = " ";
                        string 	deleteorder = " ";
                        string 	addproduct = " ";
                        string 	modifyproductdetails = " ";
                        string 	deleteproduct = " ";
                        string 	alloworderingproduct = " ";
                        string 	allowcheckout = " ";

                        while (readperms.Read())
                        {
                            addusers = readperms.GetValue(1).ToString();
                            deleteusers = readperms.GetValue(2).ToString();
                            modifyuserpermission = readperms.GetValue(3).ToString();
                            viewdashmenu = readperms.GetValue(4).ToString();
                            viewordersmenu = readperms.GetValue(5).ToString();
                            viewproductsmenu = readperms.GetValue(6).ToString();
                            viewemployeesmenu = readperms.GetValue(7).ToString();
                            viewcheckoutmenu = readperms.GetValue(8).ToString();
                            viewcheckinmenu = readperms.GetValue(9).ToString();
                            modifycheckoutdetails = readperms.GetValue(10).ToString();
                            modifycheckindetails = readperms.GetValue(11).ToString();
                            addorder = readperms.GetValue(12).ToString();
                            modifyorderdetails = readperms.GetValue(13).ToString();
                            deleteorder = readperms.GetValue(14).ToString();
                            addproduct = readperms.GetValue(15).ToString();
                            modifyproductdetails = readperms.GetValue(16).ToString();
                            deleteproduct = readperms.GetValue(17).ToString();
                            alloworderingproduct = readperms.GetValue(18).ToString();
                            allowcheckout = readperms.GetValue(19).ToString();
                        }
                    add_users =	addusers;
                    delete_users = deleteusers;
                    modify_user_permission = modifyuserpermission;
                    view_dash_menu = viewdashmenu;
                    view_orders_menu = viewordersmenu;
                    view_products_menu = viewproductsmenu;
                    view_employees_menu = viewemployeesmenu;
                    view_checkout_menu = viewcheckoutmenu;
                    view_checkin_menu = viewcheckinmenu;
                    modify_checkout_details = modifycheckoutdetails;
                    modify_checkin_details = modifycheckindetails;
                    add_order = addorder;
                    modify_order_details = modifyorderdetails;
                    delete_order = deleteorder;
                    add_product = addproduct;
                    modify_product_details = modifyproductdetails;
                    delete_product = deleteproduct;
                    allow_ordering_product = alloworderingproduct;
                    allow_checkout = allowcheckout;

                    this.Visible = false;
                    if (usertxtbox.Text.Trim() == "admin" && passtxtbox.Text.Trim() == "admin") {
                        SetValueForText1 = usertxtbox.Text;
                        Form3 mainMenu = new Form3();
                        mainMenu.Show();
                        MessageBox.Show("Admin Login Successful");
                    }
                    else
                    {
                        SetValueForText1 = usertxtbox.Text;
                        Form6 Orderform = new Form6();
                        Orderform.Show();
                        MessageBox.Show("Login Successful");
                    }
                    
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
            
        }

        private void linkLblsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
