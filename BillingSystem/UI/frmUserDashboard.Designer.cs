namespace BillingSystem
{
    partial class frmUserDashboard
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
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IblSHead = new System.Windows.Forms.Label();
            this.IblLName = new System.Windows.Forms.Label();
            this.IbIAppFName = new System.Windows.Forms.Label();
            this.IbILoggedInUser = new System.Windows.Forms.Label();
            this.IbIUser = new System.Windows.Forms.Label();
            this.menuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesFormsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1320, 24);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // salesFormsToolStripMenuItem
            // 
            this.salesFormsToolStripMenuItem.Name = "salesFormsToolStripMenuItem";
            this.salesFormsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.salesFormsToolStripMenuItem.Text = "Sales ";
            this.salesFormsToolStripMenuItem.Click += new System.EventHandler(this.salesFormsToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerAndCustomerToolStripMenuItem_Click);
            // 
            // IblSHead
            // 
            this.IblSHead.AutoSize = true;
            this.IblSHead.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblSHead.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.IblSHead.Location = new System.Drawing.Point(516, 245);
            this.IblSHead.Name = "IblSHead";
            this.IblSHead.Size = new System.Drawing.Size(311, 25);
            this.IblSHead.TabIndex = 11;
            this.IblSHead.Text = "Billing and Inventory Management";
            // 
            // IblLName
            // 
            this.IblLName.AutoSize = true;
            this.IblLName.BackColor = System.Drawing.Color.Transparent;
            this.IblLName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblLName.Location = new System.Drawing.Point(674, 208);
            this.IblLName.Name = "IblLName";
            this.IblLName.Size = new System.Drawing.Size(99, 37);
            this.IblLName.TabIndex = 10;
            this.IblLName.Text = "STORE";
            // 
            // IbIAppFName
            // 
            this.IbIAppFName.AutoSize = true;
            this.IbIAppFName.BackColor = System.Drawing.Color.Transparent;
            this.IbIAppFName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbIAppFName.Location = new System.Drawing.Point(577, 208);
            this.IbIAppFName.Name = "IbIAppFName";
            this.IbIAppFName.Size = new System.Drawing.Size(106, 37);
            this.IbIAppFName.TabIndex = 9;
            this.IbIAppFName.Text = "ANFILD";
            // 
            // IbILoggedInUser
            // 
            this.IbILoggedInUser.AutoSize = true;
            this.IbILoggedInUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbILoggedInUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.IbILoggedInUser.Location = new System.Drawing.Point(49, 37);
            this.IbILoggedInUser.Name = "IbILoggedInUser";
            this.IbILoggedInUser.Size = new System.Drawing.Size(0, 17);
            this.IbILoggedInUser.TabIndex = 8;
            // 
            // IbIUser
            // 
            this.IbIUser.AutoSize = true;
            this.IbIUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbIUser.Location = new System.Drawing.Point(14, 37);
            this.IbIUser.Name = "IbIUser";
            this.IbIUser.Size = new System.Drawing.Size(38, 17);
            this.IbIUser.TabIndex = 7;
            this.IbIUser.Text = "User:";
            // 
            // frmUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 729);
            this.Controls.Add(this.IblSHead);
            this.Controls.Add(this.IblLName);
            this.Controls.Add(this.IbIAppFName);
            this.Controls.Add(this.IbILoggedInUser);
            this.Controls.Add(this.IbIUser);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frmUserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmUserDashboard_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.Label IblSHead;
        private System.Windows.Forms.Label IblLName;
        private System.Windows.Forms.Label IbIAppFName;
        private System.Windows.Forms.Label IbILoggedInUser;
        private System.Windows.Forms.Label IbIUser;
        private System.Windows.Forms.ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
    }
}