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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();    
        userDAL udal = new userDAL();
        private void btnADD_Click(object sender, EventArgs e)
        {
            //Get the values  from Category  
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            //Getting ID in Added by field
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);

            //Passign the id of Logged in User in added by field
            c.added_by = usr.id;

            //Creating Boolean Method To insert data into database
            bool success = dal.Insert(c);

            //If the category is inserted successfully then the value of the success will be true else it will be false
            if(success ==true)
            {
                //newCategory Inserted Successfully
                MessageBox.Show("New Category Inserted Successfully.");
                Clear();
                //Refresh Data Grid View
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;

            }
            else
            {
                //Faild to insert New Category
                MessageBox.Show("Failed to Insert New Category.");
            }
        }
        public void Clear()
        {
            txtCategoryID.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";


        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            //Here write the code to display all the categories in data Grid View
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Finding the Row Index of the Row Clicked on Data Grid View
            int RowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();

        }
       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get the ID of the Category Which we want to Delete
            c.id = int.Parse(txtCategoryID.Text);
            
            //Creating Boolean varible to Delete The Category
            bool success = dal.Delete(c);

            //If the cateory is Deleted successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Category Delete Successfully
                MessageBox.Show("Category Deleted Successfully");
                Clear();

                //Refreshing Data Grid View
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                //Failed to Delete Category
                MessageBox.Show("Failed to Delete Category");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the Values from  the Catgory form
            c.id = int.Parse(txtCategoryID.Text);
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            //Getting ID in Added by field
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);

            //Passign the id of Logged in User in added by field
            c.added_by = usr.id;

            //Creating Boolean varible to update categories and check 
            bool success = dal.Update(c);

            //If the cateory is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Category updated Successfully
                MessageBox.Show("Category Updated Successfully");
                Clear();

                //Refreshing Data Grid View
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                //Failed to Update Category
                MessageBox.Show("Failed to Update Category");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the keywords
            string keywords = txtSearch.Text;

            //Filte the categories based on keywords
            if(keywords !=null)
            {
                //Use search Method to display Categories
                DataTable dt= dal.Search(keywords);
                dgvCategories.DataSource = dt;
            }
            else
            {
                //User Select Method to Display All Categories
                DataTable dt = dal.Select();
                dgvCategories.DataSource= dt;
            }
        }
    }
}
