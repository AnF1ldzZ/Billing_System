using BillingSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem.UI
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        categoriesDAL cdal = new categoriesDAL();
        productsDAL pdal = new productsDAL();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //Added Functionality to close this form
            this.Hide();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            //Display the Categories in Combobox
            DataTable cDt = cdal.Select();
            cmbCategories.DataSource = cDt;


            //Give the value member and display member for Combobox
            cmbCategories.DisplayMember = "title";
            cmbCategories.ValueMember = "title";
            

            //Disply all the products in Datagrid view when the form is loaded
            DataTable pdt = pdal.Select();
            dgvProducts.DataSource = pdt;       
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Display all the Product Based on Selected Category
            string category = cmbCategories.Text;

            DataTable dt=pdal.DisplayProductsByCategory(category);
            dgvProducts.DataSource = dt;

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //Display all the products when this button is clicked
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }
    }
}
