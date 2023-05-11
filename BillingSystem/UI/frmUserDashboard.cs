using BillingSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class frmUserDashboard : Form
    {
        public frmUserDashboard()
        {
            InitializeComponent();
        }

        //Set a public static method to specify whether the form is purchase or sales
        public static string transactionType;
        private void frmUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();

        }

        private void frmUserDashboard_Load(object sender, EventArgs e)
        {
            IbILoggedInUser.Text = frmLogin.loggedIn;
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeaCusts DeaCust = new frmDeaCusts();
            DeaCust.Show();

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set value on transactionType static method
            transactionType = "PURCHASE";
            frmPurchaseAndSales purchase = new frmPurchaseAndSales();
            purchase.Show();
          
        }

        private void salesFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set the Value to transactionType method to sales
            transactionType = "SALES";
            frmPurchaseAndSales sales = new frmPurchaseAndSales();
            sales.Show();
            
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }
    }
}
