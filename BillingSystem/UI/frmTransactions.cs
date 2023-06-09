﻿using BillingSystem.DAL;
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
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }
        transactionDAL tdal = new transactionDAL();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            //Display all the transactions 
            DataTable dt = tdal.DisplayAlltransactions();
            dgvTransactions.DataSource = dt;    

        }

        private void cmbTransationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the Value Form combobox
            string type= cmbTransationType .Text;

            DataTable dt=tdal.DisplayTransactionByType(type);
            dgvTransactions.DataSource= dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //Display all the transactions
            DataTable dt =tdal.DisplayAlltransactions();
            dgvTransactions.DataSource = dt;

        }
    }
}
