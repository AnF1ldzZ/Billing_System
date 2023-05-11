using BillingSystem.BLL;
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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
           // Add code to hide this form
           this.Hide();
        }

        categoriesDAL cdal = new categoriesDAL();
        productsBLL p = new productsBLL();
        productsDAL pdal = new productsDAL();
        userDAL udal = new userDAL();   
        private void frmProducts_Load(object sender, EventArgs e)
        {
            //Creating Data Table to hold the categories from Database
            DataTable categoriesDT = cdal.Select();
            //Specify DataSource for Category Combobox
            cmbCategory.DataSource = categoriesDT;
            //Specify Display Member and Value Member for ComboBox
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            //Load all the Products in Data Grid View
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get All The Values from Product From
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;
            //Getting username of logged in User
            String loggedUsr = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUsr);

            p.added_by = usr.id;

            //Create Boolen varible to check if the product is added successfully or not 
            bool success = pdal.Insert(p); 
            //if the product is added successfully then the value of success will be true else it will be false
            if(success == true)
            {
                //Product Inserted Successfully
                MessageBox.Show("Product Added Successfully");
                //Calling the clear Method
                Clear();
                //Refreshing Data Grid View
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;    
            }
            else
            {
                //Failed to Add New Product
                MessageBox.Show("Failed to Add New Product");
            }
        }
        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "";
            txtSearch.Text = "";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Create integer varible to know which product was clicked
            int rowIndex = e.RowIndex;
            //Display the Value on Respective TextBoxes
            txtID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get The Value from UI or Product Form
            p.id = int.Parse(txtID.Text);
            p.name = txtName.Text;  
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date= DateTime.Now;

            //Getting Username of logged in user for added by 
            String loggedUsr = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUsr);

            p.added_by = usr.id;

            //Create a boolean varible to check if the product is updated or not
            bool success = pdal.Update(p);

            //If the product is updated successfully then the value of success will be true else it will be false
            if (success == true )
            {
                //Product updated Successsfully
                MessageBox.Show("Product Successfully Updated");
                Clear();
                //Refresh the Data GRid View
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                //Failed to Update Product
                MessageBox.Show("Failed to Update Product");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get the ID of the Product to be deleted
            p.id = int.Parse (txtID.Text);

            //Create Bool Varible to check if the product is deleted or not
            bool success =pdal.Dalete(p);

            //If Product is deleted successfully then the value of success will true else it will be false
            if(success == true ) 
            {
                //Product Successfully Deleted 
                MessageBox.Show("Product successfully deleted");
                Clear();
                //Refresh Data Grid View
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the Keywords from Form
            string keywords = txtSearch.Text;

            if (keywords!=null)
            {
                //Search the products
                DataTable dt = pdal.Search(keywords);
                dgvProducts.DataSource= dt;
            }else
            {
                //Display All the Products 
                DataTable dt = pdal.Select();
                dgvProducts.DataSource= dt;
            }
        }
    }
}
