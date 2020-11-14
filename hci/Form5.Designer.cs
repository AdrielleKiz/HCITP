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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvprdtdtls = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.txtboxitemname = new System.Windows.Forms.TextBox();
            this.txtboxqnty = new System.Windows.Forms.TextBox();
            this.txtboxsku = new System.Windows.Forms.TextBox();
            this.txtboxdescription = new System.Windows.Forms.TextBox();
            this.cmbvariant = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClrAllbtn = new System.Windows.Forms.Button();
            this.pnllstdtadd = new System.Windows.Forms.Panel();
            this.lbllstdtadd = new System.Windows.Forms.Label();
            this.pnltlpdt = new System.Windows.Forms.Panel();
            this.lbltlpdt = new System.Windows.Forms.Label();
            this.vcmpltdtls = new System.Windows.Forms.Button();
            this.insertbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprdtdtls)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnllstdtadd.SuspendLayout();
            this.pnltlpdt.SuspendLayout();
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
            // dgvprdtdtls
            // 
            this.dgvprdtdtls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprdtdtls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Quantity,
            this.SKU,
            this.Variant,
            this.Description});
            this.dgvprdtdtls.Location = new System.Drawing.Point(385, 56);
            this.dgvprdtdtls.Name = "dgvprdtdtls";
            this.dgvprdtdtls.Size = new System.Drawing.Size(542, 322);
            this.dgvprdtdtls.TabIndex = 2;
            this.dgvprdtdtls.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprdtdtls_CellContentClick);
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // SKU
            // 
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            // 
            // Variant
            // 
            this.Variant.HeaderText = "Variant";
            this.Variant.Name = "Variant";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
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
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.updatebtn.Location = new System.Drawing.Point(499, 389);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(102, 30);
            this.updatebtn.TabIndex = 10;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.deletebtn.Location = new System.Drawing.Point(607, 389);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(97, 30);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // txtboxitemname
            // 
            this.txtboxitemname.Location = new System.Drawing.Point(80, 14);
            this.txtboxitemname.Name = "txtboxitemname";
            this.txtboxitemname.Size = new System.Drawing.Size(211, 20);
            this.txtboxitemname.TabIndex = 14;
            // 
            // txtboxqnty
            // 
            this.txtboxqnty.Location = new System.Drawing.Point(80, 44);
            this.txtboxqnty.Name = "txtboxqnty";
            this.txtboxqnty.Size = new System.Drawing.Size(211, 20);
            this.txtboxqnty.TabIndex = 15;
            this.txtboxqnty.TextChanged += new System.EventHandler(this.txtboxqnty_TextChanged);
            // 
            // txtboxsku
            // 
            this.txtboxsku.Location = new System.Drawing.Point(80, 77);
            this.txtboxsku.Name = "txtboxsku";
            this.txtboxsku.Size = new System.Drawing.Size(211, 20);
            this.txtboxsku.TabIndex = 16;
            // 
            // txtboxdescription
            // 
            this.txtboxdescription.Location = new System.Drawing.Point(80, 145);
            this.txtboxdescription.Name = "txtboxdescription";
            this.txtboxdescription.Size = new System.Drawing.Size(211, 20);
            this.txtboxdescription.TabIndex = 17;
            // 
            // cmbvariant
            // 
            this.cmbvariant.FormattingEnabled = true;
            this.cmbvariant.Location = new System.Drawing.Point(80, 113);
            this.cmbvariant.Name = "cmbvariant";
            this.cmbvariant.Size = new System.Drawing.Size(211, 21);
            this.cmbvariant.TabIndex = 18;
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
            this.panel1.Controls.Add(this.ClrAllbtn);
            this.panel1.Controls.Add(this.pnllstdtadd);
            this.panel1.Controls.Add(this.pnltlpdt);
            this.panel1.Controls.Add(this.cmbvariant);
            this.panel1.Controls.Add(this.txtboxdescription);
            this.panel1.Controls.Add(this.txtboxsku);
            this.panel1.Controls.Add(this.txtboxqnty);
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
            // ClrAllbtn
            // 
            this.ClrAllbtn.Location = new System.Drawing.Point(101, 171);
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
            // vcmpltdtls
            // 
            this.vcmpltdtls.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vcmpltdtls.Location = new System.Drawing.Point(710, 389);
            this.vcmpltdtls.Name = "vcmpltdtls";
            this.vcmpltdtls.Size = new System.Drawing.Size(136, 30);
            this.vcmpltdtls.TabIndex = 22;
            this.vcmpltdtls.Text = "View Complete Details";
            this.vcmpltdtls.UseVisualStyleBackColor = false;
            this.vcmpltdtls.Click += new System.EventHandler(this.vcmpltdtls_Click);
            // 
            // insertbtn
            // 
            this.insertbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.insertbtn.Location = new System.Drawing.Point(384, 389);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(109, 30);
            this.insertbtn.TabIndex = 23;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(933, 473);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.vcmpltdtls);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvprdtdtls);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.ShowIcon = false;
            this.Text = "Product Details- Stock  Database";
            ((System.ComponentModel.ISupportInitialize)(this.dgvprdtdtls)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnllstdtadd.ResumeLayout(false);
            this.pnllstdtadd.PerformLayout();
            this.pnltlpdt.ResumeLayout(false);
            this.pnltlpdt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvprdtdtls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.TextBox txtboxitemname;
        private System.Windows.Forms.TextBox txtboxqnty;
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
        private System.Windows.Forms.Button vcmpltdtls;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}