namespace hci
{
    partial class Form6
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
            this.dgvOrderDtls = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClrAll = new System.Windows.Forms.Button();
            this.pnlLOD = new System.Windows.Forms.Panel();
            this.lvllOrD = new System.Windows.Forms.Label();
            this.pblOC = new System.Windows.Forms.Panel();
            this.lblOC = new System.Windows.Forms.Label();
            this.txtboxUofM = new System.Windows.Forms.TextBox();
            this.txtboxsku = new System.Windows.Forms.TextBox();
            this.txtqntty = new System.Windows.Forms.TextBox();
            this.txtdsptn = new System.Windows.Forms.TextBox();
            this.lbldscrptn = new System.Windows.Forms.Label();
            this.lblsku = new System.Windows.Forms.Label();
            this.lblqntty = new System.Windows.Forms.Label();
            this.lblUofM = new System.Windows.Forms.Label();
            this.dltbtn = new System.Windows.Forms.Button();
            this.updtbtn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.vcdbtn = new System.Windows.Forms.Button();
            this.insertbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDtls)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlLOD.SuspendLayout();
            this.pblOC.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderDtls
            // 
            this.dgvOrderDtls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDtls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Column2,
            this.Column1,
            this.Column4});
            this.dgvOrderDtls.Location = new System.Drawing.Point(423, 66);
            this.dgvOrderDtls.Name = "dgvOrderDtls";
            this.dgvOrderDtls.Size = new System.Drawing.Size(475, 305);
            this.dgvOrderDtls.TabIndex = 3;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Quantity";
            this.ItemName.Name = "ItemName";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SKU";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Unit of Measure";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "ORDER  DETAILS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.ClrAll);
            this.panel1.Controls.Add(this.pnlLOD);
            this.panel1.Controls.Add(this.pblOC);
            this.panel1.Controls.Add(this.txtboxUofM);
            this.panel1.Controls.Add(this.txtboxsku);
            this.panel1.Controls.Add(this.txtqntty);
            this.panel1.Controls.Add(this.txtdsptn);
            this.panel1.Controls.Add(this.lbldscrptn);
            this.panel1.Controls.Add(this.lblsku);
            this.panel1.Controls.Add(this.lblqntty);
            this.panel1.Controls.Add(this.lblUofM);
            this.panel1.Location = new System.Drawing.Point(8, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 395);
            this.panel1.TabIndex = 22;
            // 
            // ClrAll
            // 
            this.ClrAll.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClrAll.Location = new System.Drawing.Point(196, 151);
            this.ClrAll.Name = "ClrAll";
            this.ClrAll.Size = new System.Drawing.Size(125, 34);
            this.ClrAll.TabIndex = 28;
            this.ClrAll.Text = "Clear All";
            this.ClrAll.UseVisualStyleBackColor = false;
            this.ClrAll.Click += new System.EventHandler(this.ClrAll_Click);
            // 
            // pnlLOD
            // 
            this.pnlLOD.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlLOD.Controls.Add(this.lvllOrD);
            this.pnlLOD.Location = new System.Drawing.Point(196, 277);
            this.pnlLOD.Name = "pnlLOD";
            this.pnlLOD.Size = new System.Drawing.Size(199, 115);
            this.pnlLOD.TabIndex = 24;
            // 
            // lvllOrD
            // 
            this.lvllOrD.AutoSize = true;
            this.lvllOrD.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvllOrD.Location = new System.Drawing.Point(20, 12);
            this.lvllOrD.Name = "lvllOrD";
            this.lvllOrD.Size = new System.Drawing.Size(142, 23);
            this.lvllOrD.TabIndex = 23;
            this.lvllOrD.Text = "Last Order Date";
            // 
            // pblOC
            // 
            this.pblOC.BackColor = System.Drawing.Color.RosyBrown;
            this.pblOC.Controls.Add(this.lblOC);
            this.pblOC.Location = new System.Drawing.Point(4, 277);
            this.pblOC.Name = "pblOC";
            this.pblOC.Size = new System.Drawing.Size(186, 115);
            this.pblOC.TabIndex = 22;
            // 
            // lblOC
            // 
            this.lblOC.AutoSize = true;
            this.lblOC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOC.Location = new System.Drawing.Point(29, 12);
            this.lblOC.Name = "lblOC";
            this.lblOC.Size = new System.Drawing.Size(115, 23);
            this.lblOC.TabIndex = 23;
            this.lblOC.Text = "Order Count";
            // 
            // txtboxUofM
            // 
            this.txtboxUofM.Location = new System.Drawing.Point(144, 88);
            this.txtboxUofM.Name = "txtboxUofM";
            this.txtboxUofM.Size = new System.Drawing.Size(232, 20);
            this.txtboxUofM.TabIndex = 17;
            // 
            // txtboxsku
            // 
            this.txtboxsku.Location = new System.Drawing.Point(144, 56);
            this.txtboxsku.Name = "txtboxsku";
            this.txtboxsku.Size = new System.Drawing.Size(232, 20);
            this.txtboxsku.TabIndex = 16;
            // 
            // txtqntty
            // 
            this.txtqntty.Location = new System.Drawing.Point(144, 20);
            this.txtqntty.Name = "txtqntty";
            this.txtqntty.Size = new System.Drawing.Size(232, 20);
            this.txtqntty.TabIndex = 15;
            // 
            // txtdsptn
            // 
            this.txtdsptn.Location = new System.Drawing.Point(144, 125);
            this.txtdsptn.Name = "txtdsptn";
            this.txtdsptn.Size = new System.Drawing.Size(232, 20);
            this.txtdsptn.TabIndex = 14;
            // 
            // lbldscrptn
            // 
            this.lbldscrptn.AutoSize = true;
            this.lbldscrptn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldscrptn.Location = new System.Drawing.Point(18, 127);
            this.lbldscrptn.Name = "lbldscrptn";
            this.lbldscrptn.Size = new System.Drawing.Size(92, 18);
            this.lbldscrptn.TabIndex = 7;
            this.lbldscrptn.Text = "Description:";
            // 
            // lblsku
            // 
            this.lblsku.AutoSize = true;
            this.lblsku.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsku.Location = new System.Drawing.Point(18, 58);
            this.lblsku.Name = "lblsku";
            this.lblsku.Size = new System.Drawing.Size(45, 18);
            this.lblsku.TabIndex = 5;
            this.lblsku.Text = "SKU:";
            // 
            // lblqntty
            // 
            this.lblqntty.AutoSize = true;
            this.lblqntty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqntty.Location = new System.Drawing.Point(18, 22);
            this.lblqntty.Name = "lblqntty";
            this.lblqntty.Size = new System.Drawing.Size(68, 18);
            this.lblqntty.TabIndex = 4;
            this.lblqntty.Text = "Quantity:";
            // 
            // lblUofM
            // 
            this.lblUofM.AutoSize = true;
            this.lblUofM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUofM.Location = new System.Drawing.Point(17, 90);
            this.lblUofM.Name = "lblUofM";
            this.lblUofM.Size = new System.Drawing.Size(121, 18);
            this.lblUofM.TabIndex = 3;
            this.lblUofM.Text = "Unit of Measure:";
            // 
            // dltbtn
            // 
            this.dltbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dltbtn.Location = new System.Drawing.Point(606, 377);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(82, 30);
            this.dltbtn.TabIndex = 11;
            this.dltbtn.Text = "Delete";
            this.dltbtn.UseVisualStyleBackColor = false;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click);
            // 
            // updtbtn
            // 
            this.updtbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.updtbtn.Location = new System.Drawing.Point(513, 377);
            this.updtbtn.Name = "updtbtn";
            this.updtbtn.Size = new System.Drawing.Size(87, 30);
            this.updtbtn.TabIndex = 10;
            this.updtbtn.Text = "Update";
            this.updtbtn.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExit.Location = new System.Drawing.Point(823, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit);
            // 
            // vcdbtn
            // 
            this.vcdbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vcdbtn.Location = new System.Drawing.Point(694, 377);
            this.vcdbtn.Name = "vcdbtn";
            this.vcdbtn.Size = new System.Drawing.Size(123, 30);
            this.vcdbtn.TabIndex = 26;
            this.vcdbtn.Text = "View Complete Details";
            this.vcdbtn.UseVisualStyleBackColor = false;
            // 
            // insertbtn
            // 
            this.insertbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.insertbtn.Location = new System.Drawing.Point(423, 377);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(84, 30);
            this.insertbtn.TabIndex = 27;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 473);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.vcdbtn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updtbtn);
            this.Controls.Add(this.dgvOrderDtls);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Details - Stock Database";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDtls)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLOD.ResumeLayout(false);
            this.pnlLOD.PerformLayout();
            this.pblOC.ResumeLayout(false);
            this.pblOC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderDtls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLOD;
        private System.Windows.Forms.Label lvllOrD;
        private System.Windows.Forms.Panel pblOC;
        private System.Windows.Forms.Label lblOC;
        private System.Windows.Forms.Button dltbtn;
        private System.Windows.Forms.Button updtbtn;
        private System.Windows.Forms.TextBox txtboxsku;
        private System.Windows.Forms.TextBox txtqntty;
        private System.Windows.Forms.TextBox txtdsptn;
        private System.Windows.Forms.Label lbldscrptn;
        private System.Windows.Forms.Label lblsku;
        private System.Windows.Forms.Label lblqntty;
        private System.Windows.Forms.Label lblUofM;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button vcdbtn;
        private System.Windows.Forms.TextBox txtboxUofM;
        private System.Windows.Forms.Button ClrAll;
        private System.Windows.Forms.Button insertbtn;
    }
}