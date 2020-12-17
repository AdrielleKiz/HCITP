using System;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void User_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.SetValueForText1;
            label10.Text = Form1.Date;

            string query = "SELECT * FROM ProductDetails";
            SQLiteConnection Con = new SQLiteConnection("Data Source=Database.db;Version=3;");
            Con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, Con);
            //cmd.Parameters.AddWithValue("@textBox1", txbxUserOrder.Text);
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
                command.CommandText = "SELECT * FROM ProductDetails";
                SQLiteDataReader DR = command.ExecuteReader();
                while (DR.Read())
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dgvprdtdtls);
                    newRow.Cells[0].Value = DR.GetString(DR.GetOrdinal("ItemName"));
                    newRow.Cells[1].Value = DR["Quantity"].ToString();
                    newRow.Cells[2].Value = DR.GetString(DR.GetOrdinal("SKU"));
                    newRow.Cells[3].Value = DR.GetString(DR.GetOrdinal("Variant"));
                    newRow.Cells[4].Value = DR.GetString(DR.GetOrdinal("Description")); ;
                    //newRow.Cells[5].Value = ;
                    dgvprdtdtls.Rows.Add(newRow);

                }
                DR.Close();
            }
        }

        private void Back(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reLoad(object sender, EventArgs e)
        {
            dgvprdtdtls.Rows.Clear();
            label2.Text = Form1.SetValueForText1;
            label10.Text = Form1.Date;

            string query = "SELECT * FROM ProductDetails";
            SQLiteConnection Con = new SQLiteConnection("Data Source=Database.db;Version=3;");
            Con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, Con);
            //cmd.Parameters.AddWithValue("@textBox1", txbxUserOrder.Text);
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
                command.CommandText = "SELECT * FROM ProductDetails";
                SQLiteDataReader DR = command.ExecuteReader();
                while (DR.Read())
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dgvprdtdtls);
                    newRow.Cells[0].Value = DR.GetString(DR.GetOrdinal("ItemName"));
                    newRow.Cells[1].Value = DR["Quantity"].ToString();
                    newRow.Cells[2].Value = DR.GetString(DR.GetOrdinal("SKU"));
                    newRow.Cells[3].Value = DR.GetString(DR.GetOrdinal("Variant"));
                    newRow.Cells[4].Value = DR.GetString(DR.GetOrdinal("Description")); ;
                    //newRow.Cells[5].Value = ;
                    dgvprdtdtls.Rows.Add(newRow);

                }
                DR.Close();
            }
            dgvprdtdtls.Refresh();
        }

        private void Search(object sender, EventArgs e)
        {
            dgvprdtdtls.CurrentCell = null;
            dgvprdtdtls.AllowUserToAddRows = false;
            dgvprdtdtls.ClearSelection();
            dgvprdtdtls.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvprdtdtls.ReadOnly = true;
            

            try
            {
                foreach (DataGridViewRow row in dgvprdtdtls.Rows)
                {
                    MessageBox.Show(searchBox.Text);
                    var cellValue = row.Cells[0].Value;
                    if (cellValue != null && cellValue.ToString().ToUpper() == searchBox.Text.ToUpper())
                    {
                        row.Selected = true;
                        row.Visible = true;
                    }
                    else
                        row.Visible = false;

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
