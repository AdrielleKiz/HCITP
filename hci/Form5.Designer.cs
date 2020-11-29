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
            this.label1 = new System.Windows.Forms.Label();
            this.productDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logDBDataSet = new hci.LogDBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxitemname = new System.Windows.Forms.TextBox();
            this.txtboxsku = new System.Windows.Forms.TextBox();
            this.txtboxdescription = new System.Windows.Forms.TextBox();
            this.cmbvariant = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtboxqnty = new System.Windows.Forms.TextBox();
            this.ClrAllbtn = new System.Windows.Forms.Button();
            this.pnllstdtadd = new System.Windows.Forms.Panel();
            this.lbllstdtadd = new System.Windows.Forms.Label();
            this.pnltlpdt = new System.Windows.Forms.Panel();
            this.lbltlpdt = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.productDetailsTableAdapter = new hci.LogDBDataSetTableAdapters.ProductDetailsTableAdapter();
            this.productDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvprdtdtls = new System.Windows.Forms.DataGridView();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.insertbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnllstdtadd.SuspendLayout();
            this.pnltlpdt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprdtdtls)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT DETAILS";
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
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ItemName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "SKU:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Variant:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-5, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1123, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________________\r\n";
            // 
            // txtboxitemname
            // 
            this.txtboxitemname.Location = new System.Drawing.Point(80, 14);
            this.txtboxitemname.Name = "txtboxitemname";
            this.txtboxitemname.Size = new System.Drawing.Size(211, 20);
            this.txtboxitemname.TabIndex = 14;
            this.txtboxitemname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxitemname_KeyPress);
            // 
            // txtboxsku
            // 
            this.txtboxsku.Location = new System.Drawing.Point(80, 77);
            this.txtboxsku.Name = "txtboxsku";
            this.txtboxsku.Size = new System.Drawing.Size(211, 20);
            this.txtboxsku.TabIndex = 16;
            this.txtboxsku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxsku_KeyPress);
            // 
            // txtboxdescription
            // 
            this.txtboxdescription.Location = new System.Drawing.Point(80, 145);
            this.txtboxdescription.Multiline = true;
            this.txtboxdescription.Name = "txtboxdescription";
            this.txtboxdescription.Size = new System.Drawing.Size(211, 55);
            this.txtboxdescription.TabIndex = 17;
            this.txtboxdescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxdescription_KeyPress);
            // 
            // cmbvariant
            // 
            this.cmbvariant.FormattingEnabled = true;
            this.cmbvariant.Location = new System.Drawing.Point(80, 113);
            this.cmbvariant.Name = "cmbvariant";
            this.cmbvariant.Size = new System.Drawing.Size(211, 21);
            this.cmbvariant.TabIndex = 18;
            this.cmbvariant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbvariant_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExit.Location = new System.Drawing.Point(852, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txtboxqnty);
            this.panel1.Controls.Add(this.ClrAllbtn);
            this.panel1.Controls.Add(this.pnllstdtadd);
            this.panel1.Controls.Add(this.pnltlpdt);
            this.panel1.Controls.Add(this.cmbvariant);
            this.panel1.Controls.Add(this.txtboxdescription);
            this.panel1.Controls.Add(this.txtboxsku);
            this.panel1.Controls.Add(this.txtboxitemname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 405);
            this.panel1.TabIndex = 21;
            // 
            // txtboxqnty
            // 
            this.txtboxqnty.Location = new System.Drawing.Point(80, 47);
            this.txtboxqnty.Name = "txtboxqnty";
            this.txtboxqnty.Size = new System.Drawing.Size(211, 20);
            this.txtboxqnty.TabIndex = 26;
            this.txtboxqnty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxqnty_KeyPress);
            // 
            // ClrAllbtn
            // 
            this.ClrAllbtn.Location = new System.Drawing.Point(111, 206);
            this.ClrAllbtn.Name = "ClrAllbtn";
            this.ClrAllbtn.Size = new System.Drawing.Size(159, 30);
            this.ClrAllbtn.TabIndex = 25;
            this.ClrAllbtn.Text = "Clear All";
            this.ClrAllbtn.UseVisualStyleBackColor = true;
            this.ClrAllbtn.Click += new System.EventHandler(this.ClrAllbtn_Click);
            // 
            // pnllstdtadd
            // 
            this.pnllstdtadd.BackColor = System.Drawing.Color.RosyBrown;
            this.pnllstdtadd.Controls.Add(this.lbllstdtadd);
            this.pnllstdtadd.Location = new System.Drawing.Point(193, 287);
            this.pnllstdtadd.Name = "pnllstdtadd";
            this.pnllstdtadd.Size = new System.Drawing.Size(184, 115);
            this.pnllstdtadd.TabIndex = 24;
            // 
            // lbllstdtadd
            // 
            this.lbllstdtadd.AutoSize = true;
            this.lbllstdtadd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllstdtadd.Location = new System.Drawing.Point(20, 12);
            this.lbllstdtadd.Name = "lbllstdtadd";
            this.lbllstdtadd.Size = new System.Drawing.Size(152, 23);
            this.lbllstdtadd.TabIndex = 23;
            this.lbllstdtadd.Text = "Last Date Added:";
            // 
            // pnltlpdt
            // 
            this.pnltlpdt.BackColor = System.Drawing.Color.RosyBrown;
            this.pnltlpdt.Controls.Add(this.lbltlpdt);
            this.pnltlpdt.Location = new System.Drawing.Point(0, 287);
            this.pnltlpdt.Name = "pnltlpdt";
            this.pnltlpdt.Size = new System.Drawing.Size(187, 115);
            this.pnltlpdt.TabIndex = 22;
            this.pnltlpdt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltlpdt_Paint);
            // 
            // lbltlpdt
            // 
            this.lbltlpdt.AutoSize = true;
            this.lbltlpdt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltlpdt.Location = new System.Drawing.Point(25, 12);
            this.lbltlpdt.Name = "lbltlpdt";
            this.lbltlpdt.Size = new System.Drawing.Size(132, 23);
            this.lbltlpdt.TabIndex = 23;
            this.lbltlpdt.Text = "Total Products";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.deletebtn.Location = new System.Drawing.Point(614, 389);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(97, 30);
            this.deletebtn.TabIndex = 26;
            this.deletebtn.Text = "Delete";
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
            this.dgvprdtdtls.Location = new System.Drawing.Point(385, 61);
            this.dgvprdtdtls.Name = "dgvprdtdtls";
            this.dgvprdtdtls.ReadOnly = true;
            this.dgvprdtdtls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprdtdtls.Size = new System.Drawing.Size(542, 322);
            this.dgvprdtdtls.TabIndex = 27;
            this.dgvprdtdtls.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprdtdtls_CellClick);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Updatebtn.Location = new System.Drawing.Point(499, 389);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(109, 30);
            this.Updatebtn.TabIndex = 28;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.backbtn.Location = new System.Drawing.Point(717, 389);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(105, 30);
            this.backbtn.TabIndex = 29;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = ".";
            // 
            // insertbtn
            // 
            this.insertbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.insertbtn.Location = new System.Drawing.Point(384, 389);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(109, 30);
            this.insertbtn.TabIndex = 31;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click_1);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(933, 473);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.dgvprdtdtls);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Details- Stock  Database";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnllstdtadd.ResumeLayout(false);
            this.pnllstdtadd.PerformLayout();
            this.pnltlpdt.ResumeLayout(false);
            this.pnltlpdt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprdtdtls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxitemname;
        private System.Windows.Forms.TextBox txtboxsku;
        private System.Windows.Forms.TextBox txtboxdescription;
        private System.Windows.Forms.ComboBox cmbvariant;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnllstdtadd;
        private System.Windows.Forms.Label lbllstdtadd;
        private System.Windows.Forms.Panel pnltlpdt;
        private System.Windows.Forms.Label lbltlpdt;
        private System.Windows.Forms.Button ClrAllbtn;
        private System.Windows.Forms.TextBox txtboxqnty;
        private System.Windows.Forms.Button deletebtn;
        private LogDBDataSet logDBDataSet;
        private System.Windows.Forms.BindingSource productDetailsBindingSource;
        private LogDBDataSetTableAdapters.ProductDetailsTableAdapter productDetailsTableAdapter;
        private System.Windows.Forms.BindingSource productDetailsBindingSource1;
        private System.Windows.Forms.DataGridView dgvprdtdtls;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button insertbtn;
    }
}