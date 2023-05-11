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
    public partial class frmDeaCusts : Form
    {
        public frmDeaCusts()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //Write the code yo lose this form
            this.Hide();
        }

        DeaCustBLL dc = new DeaCustBLL();
        DeaCustDAL dcDal = new DeaCustDAL();

        userDAL uDAL = new userDAL();


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the Values from Form
            dc.type = cmbDeaCust.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address= txtAddress.Text;
            dc.added_date = DateTime.Now;
            //Getting the ID to logged in user and passign its value in dealer or customer module 
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = uDAL.GetIDFromUsername(loggedUsr);
            dc.added_by = usr.id;


            //Creating boolean varible to check whether the dealer or customer is added or not 
            bool success = dcDal.Insert(dc);

            if(success==true)
            {
                //Dealer or Customer inserted successfullly
                MessageBox.Show("Dealer or Customer Added Succcessfully");
                Clear();
                //Refresh Data Grid View 
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                //failed to insert dealer or customer

            }
        }
        public void Clear()
        {
            txtDeaCustID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            

        }

        private void frmDeaCusts_Load(object sender, EventArgs e)
        {
            //Refresh Data Grid View 
            DataTable dt = dcDal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void dgvDeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int varible to get the identity of row clicked
            int rowIndex = e.RowIndex;

            txtDeaCustID.Text = dgvDeaCust.Rows[rowIndex].Cells[0].Value.ToString();
            cmbDeaCust.Text = dgvDeaCust.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvDeaCust.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDeaCust.Rows[rowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDeaCust.Rows[rowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvDeaCust.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the Values from Form

            dc.id = int.Parse(txtDeaCustID.Text);
            dc.type = cmbDeaCust.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            //Getting the ID to logged in user and passign its value in dealer or customer module 
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = uDAL.GetIDFromUsername(loggedUsr);
            dc.added_by = usr.id;

            //create boolean varible to check whether the dealer or customer is updated or not 
            bool success = dcDal.Update(dc);
            if (success==true) 
            {
                //Dealer and Customer Update Successfully
                MessageBox.Show("Dealer or Customer updated Successfully");
                Clear();
                //Refresh the Data Grid View
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                //Failed to update Dealer or Customer
                MessageBox.Show("Failed to Update Dealer or Customer");

            }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get the id of the user to be deleted from form
            dc.id = int.Parse(txtDeaCustID.Text);

            //Create boolean varible to cheack wheteher the dealer or customer is deleted or not 
            bool success = dcDal.Delete(dc);

            if (success==true) 
            {
                //Dealer or Customer Deleted Successfully
                MessageBox.Show("Dealer or Customer Deleted Successfully");
                Clear();
                //Refresh the Data Grid View 
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;

            }
            else
            {
                //Dealer or Customer Failed to Delete 
                MessageBox.Show("Failed to Delete DEaler or Customer");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from text box 
            string keyword = txtSearch.Text;


            if(keyword!=null)
            {
                //Search the Dealer or Customer
                DataTable dt = dcDal.Search(keyword);
                dgvDeaCust.DataSource = dt;

            }
            else
            {
                //Show all the Dealer  or Customer
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
        }
    }
}
