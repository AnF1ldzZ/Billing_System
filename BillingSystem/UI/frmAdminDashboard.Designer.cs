namespace BillingSystem
{
    partial class frmAdminDashboard
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
            this.pnIFooter = new System.Windows.Forms.Panel();
            this.IbIFooter = new System.Windows.Forms.Label();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.uesrsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IbIUser = new System.Windows.Forms.Label();
            this.IbILoggedInUser = new System.Windows.Forms.Label();
            this.IbIAppFName = new System.Windows.Forms.Label();
            this.IblLName = new System.Windows.Forms.Label();
            this.IblSHead = new System.Windows.Forms.Label();
            this.pnIFooter.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnIFooter
            // 
            this.pnIFooter.BackColor = System.Drawing.Color.Teal;
            this.pnIFooter.Controls.Add(this.IbIFooter);
            this.pnIFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnIFooter.Location = new System.Drawing.Point(0, 669);
            this.pnIFooter.Name = "pnIFooter";
            this.pnIFooter.Size = new System.Drawing.Size(1320, 60);
            this.pnIFooter.TabIndex = 0;
            // 
            // IbIFooter
            // 
            this.IbIFooter.AutoSize = true;
            this.IbIFooter.BackColor = System.Drawing.Color.Transparent;
            this.IbIFooter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IbIFooter.ForeColor = System.Drawing.Color.White;
            this.IbIFooter.Location = new System.Drawing.Point(12, 20);
            this.IbIFooter.Name = "IbIFooter";
            this.IbIFooter.Size = new System.Drawing.Size(250, 19);
            this.IbIFooter.TabIndex = 0;
            this.IbIFooter.Text = "Developed By: Nathakakamon Triringkit";
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uesrsToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1320, 24);
            this.menuStripTop.TabIndex = 1;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // uesrsToolStripMenuItem
            // 
            this.uesrsToolStripMenuItem.Name = "uesrsToolStripMenuItem";
            this.uesrsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.uesrsToolStripMenuItem.Text = "Users";
            this.uesrsToolStripMenuItem.Click += new System.EventHandler(this.uesrsToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerAndCustomerToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionsToolStripMenuItem.Text = "Transaction";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // IbIUser
            // 
            this.IbIUser.AutoSize = true;
            this.IbIUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbIUser.Location = new System.Drawing.Point(12, 42);
            this.IbIUser.Name = "IbIUser";
            this.IbIUser.Size = new System.Drawing.Size(38, 17);
            this.IbIUser.TabIndex = 2;
            this.IbIUser.Text = "User:";
            // 
            // IbILoggedInUser
            // 
            this.IbILoggedInUser.AutoSize = true;
            this.IbILoggedInUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbILoggedInUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.IbILoggedInUser.Location = new System.Drawing.Point(47, 42);
            this.IbILoggedInUser.Name = "IbILoggedInUser";
            this.IbILoggedInUser.Size = new System.Drawing.Size(0, 17);
            this.IbILoggedInUser.TabIndex = 3;
            // 
            // IbIAppFName
            // 
            this.IbIAppFName.AutoSize = true;
            this.IbIAppFName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbIAppFName.Location = new System.Drawing.Point(570, 213);
            this.IbIAppFName.Name = "IbIAppFName";
            this.IbIAppFName.Size = new System.Drawing.Size(106, 37);
            this.IbIAppFName.TabIndex = 4;
            this.IbIAppFName.Text = "ANFILD";
            // 
            // IblLName
            // 
            this.IblLName.AutoSize = true;
            this.IblLName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblLName.Location = new System.Drawing.Point(668, 213);
            this.IblLName.Name = "IblLName";
            this.IblLName.Size = new System.Drawing.Size(99, 37);
            this.IblLName.TabIndex = 5;
            this.IblLName.Text = "STORE";
            // 
            // IblSHead
            // 
            this.IblSHead.AutoSize = true;
            this.IblSHead.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblSHead.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.IblSHead.Location = new System.Drawing.Point(506, 250);
            this.IblSHead.Name = "IblSHead";
            this.IblSHead.Size = new System.Drawing.Size(311, 25);
            this.IblSHead.TabIndex = 6;
            this.IblSHead.Text = "Billing and Inventory Management";
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 729);
            this.Controls.Add(this.IblSHead);
            this.Controls.Add(this.IblLName);
            this.Controls.Add(this.IbIAppFName);
            this.Controls.Add(this.IbILoggedInUser);
            this.Controls.Add(this.IbIUser);
            this.Controls.Add(this.pnIFooter);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.pnIFooter.ResumeLayout(false);
            this.pnIFooter.PerformLayout();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnIFooter;
        private System.Windows.Forms.Label IbIFooter;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem uesrsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Label IbIUser;
        private System.Windows.Forms.Label IbILoggedInUser;
        private System.Windows.Forms.Label IbIAppFName;
        private System.Windows.Forms.Label IblLName;
        private System.Windows.Forms.Label IblSHead;
        private System.Windows.Forms.ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
    }
}

