namespace hci
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.productDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logDBDataSet = new hci.LogDBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxitemname = new System.Windows.Forms.TextBox();
            this.txtboxsku = new System.Windows.Forms.TextBox();
            this.txtboxdescription = new System.Windows.Forms.TextBox();
            this.cmbvariant = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.insertbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxqnty = new System.Windows.Forms.TextBox();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.productDetailsTableAdapter = new hci.LogDBDataSetTableAdapters.ProductDetailsTableAdapter();
            this.productDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvprdtdtls = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprdtdtls)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productDetailsBindingSource
            // 
            this.productDetailsBindingSource.DataMember = "ProductDetails";
            this.productDetailsBindingSource.DataSource = this.logDBDataSet;
            // 
            // logDBDataSet
            // 
            this.logDBDataSet.DataSetName = "LogDBDataSet";
            this.logDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ItemName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "SKU:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Variant:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Description:";
            // 
            // txtboxitemname
            // 
            this.txtboxitemname.Location = new System.Drawing.Point(84, 47);
            this.txtboxitemname.Name = "txtboxitemname";
            this.txtboxitemname.Size = new System.Drawing.Size(211, 20);
            this.txtboxitemname.TabIndex = 14;
            this.txtboxitemname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxitemname_KeyPress);
            // 
            // txtboxsku
            // 
            this.txtboxsku.Location = new System.Drawing.Point(84, 110);
            this.txtboxsku.Name = "txtboxsku";
            this.txtboxsku.Size = new System.Drawing.Size(211, 20);
            this.txtboxsku.TabIndex = 16;
            this.txtboxsku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxsku_KeyPress);
            // 
            // txtboxdescription
            // 
            this.txtboxdescription.Location = new System.Drawing.Point(84, 178);
            this.txtboxdescription.Multiline = true;
            this.txtboxdescription.Name = "txtboxdescription";
            this.txtboxdescription.Size = new System.Drawing.Size(211, 55);
            this.txtboxdescription.TabIndex = 17;
            this.txtboxdescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxdescription_KeyPress);
            // 
            // cmbvariant
            // 
            this.cmbvariant.FormattingEnabled = true;
            this.cmbvariant.Location = new System.Drawing.Point(84, 146);
            this.cmbvariant.Name = "cmbvariant";
            this.cmbvariant.Size = new System.Drawing.Size(211, 21);
            this.cmbvariant.TabIndex = 18;
            this.cmbvariant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbvariant_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.insertbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtboxqnty);
            this.panel1.Controls.Add(this.Updatebtn);
            this.panel1.Controls.Add(this.cmbvariant);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.txtboxdescription);
            this.panel1.Controls.Add(this.txtboxsku);
            this.panel1.Controls.Add(this.txtboxitemname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 399);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(127, 301);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(84, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 71);
            this.button3.TabIndex = 34;
            this.button3.Text = "Available Items";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 33;
            // 
            // insertbtn
            // 
            this.insertbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.insertbtn.Location = new System.Drawing.Point(21, 239);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(81, 30);
            this.insertbtn.TabIndex = 31;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Total Item";
            // 
            // txtboxqnty
            // 
            this.txtboxqnty.Location = new System.Drawing.Point(84, 80);
            this.txtboxqnty.Name = "txtboxqnty";
            this.txtboxqnty.Size = new System.Drawing.Size(211, 20);
            this.txtboxqnty.TabIndex = 26;
            this.txtboxqnty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxqnty_KeyPress);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Updatebtn.Location = new System.Drawing.Point(108, 239);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(70, 30);
            this.Updatebtn.TabIndex = 28;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.deletebtn.Location = new System.Drawing.Point(184, 239);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(97, 30);
            this.deletebtn.TabIndex = 26;
            this.deletebtn.Text = "Archive";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // productDetailsTableAdapter
            // 
            this.productDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // productDetailsBindingSource1
            // 
            this.productDetailsBindingSource1.DataMember = "ProductDetails";
            this.productDetailsBindingSource1.DataSource = typeof(hci.LogDBDataSet);
            // 
            // dgvprdtdtls
            // 
            this.dgvprdtdtls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprdtdtls.Location = new System.Drawing.Point(301, 122);
            this.dgvprdtdtls.Name = "dgvprdtdtls";
            this.dgvprdtdtls.ReadOnly = true;
            this.dgvprdtdtls.RowHeadersWidth = 51;
            this.dgvprdtdtls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprdtdtls.Size = new System.Drawing.Size(348, 399);
            this.dgvprdtdtls.TabIndex = 27;
            this.dgvprdtdtls.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprdtdtls_CellClick);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Wheat;
            this.backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbtn.BackgroundImage")));
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.ForeColor = System.Drawing.Color.Wheat;
            this.backbtn.Location = new System.Drawing.Point(10, 81);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(42, 35);
            this.backbtn.TabIndex = 29;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 75);
            this.panel2.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(462, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "User";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(462, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 27);
            this.label7.TabIndex = 32;
            this.label7.Text = "Product Management";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(649, 522);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvprdtdtls);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Mangement";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprdtdtls)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxitemname;
        private System.Windows.Forms.TextBox txtboxsku;
        private System.Windows.Forms.TextBox txtboxdescription;
        private System.Windows.Forms.ComboBox cmbvariant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxqnty;
        private System.Windows.Forms.Button deletebtn;
        private LogDBDataSet logDBDataSet;
        private System.Windows.Forms.BindingSource productDetailsBindingSource;
        private LogDBDataSetTableAdapters.ProductDetailsTableAdapter productDetailsTableAdapter;
        private System.Windows.Forms.BindingSource productDetailsBindingSource1;
        private System.Windows.Forms.DataGridView dgvprdtdtls;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}