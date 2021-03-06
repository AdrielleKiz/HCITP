﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci
{
    public partial class Form6 : Form
    {
        private static string P1 = "Product 1";
        private static string P2 = "Product 2";
        private static string P3 = "Product 3";
        private static string p1 = "PD1";
        private static string p2 = "PD2";
        private static string p3 = "PD3";

        public Form6()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemList(object sender, EventArgs e)
        {
            Form8 List = new Form8();
            List.Show();
        }

        private void Logout(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 LoginPage = new Form1();
            LoginPage.Show();
        }

        private void row0()
        {
            int qt1 = Convert.ToInt32(dataGridView1.Rows[0].Cells[4].Value.ToString());
            int qtt1 = Convert.ToInt32(txbxQuantity.Text);
            int newVal1 = qt1 + qtt1;
            dataGridView1.Rows[0].Cells[4].Value = newVal1.ToString();

            int stk = Convert.ToInt32(dataGridView1.Rows[0].Cells[5].Value);
            int newStk = stk - qtt1;
            dataGridView1.Rows[0].Cells[5].Value = newStk;
            clear();
        }

        private void row1()
        {
            int qt1 = Convert.ToInt32(dataGridView1.Rows[1].Cells[4].Value.ToString());
            int qtt1 = Convert.ToInt32(txbxQuantity.Text);
            int newVal1 = qt1 + qtt1;
            dataGridView1.Rows[1].Cells[4].Value = newVal1.ToString();

            int stk = Convert.ToInt32(dataGridView1.Rows[1].Cells[5].Value);
            int newStk = stk - qtt1;
            dataGridView1.Rows[1].Cells[5].Value = newStk;
            clear();
        }

        private void row2()
        {
            int qt1 = Convert.ToInt32(dataGridView1.Rows[1].Cells[4].Value.ToString());
            int qtt1 = Convert.ToInt32(txbxQuantity.Text);
            int newVal1 = qt1 + qtt1;
            dataGridView1.Rows[2].Cells[4].Value = newVal1.ToString();
            int stk = Convert.ToInt32(dataGridView1.Rows[2].Cells[5].Value);
            int newStk = stk - qtt1;
            dataGridView1.Rows[2].Cells[5].Value = newStk;
            clear();
        }

        private void aElse()
        {
            int A = Convert.ToInt32(txbxQuantity.Text);
            int B = Convert.ToInt32(txbxQty.Text);
            int C = B - A;
            AddGrid(Form1.DateOrdered, txbxSKU.Text, txbxItemName.Text, txbxVariant.Text, Convert.ToInt32(txbxQuantity.Text), C);
            clear();
        }

        private void AddOrder(object sender, EventArgs e)
        {
            if (txbxUserOrder.Text.Trim() == "")
            {
                MessageBox.Show("Enter Product Name or SKU");
            }
            else if (txbxQuantity.Text.Trim() == "")
            {
                MessageBox.Show("Enter Quantity");
            }
            else
            {
                if (dataGridView1.Rows.Count == 0)
                {

                    int A = Convert.ToInt32(txbxQuantity.Text);
                    int B = Convert.ToInt32(txbxQty.Text);
                    int C = B - A;
                    AddGrid(Form1.DateOrdered, txbxSKU.Text, txbxItemName.Text, txbxVariant.Text, Convert.ToInt32(txbxQuantity.Text), C);
                    clear();
                }
                else if (dataGridView1.Rows.Count < 2)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (txbxUserOrder.Text.ToUpper() == P1.ToUpper() || txbxUserOrder.Text.ToUpper() == p1.ToUpper())
                        {
                            if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[1].Value.ToString().ToUpper())
                            {
                                int index = -1;

                                DataGridViewRow row = dataGridView1.Rows
                                    .Cast<DataGridViewRow>()
                                    .Where(r => r.Cells[2].Value.ToString().Equals("Product 1"))
                                    .First();

                                index = row.Index;

                                int qt = Convert.ToInt32(dataGridView1.Rows[index].Cells[4].Value);
                                int qtt = Convert.ToInt32(txbxQuantity.Text) + qt;
                                string newVal = qtt.ToString();
                                dataGridView1.Rows[index].Cells[4].Value = newVal;

                                int qtt1 = Convert.ToInt32(txbxQuantity.Text);
                                int stk = Convert.ToInt32(dataGridView1.Rows[0].Cells[5].Value);
                                int newStk = stk - qtt1;
                                dataGridView1.Rows[0].Cells[5].Value = newStk;
                                clear();
                            }
                            else
                            {
                                aElse();
                                break;
                            }
                        }
                        else if (txbxUserOrder.Text.ToUpper() == P2.ToUpper() || txbxUserOrder.Text.ToUpper() == p2.ToUpper())
                        {
                            if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[1].Value.ToString().ToUpper())
                            {
                                int index = -1;

                                DataGridViewRow row = dataGridView1.Rows
                                    .Cast<DataGridViewRow>()
                                    .Where(r => r.Cells[2].Value.ToString().Equals("Product 2"))
                                    .First();

                                index = row.Index;

                                int qt = Convert.ToInt32(dataGridView1.Rows[index].Cells[4].Value);
                                int qtt = Convert.ToInt32(txbxQuantity.Text) + qt;
                                string newVal = qtt.ToString();
                                dataGridView1.Rows[index].Cells[4].Value = newVal;
                                int qtt1 = Convert.ToInt32(txbxQuantity.Text);
                                int stk = Convert.ToInt32(dataGridView1.Rows[0].Cells[5].Value);
                                int newStk = stk - qtt1;
                                dataGridView1.Rows[0].Cells[5].Value = newStk;
                                clear();
                            }
                            else
                            {
                                aElse();
                                break;
                            }
                        }
                        else if (txbxUserOrder.Text.ToUpper() == P3.ToUpper() || txbxUserOrder.Text.ToUpper() == p3.ToUpper())
                        {
                            if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[1].Value.ToString().ToUpper())
                            {
                                int index = -1;

                                DataGridViewRow row = dataGridView1.Rows
                                    .Cast<DataGridViewRow>()
                                    .Where(r => r.Cells[2].Value.ToString().Equals("Product 3"))
                                    .First();

                                index = row.Index;

                                int qt = Convert.ToInt32(dataGridView1.Rows[index].Cells[4].Value);
                                int qtt = Convert.ToInt32(txbxQuantity.Text) + qt;
                                string newVal = qtt.ToString();
                                dataGridView1.Rows[index].Cells[4].Value = newVal;
                                int qtt1 = Convert.ToInt32(txbxQuantity.Text);
                                int stk = Convert.ToInt32(dataGridView1.Rows[0].Cells[5].Value);
                                int newStk = stk - qtt1;
                                dataGridView1.Rows[0].Cells[5].Value = newStk;
                                clear();
                            }
                            else
                            {
                                aElse();
                                break;
                            }
                        }
                        else
                        {
                            int A = Convert.ToInt32(txbxQuantity.Text);
                            int B = Convert.ToInt32(txbxQty.Text);
                            int C = B - A;
                            AddGrid(Form1.DateOrdered, txbxSKU.Text, txbxItemName.Text, txbxVariant.Text, Convert.ToInt32(txbxQuantity.Text), C);
                            clear();
                        }
                    }
                }
                else if (dataGridView1.Rows.Count < 3)
                {
                    if (txbxUserOrder.Text.ToUpper() == P1.ToUpper() || txbxUserOrder.Text.ToUpper() == p1.ToUpper())
                    {
                        if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[1].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[1].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[1].Cells[2].Value.ToString().Equals("Product 1"))
                            {
                                row1();
                            }
                        }
                        else if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[0].Cells[2].Value.ToString().Equals("Product 1"))
                            {
                                row0();
                            }
                        }
                        else
                        {
                            aElse();
                        }
                    }
                    else if (txbxUserOrder.Text.ToUpper() == P2.ToUpper() || txbxUserOrder.Text.ToUpper() == p2.ToUpper())
                    {
                        if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[1].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[1].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[1].Cells[2].Value.ToString().Equals("Product 2"))
                            {
                                row1();
                            }
                        }
                        else if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[0].Cells[2].Value.ToString().Equals("Product 2"))
                            {
                                row0();
                            }
                        }
                        else
                        {
                            aElse();
                        }
                    }
                    else if (txbxUserOrder.Text.ToUpper() == P3.ToUpper() || txbxUserOrder.Text.ToUpper() == p3.ToUpper())
                    {
                        if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[1].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[1].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[1].Cells[2].Value.ToString().Equals("Product 3"))
                            {
                                row1();
                            }
                        }
                        else if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[0].Cells[2].Value.ToString().Equals("Product 3"))
                            {
                                row0();
                            }
                        }
                        else
                        {
                            aElse();
                        }
                    }
                }
                else if (dataGridView1.Rows.Count < 4)
                {
                    if (txbxUserOrder.Text.ToUpper() == P1.ToUpper() || txbxUserOrder.Text.ToUpper() == p1.ToUpper())
                    {
                        if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[2].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[2].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[2].Cells[2].Value.ToString().Equals("Product 1"))
                            {
                                row2();
                            }
                        }
                        else if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[0].Cells[2].Value.ToString().Equals("Product 1"))
                            {
                                row0();
                            }
                        }
                        else if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[1].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[1].Cells[1].Value.ToString().ToUpper())
                        {
                            //string query = "UPDATE ProductDetails SET Quantity = @Column2" + this.dataGridView1.Columns["Quantity"];
                            if (dataGridView1.Rows[1].Cells[2].Value.ToString().Equals("Product 1"))
                            {
                                row1();
                            }
                        }
                        else
                        {
                            aElse();
                        }
                    }
                    else if (txbxUserOrder.Text.ToUpper() == P2.ToUpper() || txbxUserOrder.Text.ToUpper() == p2.ToUpper())
                    {
                        if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[2].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[2].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[2].Cells[2].Value.ToString().Equals("Product 2"))
                            {
                                row2();
                            }
                        }
                        else if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[0].Cells[2].Value.ToString().Equals("Product 2"))
                            {
                                row0();
                            }
                        }
                        else if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[1].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[1].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[1].Cells[2].Value.ToString().Equals("Product 2"))
                            {
                                row1();
                            }
                        }
                        else
                        {
                            aElse();
                        }
                    }
                    else if (txbxUserOrder.Text.ToUpper() == P3.ToUpper() || txbxUserOrder.Text.ToUpper() == p3.ToUpper())
                    {
                        if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[2].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[2].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[2].Cells[2].Value.ToString().Equals("Product 3"))
                            {
                                row2();
                            }
                        }
                        else if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[0].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[0].Cells[2].Value.ToString().Equals("Product 3"))
                            {
                                row0();
                            }
                        }
                        else if (txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[1].Cells[2].Value.ToString().ToUpper() || txbxUserOrder.Text.ToUpper() == dataGridView1.Rows[1].Cells[1].Value.ToString().ToUpper())
                        {
                            if (dataGridView1.Rows[1].Cells[2].Value.ToString().Equals("Product 3"))
                            {
                                row1();
                            }
                        }
                        else
                        {
                            aElse();
                        }
                    }
                }
            } 
        }

        private void AddGrid(string Date, string SKU, string ItemName, string Var, int Quantity, int Stock)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView1);
            newRow.Cells[0].Value = Date;
            newRow.Cells[1].Value = SKU;
            newRow.Cells[2].Value = ItemName;
            newRow.Cells[3].Value = Var;
            newRow.Cells[4].Value = Quantity;
            newRow.Cells[5].Value = Stock;
            dataGridView1.Rows.Add(newRow);
        }

        private void DeleteOrder(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                if (MessageBox.Show("Removing Order. Do you want to continue?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.SetValueForText1;
            label10.Text = Form1.Date;
        }

        private void txbxUserOrder_TextChanged(object sender, EventArgs e)
        {
            //string query = "SELECT * FROM ProductDetails WHERE ItemName= @textBox1";
            SQLiteConnection Con = new SQLiteConnection("Data Source=Database.db;Version=3;");
            Con.Open();
            if(txbxUserOrder.Text.Length < 4)
            {
                string query = "SELECT * FROM ProductDetails WHERE SKU= @textBox1";
                SQLiteCommand cmd = new SQLiteCommand(query, Con);
                cmd.Parameters.AddWithValue("@textBox1", txbxUserOrder.Text);
                SQLiteDataAdapter DA = new SQLiteDataAdapter(cmd);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                //SQLiteDataReader R = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                
                if (DT.Rows.Count > 0)
                {
                    SQLiteConnection con = new SQLiteConnection(@"Data Source=Database.db ;Version=3;");
                    con.Open();
                    SQLiteCommand command = new SQLiteCommand();
                    command = con.CreateCommand();
                    command.CommandText = "SELECT * FROM ProductDetails WHERE SKU = '" + this.txbxUserOrder.Text + "';";
                    SQLiteDataReader DR = command.ExecuteReader();
                        while (DR.Read())
                        {
                            txbxSKU.Text = DR.GetString(DR.GetOrdinal("SKU"));
                            txbxItemName.Text = DR.GetString(DR.GetOrdinal("ItemName"));
                            txbxVariant.Text = DR.GetString(DR.GetOrdinal("Variant"));
                            txbxQty.Text = DR["Quantity"].ToString();
                        }
                        DR.Close();
                }
            }
            else if(txbxUserOrder.Text.Length > 3)
            {
                string query = "SELECT * FROM ProductDetails WHERE ItemName= @textBox1";
                SQLiteCommand cmd = new SQLiteCommand(query, Con);
                cmd.Parameters.AddWithValue("@textBox1", txbxUserOrder.Text);
                SQLiteDataAdapter DA = new SQLiteDataAdapter(cmd);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                if (DT.Rows.Count > 0)
                {
                    SQLiteConnection con = new SQLiteConnection(@"Data Source=Database.db ;Version=3;");
                    con.Open();
                    SQLiteCommand command = new SQLiteCommand();
                    command = con.CreateCommand();
                    command.CommandText = "SELECT * FROM ProductDetails WHERE ItemName = '" + this.txbxUserOrder.Text + "';";
                    SQLiteDataReader DR = command.ExecuteReader();
                    while (DR.Read())
                    {
                        txbxSKU.Text = DR.GetString(DR.GetOrdinal("SKU"));
                        txbxItemName.Text = DR.GetString(DR.GetOrdinal("ItemName"));
                        txbxVariant.Text = DR.GetString(DR.GetOrdinal("Variant"));
                        txbxQty.Text = DR["Quantity"].ToString();
                    }
                    DR.Close();
                }
            }
        }

        private void CheckOut(object sender, EventArgs e)
        {
            string pd1 = "Product 1";
            string pd2 = "Product 2";
            string pd3 = "Product 3";
            string query = "UPDATE ProductDetails SET Quantity = :qty WHERE ItemName = :name";
            SQLiteConnection Con = new SQLiteConnection("Data Source=Database.db;Version=3;");
            Con.Open();
            SQLiteCommand cmd = new SQLiteCommand(Con);
            cmd.CommandText = query;

            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There are no Orders");
            }
            else if (dataGridView1.Rows.Count < 2)
            {
                if (dataGridView1.Rows[0].Cells["Column1"].Value.ToString() == pd1)
                {
                    cmd.Parameters.AddWithValue("name", "Product 1");
                    cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[0].Cells["Stock"].Value);
                    
                    cmd.ExecuteNonQuery();
                }
                else if (dataGridView1.Rows[0].Cells["Column1"].Value.ToString() == pd2)
                {
                    cmd.Parameters.AddWithValue("name", "Product 2");
                    cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[0].Cells["Stock"].Value);

                    cmd.ExecuteNonQuery();
                }
                else if (dataGridView1.Rows[0].Cells["Column1"].Value.ToString() == pd3)
                {
                    cmd.Parameters.AddWithValue("name", "Product 3");
                    cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[0].Cells["Stock"].Value);

                    cmd.ExecuteNonQuery();
                }

            }
            else if (dataGridView1.Rows.Count < 3)
            {
                if (dataGridView1.Rows[0].Cells["Column1"].Value.ToString() == pd1)
                {
                    cmd.Parameters.AddWithValue("name", "Product 1");
                    cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[0].Cells["Stock"].Value);
                    cmd.ExecuteNonQuery();

                    if (dataGridView1.Rows[1].Cells["Column1"].Value.ToString() == pd2)
                    {
                        cmd.Parameters.AddWithValue("name", "Product 2");
                        cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[1].Cells["Stock"].Value);
                        cmd.ExecuteNonQuery();
                    }
                    else if (dataGridView1.Rows[1].Cells["Column1"].Value.ToString() == pd3)
                    {
                        cmd.Parameters.AddWithValue("name", "Product 3");
                        cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[1].Cells["Stock"].Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                else if (dataGridView1.Rows[0].Cells["Column1"].Value.ToString() == pd2)
                {
                    cmd.Parameters.AddWithValue("name", "Product 2");
                    cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[0].Cells["Stock"].Value);
                    cmd.ExecuteNonQuery();

                    if (dataGridView1.Rows[1].Cells["Column1"].Value.ToString() == pd1)
                    {
                        cmd.Parameters.AddWithValue("name", "Product 1");
                        cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[1].Cells["Stock"].Value);
                        cmd.ExecuteNonQuery();
                    }
                    else if (dataGridView1.Rows[1].Cells["Column1"].Value.ToString() == pd3)
                    {
                        cmd.Parameters.AddWithValue("name", "Product 3");
                        cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[1].Cells["Stock"].Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                else if (dataGridView1.Rows[0].Cells["Column1"].Value.ToString() == pd3)
                {
                    cmd.Parameters.AddWithValue("name", "Product 3");
                    cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[0].Cells["Stock"].Value);
                    cmd.ExecuteNonQuery();

                    if (dataGridView1.Rows[1].Cells["Column1"].Value.ToString() == pd1)
                    {
                        cmd.Parameters.AddWithValue("name", "Product 1");
                        cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[1].Cells["Stock"].Value);
                        cmd.ExecuteNonQuery();
                    }
                    else if (dataGridView1.Rows[1].Cells["Column1"].Value.ToString() == pd2)
                    {
                        cmd.Parameters.AddWithValue("name", "Product 2");
                        cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[1].Cells["Stock"].Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else if (dataGridView1.Rows.Count < 4)
            {
                if (dataGridView1.Rows[0].Cells["Column1"].Value.ToString() == pd1)
                {
                    cmd.Parameters.AddWithValue("name", "Product 1");
                    cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[0].Cells["Stock"].Value);
                    cmd.ExecuteNonQuery();

                    if (dataGridView1.Rows[1].Cells["Column1"].Value.ToString() == pd2)
                    {
                        cmd.Parameters.AddWithValue("name", "Product 2");
                        cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[1].Cells["Stock"].Value);
                        cmd.ExecuteNonQuery();

                        if (dataGridView1.Rows[2].Cells["Column1"].Value.ToString() == pd3)
                        {
                            cmd.Parameters.AddWithValue("name", "Product 3");
                            cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[2].Cells["Stock"].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else if (dataGridView1.Rows[1].Cells["Column1"].Value.ToString() == pd3)
                    {
                        cmd.Parameters.AddWithValue("name", "Product 3");
                        cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[1].Cells["Stock"].Value);
                        cmd.ExecuteNonQuery();

                        if (dataGridView1.Rows[2].Cells["Column1"].Value.ToString() == pd2)
                        {
                            cmd.Parameters.AddWithValue("name", "Product 2");
                            cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[2].Cells["Stock"].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                else if (dataGridView1.Rows[0].Cells["Column1"].Value.ToString() == pd2)
                {
                    cmd.Parameters.AddWithValue("name", "Product 2");
                    cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[0].Cells["Stock"].Value);
                    cmd.ExecuteNonQuery();

                    if (dataGridView1.Rows[1].Cells["Column1"].Value.ToString() == pd1)
                    {
                        cmd.Parameters.AddWithValue("name", "Product 1");
                        cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[1].Cells["Stock"].Value);
                        cmd.ExecuteNonQuery();

                        if (dataGridView1.Rows[2].Cells["Column1"].Value.ToString() == pd3)
                        {
                            cmd.Parameters.AddWithValue("name", "Product 3");
                            cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[2].Cells["Stock"].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else if (dataGridView1.Rows[1].Cells["Column1"].Value.ToString() == pd3)
                    {
                        cmd.Parameters.AddWithValue("name", "Product 3");
                        cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[1].Cells["Stock"].Value);
                        cmd.ExecuteNonQuery();

                        if (dataGridView1.Rows[2].Cells["Column1"].Value.ToString() == pd1)
                        {
                            cmd.Parameters.AddWithValue("name", "Product 1");
                            cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[2].Cells["Stock"].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                else if (dataGridView1.Rows[0].Cells["Column1"].Value.ToString() == pd3)
                {
                    cmd.Parameters.AddWithValue("name", "Product 3");
                    cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[0].Cells["Stock"].Value);
                    cmd.ExecuteNonQuery();

                    if (dataGridView1.Rows[1].Cells["Column1"].Value.ToString() == pd1)
                    {
                        cmd.Parameters.AddWithValue("name", "Product 1");
                        cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[1].Cells["Stock"].Value);
                        cmd.ExecuteNonQuery();

                        if (dataGridView1.Rows[2].Cells["Column1"].Value.ToString() == pd2)
                        {
                            cmd.Parameters.AddWithValue("name", "Product 2");
                            cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[2].Cells["Stock"].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else if (dataGridView1.Rows[1].Cells["Column1"].Value.ToString() == pd2)
                    {
                        cmd.Parameters.AddWithValue("name", "Product 2");
                        cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[1].Cells["Stock"].Value);
                        cmd.ExecuteNonQuery();

                        if (dataGridView1.Rows[2].Cells["Column1"].Value.ToString() == pd1)
                        {
                            cmd.Parameters.AddWithValue("name", "Product 1");
                            cmd.Parameters.AddWithValue("qty", dataGridView1.Rows[2].Cells["Stock"].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            dataGridView1.Rows.Clear();

        }

        public void clear()
        {
            txbxItemName.Clear();
            txbxQty.Clear();
            txbxQuantity.Clear();
            txbxSKU.Clear();
            txbxUserOrder.Clear();
            txbxVariant.Clear();
        }

    }
}
