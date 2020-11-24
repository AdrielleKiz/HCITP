namespace hci
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnProductDeets = new System.Windows.Forms.Button();
            this.btnOrderDeets = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 74);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock Managing System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDash.Location = new System.Drawing.Point(91, 130);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(167, 64);
            this.btnDash.TabIndex = 1;
            this.btnDash.Text = "DashBoard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.Dashboard);

            // 
            // btnProductDeets
            // 
            this.btnProductDeets.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProductDeets.Location = new System.Drawing.Point(91, 219);
            this.btnProductDeets.Name = "btnProductDeets";
            this.btnProductDeets.Size = new System.Drawing.Size(167, 64);
            this.btnProductDeets.TabIndex = 2;
            this.btnProductDeets.Text = "Products";
            this.btnProductDeets.UseVisualStyleBackColor = false;
            this.btnProductDeets.Click += new System.EventHandler(this.ProductDeets);
            // 
            // btnOrderDeets
            // 
            this.btnOrderDeets.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderDeets.Location = new System.Drawing.Point(358, 130);
            this.btnOrderDeets.Name = "btnOrderDeets";
            this.btnOrderDeets.Size = new System.Drawing.Size(167, 64);
            this.btnOrderDeets.TabIndex = 3;
            this.btnOrderDeets.Text = "Orders";
            this.btnOrderDeets.UseVisualStyleBackColor = false;
            this.btnOrderDeets.Click += new System.EventHandler(this.OrderDeets);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmployees.Location = new System.Drawing.Point(358, 219);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(167, 64);
            this.btnEmployees.TabIndex = 4;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.Emp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(214, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 64);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit);
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.LinkColor = System.Drawing.Color.Black;
            this.lnkLogout.Location = new System.Drawing.Point(15, 428);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(40, 13);
            this.lnkLogout.TabIndex = 7;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.Click += new System.EventHandler(this.Logout);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            this.label3.VisibleChanged += new System.EventHandler(this.Username);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnOrderDeets);
            this.Controls.Add(this.btnProductDeets);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Inventory Managing System: Main Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        if (Form1.view_dash_menu == "0")
            {
                this.btnDash.Enabled = false;
                this.btnEmployees.Enabled = false;
            }

        if (Form1.allow_checkout == "0")
            {
                
            }

        if (Form1.view_checkout_menu == "0")
            {

            }
        
        if (Form1.view_orders_menu == "0")
            {
                this.btnOrderDeets.Enabled = false;
            }
        if (Form1.view_products_menu == "0")
            {
                this.btnProductDeets.Enabled = false;
            }

        }
        

        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnProductDeets;
        private System.Windows.Forms.Button btnOrderDeets;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.Label label3;
    }
}